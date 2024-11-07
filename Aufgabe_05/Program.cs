using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen? ");
            string anzahlkm= Console.ReadLine();
            byte anzahl_km=Convert.ToByte(anzahlkm);

            if (anzahl_km > 42)
            {
                Console.WriteLine("Das schaffst du nicht! ");
            }
            else if (anzahl_km <= 42)
            {
                int n = anzahl_km * 1000 / 400;
                Console.WriteLine("Das sind " + n + " Runden. Bereit für den Lauf?" );
                string frage = Console.ReadLine();
                string antwort = frage;

                if (antwort == "ja")
                {
                    int i = 1;

                    while (i <= n)
                    {
                        Console.WriteLine("Du läufst Runde " + i);
                        i++;
                    }
                    if (i > n)
                    {
                        Console.Write("Du hast es geschafft!");
                    }
                }
                else if (antwort == "nein") ;
                {

                }
            }
            Console.ReadKey();
        }
    }
}
