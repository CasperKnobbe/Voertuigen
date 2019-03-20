using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    class Wiel
    {
        private static int standaardMaat = 17;

        public int Maat { get; }
        public Band Band { get; set; }
        public Velg Velg { get; set; }

        public Wiel(int maat, Band band, Velg velg)
        {
            if(velg.Maat != maat)
            {
                throw new ArgumentException("De velg heeft niet de juiste maat voor dit wiel.");
            }
            else if(band.Maat != maat)
            {
                throw new ArgumentException("De band heeft niet de juiste maat voor dit wiel.");
            }

            Maat = maat;
            Band = band;
            Velg = velg;
        }

        public Wiel(int maat) : this(maat, new Band(maat), new Velg(maat)) { }
        public Wiel() : this(standaardMaat) { }
    }
}
