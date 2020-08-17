using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppZahlenratenSchleife
{
    class Program
    {
        private static Random zuffall = new Random();
        private static int ratezahl = zuffall.Next(1, 101);
        private static int eingabe;
        private static int versuche = 0;

        static void Main(string[] args)
        {
            do
            {
                versuche++;
                Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 100 ein: ");
                eingabe = Convert.ToInt32(Console.ReadLine());
                if (eingabe < ratezahl) //Wenn
                {
                    Console.WriteLine("Die eingegebene Zahl war zu klein! Noch ein Versuch: ");
                }
                else if (eingabe > ratezahl) //oder wenn
                {
                    Console.WriteLine("Die eingegebene Zahl war zu groß! Noch ein Versuch: ");
                }
            } while (eingabe != ratezahl);
            Console.WriteLine("Sie haben die Zahl in " + versuche + " Versuchen erraten, es war die " + ratezahl);
            Console.ReadKey();
        }
    }
}