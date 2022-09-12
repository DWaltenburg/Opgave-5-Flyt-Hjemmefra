using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5_Flyt_Hjemmefra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey tast;
            do
            {
                SkrivVelkomst();
                Console.Write("Hvad er dit navn: ");
                string navn = Console.ReadLine();
                double timeløn = ReadDouble("Indtast din timeløn: ");
                double timer = ReadDouble("Hvor mange timer arbejder du om ugen: ");
                double ugeløn = timeløn * timer;
                Console.WriteLine($"Hej, {navn}. Du tjener kr. {ugeløn},- om ugen.");
                double stjerner = ugeløn / 100;
                for (int i = 0; i < stjerner; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                if (ugeløn > 2600)
                {
                    Console.WriteLine("Du har råd til at flytte hjemmefra.");
                }
                else
                {
                    Console.WriteLine("Du har ikke råd til at flytte hjemmefra.");
                }

                Console.WriteLine("Tryk på en tast for at starte forfra. ESC for at afslutte...");
                tast = Console.ReadKey().Key;
            } while (tast != ConsoleKey.Escape);
        }
        static void SkrivVelkomst()
        {
            Console.Clear();
            Console.WriteLine("Velkommen til Ungeråd's Flyt-hjemmefra service");

        }

        static double ReadDouble( string promt)
        {
            Console.Write(promt);
            string input = Console.ReadLine();
            double value = Convert.ToDouble(input);
            return value;
        }
    }
}
