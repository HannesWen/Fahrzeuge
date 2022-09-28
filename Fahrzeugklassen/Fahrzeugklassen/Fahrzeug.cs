using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugklassen
{
    internal class Fahrzeug
    {
        public string Hersteller { get; set; }
        public int Reifenanzahl { get; set; }
        public int Maximalgeschwindigkeit { get; set; }
        public float Preis { get; set; }

        public Fahrzeug (string hersteller, int reifenanzahl, int maximalgeschwindigkeit, float preis)
        {
            Hersteller = hersteller;
            Reifenanzahl = reifenanzahl;
            Maximalgeschwindigkeit = maximalgeschwindigkeit;
            Preis = preis;
        }

        public static void FrageNachFahrzeugdaten()
        {
            Console.WriteLine("Was für einen Hersteller hat das Fahrzeug ");
            Fahrzeug fahrzeug1 = new Fahrzeug();
            fahrzeug1.Hersteller = Console.ReadLine();
            Console.WriteLine("Wie viele Reifen hat dein Fahrzeug?");
            fahrzeug1.Reifenanzahl = int.Parse(Console.ReadLine());
            Console.WriteLine("Was ist die Maximalgeschwindigkeit deines Fahrzeugs");
            fahrzeug1.Maximalgeschwindigkeit = int.Parse(Console.ReadLine());
            Console.WriteLine("Wie teuer ist dein Fahrzeug");
            fahrzeug1.Preis = float.Parse(Console.ReadLine());
        }

        public static void FahrzeugdatenInListe(string hersteller, int reifenanzahl, int maximalgeschwindigkeit, float preis)
        {

        }

        public static void PrintFahrzeugInformation()
        {
            Console.WriteLine($"Das Fahrzeug hat den Hersteller {Hersteller} , die Reifenzahl {Reifenanzahl} , die Maximalgeschwindigkeit {Maximalgeschwindigkeit} und kostet {Preis} €");
        }

        public static void MotorStarten()
        {
            if 
            Console.WriteLine("Der Motor startet");
            else
            Console.WriteLine("Der Motor ist schon an und startet nicht");

        }
        public static void Beschleunigen()
        {

        }
        public static void Bremsen()
        {

        }
        public static void Blinken()
        {

        }
        public static void LichtAnschalten()
        {

        }
        public static void LichtAusschalten()
        {

        }

    }
}
