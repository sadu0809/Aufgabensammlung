using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_13
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("Wie lang soll die Linie sein? ");
                int lineLength = Convert.ToInt32(Console.ReadLine());
                 Console.Write("Deine Eingabe: " + lineLength);


            for (int i = 0; i <= lineLength; i++)
                {
                    for (int j = 0; j <= lineLength; j++)
                    {

                        if (i == j)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                
                    Console.WriteLine();
                }


            Console.ReadKey();
            }
        }
    }

    
   

