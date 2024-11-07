using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Tage hat der Monat, für den sie die Sekundenanzahl berechnen wollen?: ");
            string anzahlTage= Console.ReadLine();  
            int anzahlTage1= Convert.ToInt32(anzahlTage);

            if (anzahlTage1 == 28)
            {
                Console.WriteLine("Ein Monat mit 28 Tagen hat: " + 28 * 86400 + "Sekunden");
            }
            else if (anzahlTage1 == 29)
            {
                Console.WriteLine("Ein Monat mit 29 Tagen hat: " + 29 * 86400 + "Sekunden");
            }
            else if (anzahlTage1 == 30)
            {
                Console.WriteLine("Ein Monat mit 30 Tagen hat: " + 30 * 86400 + "Sekunden");
            }
            else if (anzahlTage1 == 31)
            {
                Console.WriteLine("Ein Monat mit 31 Tagen hat " + 31 * 86400 + " Sekunden");
            }
            Console.ReadKey();
        }
    }
}
