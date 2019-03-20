using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    class Bus : Voertuig
    {
        private static int standaardWielmaat = 25;

        public Bus(int aantalWielen, List<Wiel> wielen) : base(standaardWielmaat, aantalWielen, wielen)
        {
        }

        public Bus(int aantalWielen) : base(standaardWielmaat, aantalWielen)
        {
        }
    }
}
