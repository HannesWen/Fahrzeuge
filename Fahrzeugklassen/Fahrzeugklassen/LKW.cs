using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugklassen
{
    public class LKW : Fahrzeug
    {
        public string Getriebe { get; set; }
        public int Schlafplätze { get; set; }
        
        public LKW (string getriebe, int schlafplätze)
        {
            Getriebe = getriebe;
            Schlafplätze = schlafplätze;
        }

    }
}
