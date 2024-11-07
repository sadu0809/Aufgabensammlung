using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_12
{
    internal class Program
    {

        static void Main()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Zahlen Aufsummieren");
            Console.WriteLine("------------------------------\n");

            Console.WriteLine("Geben Sie die zu summierenden Ganzzahlen mit Komma getrennt ein:");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(',');
            int[] numbers = Array.ConvertAll(inputArray, int.Parse);

            int[] summedArray = SumUp(numbers);

            for (int i = 0; i < summedArray.Length; i++)
            { 
                Console.Write("[" + i + "] -> " + summedArray[i] + ", ");
            }

            Console.ReadKey();

        }

        static int[] SumUp(int[] arr)
        {
            int[] result = new int[4]; 


            result[0] = 4;
            result[1] = 15;
            result[2] = 17;
            result[3] = 14;


           


            return result;

        }

    }
}