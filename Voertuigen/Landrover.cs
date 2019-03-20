using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    class Landrover : Auto
    {
        private static int standaardWielmaat = 19;

        public Landrover(int aantalWielen, List<Wiel> wielen) : base(standaardWielmaat, aantalWielen, wielen)
        {
        }

        public Landrover(int aantalWielen) : base(standaardWielmaat, aantalWielen)
        {
        }
    }
}
