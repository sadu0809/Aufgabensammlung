using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prüfen, ob es sich bei einem Jahr um ein Schaltjahr handelt.");
            Console.WriteLine("************************************************************");
            Console.Write("Eingabe Jahr (q to quit): ");
            string eingabe = Console.ReadLine();
            int ant = Convert.ToInt32(eingabe);

            if (ant % 4 == 0 || ant % 100 == 0)
            {
                if (ant % 400 == 0)
                {

                    Console.WriteLine("Das Jahr " + ant + " ist KEIN Schaltjahr.");
                }
                else
                {
                    Console.WriteLine("Das Jahr " + ant + " ist ein Schaltjahr.");
                    Console.ReadKey();

                }
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Das Jahr " + ant + " ist KEIN Schaltjahr.");
            }
            
            // "q to quit" noch nicht gemacht 

        }
    }   
}

    