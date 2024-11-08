using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aufgabe_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                Random random = new Random();
                int zufallszahl = random.Next(1, 100);
                int count = 0;
                int zahl1 = 0;

                Console.WriteLine("Deine Zahl (1..100): ");

                while (zahl1 != zufallszahl)
                {
                    zahl1 = int.Parse(Console.ReadLine());

                    if (zahl1 > zufallszahl)
                    {
                        Console.WriteLine("Zahl ist zu groß! Nächster Versuch: ");
                    }
                    else if (zahl1 < zufallszahl)
                    {
                        Console.WriteLine("Zahl ist zu klein! Nächster Versuch: ");
                    }
                    count++;
                }

                Console.WriteLine("Die Zahl stimmt! Du hast insgesamt " + count + " Versuche benötigt. Möchtest du nochmal spielen? [y/n]");
                var key = Console.ReadKey().Key;

                if (key == ConsoleKey.Y)
                {
                    Console.Clear(); 
                }
                else if (key == ConsoleKey.N)
                {
                    playAgain = false;
                }
            }
        }


    }
}
