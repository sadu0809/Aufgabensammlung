using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schreibe einen Kommentar: ");
            string kommentar = Console.ReadLine();
            string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch" };

           
            if (forbiddenWords.Any(word => kommentar.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0))

            {
                Console.WriteLine("Dein Kommentar enthält verbotene Wörter.");
                Console.WriteLine("Er wird nicht veröffentlicht.");
            }
            else
            {
                Console.WriteLine("Vielen Dank für deinen Kommentar");
            }

            Console.ReadKey();
        }
    }
}
