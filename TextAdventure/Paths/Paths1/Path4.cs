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
            Writer.TextMod("LAST CHOICE");
            do
            {
                Writer.TextMod("Choose a Route to go down!");
                Writer.TextMod("Pick a number 1-4 to confirm your decision!");
                Writer.TextMod("Lose 1");
                Writer.TextMod("Lose 2");
                Writer.TextMod("Lose 3");
                Writer.TextMod("Lose 4");
                reply = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (reply)
                {
                    case 1:
                        Writer.Hasslehoff("YOU WIN!!");
                        Writer.TextMod("Good thing you dont actually pay attention to string contents.");
                        Console.ReadLine();
                        break;
                    case 2:
                        Writer.Hasslehoff("YOU DIED");
                        Writer.TextMod("Press enter to retry..");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    case 3:
                        Writer.Hasslehoff("YOU DIED");
                        Writer.TextMod("Press enter to retry..");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    case 4:
                        Writer.Hasslehoff("YOU DIED");
                        Writer.TextMod("Press enter to retry..");
                        Console.ReadLine();
                        Environment.Exit(0);
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
