using System;
using Console = Colorful.Console;
using System.Collections.Generic;


namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            int reply;
            bool canContinue = true;

            Writer.Hasslehoff("TEXT ADVENTURE");
            Writer.TextMod("Welcome to TEXT ADVENTURE, your source for excitement at every turn.");
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
                        Writer.Hasslehoff("PUPPIES");
                        Writer.TextMod("You aquired PUPPIES");
                        Writer.TextMod("Press enter to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        Path1.Route();
                        break;
                    case 2:
                        Writer.Hasslehoff("YOU DIED");
                        Writer.TextMod("You died try again..");
                        canContinue = false;
                        break;
                    case 3:
                        Writer.Hasslehoff("DAMAGE");
                        Console.WriteLine("[██████████            ]");
                        Writer.TextMod("You take 3 damage.");
                        Writer.TextMod("Press enter to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        Path1.Route();
                        break;
                    case 4:
                        Writer.Hasslehoff("TEXT ADVENTURE");
                        Writer.Delay = 400;
                        Writer.TextMod("this text is slower.. Have fun waiting..");
                        Writer.TextMod("Press enter to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        Path1.Route();
                        break;
                    default:
                        Writer.TextMod("Please pick an option 1-5");
                        break;
                }
            } while (canContinue);
            Writer.TextMod("press enter to exit");
            Console.ReadLine();

        }
    }
}
