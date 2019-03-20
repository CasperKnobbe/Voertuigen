using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    class Ford : Auto
    {
        private static int standaardWielmaat = 17;

        public Ford(int aantalWielen, List<Wiel> wielen) : base(standaardWielmaat, aantalWielen, wielen)
        {         
        }

        public Ford(int aantalWielen) : base(standaardWielmaat, aantalWielen)
        {
        }
    }
}
