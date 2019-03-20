using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    class Band
    {
        private readonly int _maat;
        private readonly static int standardMaat = 17;

        public int Maat
        {
            get
            {
                return _maat;
            }
        }

        public Band() : this(standardMaat)
        {
        }

        public Band(int maat)
        {
            _maat = maat;
        }
    }
}
