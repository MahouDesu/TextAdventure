using System;
using Console = Colorful.Console;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace TextAdventure
{
    static class Path1
    {
        static public bool Route()
        {
            int reply;
            bool canContinue = true;

            Writer.Hasslehoff("TEXT ADVENTURE");
            do
            {
                Writer.TextMod("Choose a Route to go down!");
                Writer.TextMod("Pick a number 1-5 to confirm your decision!");
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
                        Writer.TextMod("NANI?!");
                        Console.ReadLine();
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    case 3:
                        Writer.Hasslehoff("NEXT QUESTION");
                        Writer.TextMod("");
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
                        Writer.Hasslehoff("");
                        Writer.TextMod("");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Writer.TextMod("please pick a number 1-5");
                        break;

                }
            } while (canContinue);
            return true;

        }
    }
}
