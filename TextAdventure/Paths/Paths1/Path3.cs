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
                        Writer.Hasslehoff("CRITICAL!");
                        Console.WriteLine("[                      ]");
                        Writer.TextMod("You take 100 damage?!");
                        Writer.TextMod("You died, press enter to continue.");
                        Console.ReadLine();
                        break;
                    case 2:
                        Writer.Hasslehoff("YOU DIED..");
                        Console.WriteLine("[                      ]");
                        Writer.TextMod("You take 1 damage");
                        Writer.TextMod("You died, press enter to continue.");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    case 3:
                        Writer.Hasslehoff("SUPER EFFECTIVE");
                        Console.WriteLine("[                      ]");
                        Writer.TextMod("You take 500 damage?!");
                        Writer.TextMod("You died, press enter to continue.");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    case 4:
                        Writer.Hasslehoff("YOU'VE GOTTA BE KIDDING ME");
                        Console.WriteLine("[                      ]");
                        Writer.TextMod("You take 100,000,000 damage???? Actually how did you do that?");
                        Writer.TextMod("You died, press enter to continue.");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Writer.TextMod("Please input a number between 1-4");
                        canContinue = false;
                        break;
                }
            } while (canContinue);
            return true;
        }
    }
}