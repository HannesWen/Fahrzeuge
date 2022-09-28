using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugklassen
{
    public class Motorrad : Fahrzeug
    {
        public int Getriebe { get; set; }

        public Motorrad(int getriebe)
        {
            Getriebe = getriebe;
        }
    }
}
