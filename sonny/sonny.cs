using System;
using sonny.Speech;

namespace sonnyAI
{
    public class sonny
    {
        public EventHandler Exit;
        public sonny()
        {
            RespondToUser("How are you?");
            string input = Console.ReadLine();
            switch (input)
            {
                case "Good":
                case "good":
                case "great":
                case "Great":
                    RespondToUser("That's good!");
                    break;
                default:
                    RespondToUser("I don't know what that means, but I'm good!");
                    break;
            }
            RespondToUser("This is the part where you tell me what to do.");
        }

        public void Listen(string input)
        {
            switch (input)
            {
                case "exit":
                    EventArgs eventArgs = new EventArgs();
                    OnExit(eventArgs);
                    break;
                default:
                    RespondToUser("I don't recognize that command.");
                    RespondToUser("Current commands:");
                    RespondToUser("exit : quits the program");
                    break;
            }
        }

        private void OnExit(EventArgs e)
        {
            Thought thought = new Thought();
            RespondToUser(thought.SayGoodbye());
            EventHandler handler = Exit;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void RespondToUser(string response)
        {
            Console.WriteLine("\n\n\"" + response + "\"");
        }
    }
}
