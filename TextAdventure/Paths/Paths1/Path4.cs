using System;
using Console = Colorful.Console;
using System.Collections.Generic;
using System.Drawing;

namespace TextAdventure
{
    class Path4
    {
        static public bool Route()
        {
            Writer.Delay = 40;
            int reply;
            bool canContinue = true;
            Writer.TextMod("TEXT ADVENTURE");
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
                        Writer.TextMod("path 4 case 1 triggered");
                        break;
                    case 2:
                        Writer.TextMod("Path 4 case 2 triggered");
                        break;
                    case 3:
                        Writer.TextMod("Path 4 case 3 triggered");
                        break;
                    case 4:
                        Writer.TextMod("Path 4 case 3 triggered");
                        break;
                    case 5:
                        Writer.TextMod("exiting switch");
                        canContinue = false;
                        break;
                    default:
                        Writer.TextMod("please press a number 1-5");
                        break;
                }
            } while (canContinue);
            return true;
        }
    }
}
