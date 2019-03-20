using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    class Velg
    {
        private static readonly int standaardMaat = 17;

        public int Maat { get; }

        public Velg(int maat)
        {
            Maat = maat;
        }

        public Velg() : this(standaardMaat) { }
    }
}
