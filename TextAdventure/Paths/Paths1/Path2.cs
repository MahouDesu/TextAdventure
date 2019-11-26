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
                        System.Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[████████████████████  ]");
                        System.Console.ResetColor();
                        Writer.Delay = 100;
                        Writer.TextMod("You take 10 damage.");
                        Writer.Delay = 40;
                        Console.Clear();
                        Path3.Route();
                        break;
                    case 2:
                        Writer.Hasslehoff("BEAR ATTACK");
                        Writer.TextMod("You died.");
                        Writer.TextMod("Press enter to retry.");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    case 3:
                        Writer.Hasslehoff("YOU DID IT!");
                        Writer.TextMod("You dodged all the bad stuff!");
                        Console.Clear();
                        Path4.Route();
                        break;
                    case 4:
                        Writer.Hasslehoff("YOU DIED");
                        Writer.Delay = 150;
                        Writer.TextMod("You died, we'll get em next time.");
                        Writer.TextMod("Press enter to continue..");
                        Console.ReadLine();
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
