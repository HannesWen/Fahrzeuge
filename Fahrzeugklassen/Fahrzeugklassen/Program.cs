using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugklassen
{
    internal class Program
    {
        static void Main(string[] args)
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




            Das Fahrzeug hat den Hersteller { Hersteller} , die Reifenzahl { Reifenanzahl} , die Maximalgeschwindigkeit { Maximalgeschwindigkeit}
            und kostet { Preis} €"


        }
    }
}
