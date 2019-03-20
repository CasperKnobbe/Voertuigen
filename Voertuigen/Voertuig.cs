using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    abstract class Voertuig
    {
        public List<Wiel> Wielen { get; set; }
        public int WielMaat { get; set; }
        public int AantalWielen { get; set; }

        public void VoegWielToe(Wiel wiel)
        {
            if(wiel.Maat != WielMaat)
            {
                throw new ArgumentException("Er wordt geprobeerd een wiel toe te voegen dat niet op dit voertuig past");
            }

            Wielen.Add(wiel);
        }

        public Voertuig(int wielMaat, int aantalWielen, List<Wiel> wielen)
        {
            WielMaat = wielMaat;
            AantalWielen = aantalWielen;
            Wielen = new List<Wiel>();
            foreach (Wiel wiel in wielen)
            {
                VoegWielToe(wiel);
            }
        }

        public Voertuig(int wielMaat, int aantalWielen)
        {
            WielMaat = wielMaat;
            AantalWielen = aantalWielen;
            Wielen = new List<Wiel>();
            for (int i = 0; i < aantalWielen; i++)
            {
                VoegWielToe(new Wiel(WielMaat));
            }
        }
    }
}
