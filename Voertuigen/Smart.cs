using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    class Smart : Auto
    {
        private static int standaardWielmaat = 15;

        public Smart(int aantalWielen, List<Wiel> wielen) : base(standaardWielmaat, aantalWielen, wielen)
        {
        }

        public Smart(int aantalWielen) : base(standaardWielmaat, aantalWielen)
        {
        }
    }
}
