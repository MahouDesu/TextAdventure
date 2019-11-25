using System;
using Console = Colorful.Console;
using System.Collections.Generic;
using System.Drawing;

namespace TextAdventure
{
    class Path3
    {
        static public bool Route()
        {
            int reply;
            bool canContinue = true;
            Writer.Hasslehoff("TEXT ADVENTURE");
            do
            {
                Writer.TextMod("Choose a Route to go down!");
                Writer.TextMod("Pick a number 1-4 to confirm your decision!");
                Writer.TextMod("Option 1");
                Writer.TextMod("Option 2");
                Writer.TextMod("Option 3");
                Writer.TextMod("Option 4");
                reply = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (reply)
                {
                    case 1:
                        Writer.TextMod("");
                        break;
                    case 2:
                        Writer.TextMod("Path 3 case 2 triggered");
                        break;
                    case 3:
                        Writer.TextMod("Path 3 case 3 triggered");
                        break;
                    case 4:
                        Writer.TextMod("exiting switch");
                        canContinue = false;
                        break;
                    default:
                        Writer.TextMod("activating default, exiting switch");
                        canContinue = false;
                        break;
                }
            } while (canContinue);
            return true;
        }
    }
}