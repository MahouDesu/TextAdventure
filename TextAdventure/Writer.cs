using Colorful;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using Console = Colorful.Console;

namespace TextAdventure
{
    class Writer
    {
        
        static public int Delay { get; set; } = 40;
        public static void TextMod(string text)
        {
            foreach (char letter in text)
            {
                Thread.Sleep(Delay);
                Console.Write(letter);
            }
            Console.WriteLine();
        }
        static public string Plug { get; set; }
        public static void Hasslehoff(string plug)
        {
            int DA = 193;
            int V = 176;
            int ID = 23;
            for (int i = 0; i < 1; i++)
            {
                Console.WriteAscii(plug, Color.FromArgb(DA, V, ID));

                DA -= 50;
                V -= 120;
            }
        }

        //public class RainbowColor
        //{
        //    public static Color Rainbow(float progress)
        //    {
        //        float div = (Math.Abs(progress % 1) * 6);
        //        int ascending = (int)((div % 1) * 255);
        //        int descending = 255 - ascending;

        //        switch ((int)div)
        //        {
        //            case 0:
        //                return Color.FromArgb(255, 255, ascending, 0);
        //            case 1:
        //                return Color.FromArgb(255, descending, 255, 0);
        //            case 2:
        //                return Color.FromArgb(255, 0, 255, ascending);
        //            case 3:
        //                return Color.FromArgb(255, 0, descending, 255);
        //            case 4:
        //                return Color.FromArgb(255, ascending, 0, 255);
        //            default: // case 5:
        //                return Color.FromArgb(255, 255, 0, descending);
        //        }
        //    }
        //}
    }
}








