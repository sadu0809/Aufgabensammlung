using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_10
{
   
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Gib eine Zahl ein, um die Quersumme zu berechnen:");
                int zahl = int.Parse(Console.ReadLine());

                int quersumme = BerechneQuersumme(zahl);
                Console.WriteLine("Die Quersumme ist: " + quersumme);
            Console.ReadKey();

           
            }
             

            static int BerechneQuersumme(int zahl)
            {
                int sum = 0;

                while (zahl != 0)
                {
                    sum += zahl % 10;
                    zahl /= 10;
                }

                return sum;
            }
        }
    

}

