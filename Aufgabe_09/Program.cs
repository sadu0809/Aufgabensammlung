using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib eine Dezimalzahl ein: ");
            int n = int.Parse(Console.ReadLine());

            string bin = "";

            while (n > 0)
            {
                int rest = n % 2;      
                bin = rest + bin;       
                n = n / 2;              
            }

           
            Console.WriteLine("Binär: " + bin);
            Console.ReadKey();



        }
    }
}
