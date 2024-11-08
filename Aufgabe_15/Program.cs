using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie die Breite des Stammes ein: ");
            int stammBreite = int.Parse(Console.ReadLine());

            Console.Write("Geben Sie die Höhe des Stammes ein: ");
            int stammHöhe = int.Parse(Console.ReadLine());

            Console.Write("Geben Sie die Höhe der Krone ein: ");
            int kroneHöhe = int.Parse(Console.ReadLine());

            for (int i = 0; i < kroneHöhe; i++)
            {
                int leerzeichen = kroneHöhe - i - 1;
                for (int j = 0; j < leerzeichen; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < (2 * i + 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < stammHöhe; i++)
            {
                int stamm_leerzeichen = (kroneHöhe - 1) - (stammBreite / 2);
                for (int k = 0; k < stamm_leerzeichen; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < stammBreite; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();





        }
    }
}
