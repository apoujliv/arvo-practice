using System;

namespace sonny.Speech.Models
{
    public class Phrases : IPhrases
    {
        public string GenerateRandomHello()
        {
            string[] goodbyeArray =
            {
                "Hello, sunshine!",
                "Howdy, partner!",
                "Hey, howdy, hi!",
                "What’s kickin’, little chicken?",
                "Peek-a-boo!",
                "Howdy-doody!",
                "Hey there, freshman!",
                "Hi, mister!",
                "I come in peace!",
                "Ahoy, matey!",
                "Hiya!"
            };
            Random random = new Random();
            int randomNumber = random.Next(0, goodbyeArray.Length);
            return goodbyeArray[randomNumber];
        }

        public string GenerateIntroduction() {
            return "My name is Sonny.";
        }

        public string GenerateRandomGoodbye()
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

        public string GenerateRandomMessageText()
        {
            string[] quoteArray =
            {
                "'My name is Inigo Montoya. You killed my father. Prepare to die.' —The Princess Bride",
                "'It is a truth universally that a single man in possession of a good fortune must be in want of a wife.' —Pride and Prejudice",
                "Have a biscuit, Potter.' —Harry Potter and the Order of the Phoenix",
                "'It was the best of times, it was the worst of times.' —A Tale of Two Cities",
                "'My dear, I don’t give a damn.' —Gone With the Wind",
                "'Most men and women will grow up to love their servitude and will never dream of revolution.' —Brave New World",
                "'By the time we arrived, as evening was approaching, I felt as sore as a rock must feel when the waterfall has pounded on it all day long.' —Memoirs of a Geisha",
                "'Neighbours bring food with death and flowers with sickness and little things in between.Boo was our neighbour. He gave us two soap dolls, a broken watch and chain, a pair of good luck pennies, and our lives.' —To Kill a Mockingbird",
                "'The man in black fled across the desert, and the gunslinger followed.' —The Gunslinger",
                "'Shoot all the blue jays you want, if you can hit em, but remember that it’s a sin to kill a mockingbird.' —To Kill a Mockingbird",
                "'And so we beat on, boats against the current, borne back ceaselessly into the past.' —The Great Gatsby",
                "'I think of my life as a kind of music, not always good music but still having form and melody.'—East of Eden",
                "'Stay gold, Ponyboy, stay gold.' —The Outsiders",
                "'And in that moment, like a swift intake of breath, the rain came.' —Other Voices, Other Rooms",
                "'Christmas won’t be Christmas without any presents!' —Little Women",
                "'When the day shall come that we do part,' he said softly, and turned to look at me, \"'if my last words are not ‘I love you’—you’ll ken it was because I didn’t have time.' —The Fiery Cross",
                "'Hey, boo.' —To Kill a Mockingbird",
                "'I believe there are monsters born in the world to human parents.' –East of Eden",
                "'I meant what I said and I said what I meant.An elephant’s faithful one - hundred percent!' —Horton Hatches the Egg",
                "'All we have to decide is what to do with the time that is given us.' —The Fellowship of the Ring",
                "'Tomorrow I’ll think of some way to get him back.After all, tomorrow is another day.' —Gone with the Wind",
                "'If this typewriter can’t do it, then f@#$ it, it can’t be done. —Still Life with Woodpecker",
                "'Sometimes you have to keep on steppin’.'—The Watsons Go to Birmingham—1963",
                "'There are few people whom I really love and still fewer of whom I think well.' —Pride and Prejudice",
                "'Stories are for eternity, when memory is erased, when there is nothing to remember except the story.' The Things They Carried",
                "'All happy families are alike; each unhappy family is unhappy in its own way.' –Anna Karenina",
                "'Everything was beautiful and nothing hurt.' —Slaughterhouse - Five",
                "'Marley was dead as a doornail.' —A Christmas Carol",
                "'Many years later, as he faced the firing squad, Colonel Aurelio Buendía was to remember that distant afternoon that his father took him to discover ice.' —One Hundred Years of Solitude",
                "'What fresh hell is this ?' —Jane Eyre",
                "'Heart like shale.What you need is a good fracking.' —MaddAddam",
                "'Always.' —Harry Potter and the Deathly Hallows",
                "'Everything’s profound when there’s guns and zombies.' —Sandman Slim",
                "'To the person in the bell jar, blank and stopped as a dead baby, the world itself is the bad dream.' —The Bell Jar",
                "'For one last time, Miriam does as she is told.' —A Thousand Splendid Suns",
                "'And that’s all we are Jefferson, all of us on this earth, a piece of drifting wood.Until we—each of us, individually—decide to become something else. I am still that piece of drifting wood, and those out there are no better.But you can be better.' —A Lesson Before Dying",
                "'As he read, I fell in love the way you fall asleep: slowly, and then all at once.' —The Fault in Our Stars",
                "'‘Nobody run off with her,’ Roscoe said. ‘She just run off with herself, I guess.'' —Lonesome Dove ",
                "'At the beginning of the summer I had lunch with my father, the gangster, who was in town for the weekend to transact some of his vague business.' —The Mysteries of Pittsburgh",
                "'What keeps you going isn’t some fine destination but just the road you’re on, and the fact that you know how to drive.' —Animal Dreams",
                "'He was dancing, dancing.He says he’ll never die.' —Blood Meridian",
                "'We’re all damaged, somehow.' —A Great and Terrible Beauty",
                "'He’s more myself than I am.' —Wuthering Heights",
                "'Life is pain, highness.Anyone who says differently is selling something.' —The Princess Bride",
                "'You know it don’t take much intelligence to get yourself into a nailed - up coffin, Laura.But who in hell ever got himself out of one without removing one nail ?' —The Glass Menagerie"
            };

            Random random = new Random();
            int randomNumber = random.Next(0, quoteArray.Length);
            return quoteArray[randomNumber];
        }
    }
}
