using System;
using Console = Colorful.Console;
using System.Collections.Generic;
using System.Drawing;

namespace TextAdventure
{
    class Path2
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
                        Writer.Hasslehoff("DANGER");
                        Writer.Delay = 100;
                        Writer.TextMod("You take 10 damage.");
                        Writer.Delay = 40;
                        break;
                    case 2:
                        Writer.TextMod("");
                        break;
                    case 3:
                        Writer.TextMod("Path 2 case 3 triggered");
                        break;
                    case 4:
                        Writer.Hasslehoff("YOU DIED");
                        Writer.Delay = 150;
                        Writer.TextMod("You died, try again..");
                        canContinue = false;
                        Writer.Delay = 40;
                        Environment.Exit(0);
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
