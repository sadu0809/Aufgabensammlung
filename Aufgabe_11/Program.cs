using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

        
            Console.WriteLine("Zahl 1:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zahl 2:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

        
            Console.WriteLine("Zahl\t Quersumme\t Zahl / Quersumme");

            for (int i = zahl1; i <= zahl2; i++)
            {
                berechneQuersumme(i, out sum);

               
                if (sum != 0 && i % sum == 0)
                {
                    Console.Write(i + "\t");
                    Console.Write(sum + "\t\t");
                    Console.WriteLine(i / sum);  
                }
            }

           
            Console.ReadKey();
        }

       
                  static void berechneQuersumme(int i, out int sum)
                  {
                  sum = 0;

                     while (i != 0)

                     {
                     sum += i % 10;
                     i /= 10;
                     }

                  }
    }


}


