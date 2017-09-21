using System;
using System.Collections.Generic;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(@"                _                        
                \`*-.
                 )  _`-.
                .  : `. .                
                : _   '  \               
                ; *` _.   `*-._
                `-.- '          `-.       
                  ;       `       `.     
                  :.       .        \    
                  . \  .   :   .-'   .   
                  '  `+.;  ;  '      :   
                  :  '  |    ;       ;-. 
                  ; '   : :`-:     _.`* ;
               .* ' /  .*'; .*`-+'  `*'
               `*-*   `*-*  `*-*'        ");
            Console.WriteLine("You've started a console app to test Avro in .Net Core.");
            Console.WriteLine("\nLet's begin.");
            Console.WriteLine("\nWhat is your name?");

            bool isRunning = true;
            while (isRunning)
            {
                var input = Console.ReadLine();
                var date = DateTime.Now;
                if (input == "exit")
                {
                    Exit();
                    return;
                }

                Console.WriteLine($"\nHello, {input}, on {date:d} at {date:t}!");
                Console.Write("\nPress any key to exit..");
                Console.ReadKey(true);
                Exit();
                return;
            }
        }

        private static void Exit()
        {
            Console.WriteLine("\n\n" + GenerateRandomGoodbye());
            System.Threading.Thread.Sleep(2000);
            Console.Write("\nGoodbye.");
            System.Threading.Thread.Sleep(2000);
        }

        private static String GenerateRandomGoodbye()
        {
            string[] goodbyeArray =
            {
                "Goodbyes are only for those who love with their eyes. Because for those who love with heart and soul there is no such thing as separation.",
                "How lucky I am to have something that makes saying goodbye so hard.",
                "What we call the beginning is often the end. And to make an end is to make a beginning. The end is where we start from.",
                "There are no goodbyes for us. Wherever you are, you will always be in my heart.",
                "You have been my friend. That in itself is a tremendous thing.",
                "If you’re brave enough to say goodbye, life will reward you with a new hello.",
                "The two hardest things to say in life are hello for the first time and goodbye for the last.",
                "Man’s feelings are always purest and most glowing in the hour of meeting and of farewell.",
                "Don’t be dismayed at goodbyes. A farewell is necessary before you can meet again. And meeting again, after moments or lifetimes, is certain for those who are friends.",
                "Why can’t we get all the people together in the world that we really like and then just stay together? I guess that wouldn’t work. Someone would leave. Someone always leaves. Then we would have to say good-bye. I hate good-byes. I know what I need. I need more hellos.",
                "All changes, even the most longed for, have their melancholy; for what we leave behind us is a part of ourselves; we must die to one life before we can enter another."
            };
            Random random = new Random();
            int randomNumber = random.Next(0, goodbyeArray.Length);
            return goodbyeArray[randomNumber];
        }
    }
}
