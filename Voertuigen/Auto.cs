using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    class Auto : Voertuig
    {
        public Auto(int wielMaat, int aantalWielen, List<Wiel> wielen) : base(wielMaat, aantalWielen, wielen)
        {
            checkWielMaat(wielMaat);
        }

        public Auto(int wielMaat, int aantalWielen) : base(wielMaat, aantalWielen)
        {
            checkWielMaat(wielMaat);
        }

        private void checkWielMaat(int wielMaat)
        {
            if (wielMaat > 19 || wielMaat < 15)
            {
                throw new ArgumentException("Dit wiel heeft niet de goede maat voor een auto");
            }
        }
    }
}
