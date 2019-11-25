using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    class Path2A
    {
        static public bool Route()
        {
            int reply;
            bool canContinue = true;
            Writer.Hasslehoff("PUPPIEZ");
            do
            {
                Writer.TextMod("What are you going to do with these new found puppies? (Good luck figuring out what the options are... >.>)");
                Writer.TextMod("Option 1");
                Writer.TextMod("Option 2");
                Writer.TextMod("Option 3");
                Writer.TextMod("Option 4");
                Writer.TextMod("Option 5");
                reply = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (reply)
                {
                    case 1:
                        Writer.TextMod("You lose 10 health");
                        Console.ReadLine();
                        Console.Clear();
                        //add continuation
                        break;
                    case 2:
                        Writer.Hasslehoff("OMAE WA MOU");
                        Writer.Hasslehoff("SHINDE IRU");
                        Writer.TextMod("NANI");
                        Console.ReadLine();
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    case 3:
                        Writer.Hasslehoff("NEXT QUESTION");
                        Writer.TextMod("You put them up for adoption");
                        Console.ReadLine();
                        Console.Clear();
                        //add continuation
                        break;
                    case 4:
                        Writer.Hasslehoff("HOW COULD YOU!?");
                        Writer.TextMod("You Monster");
                        Console.ReadLine();
                        Console.Clear();
                        Writer.TextMod("You were arrested, game over..");
                        Environment.Exit(0);

                        break;
                    case 5:
                        Writer.Hasslehoff("METEOR SHOWER");
                        Writer.TextMod("Yay You sheltered the puppies from the meteors!");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Writer.TextMod("please pick a number 1-4");
                        break;

                }
            } while (canContinue);
            return true;

        }
    }
}
