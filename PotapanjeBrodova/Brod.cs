using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public enum RezultatGadanja {
        Promasaj,
        Pogodak,
        Potonuce,
    }
    public class Brod
    {
        public Brod(IEnumerable<Polje> polja)
        {
            this.Polja = polja;
        }

        public int Duljina
        {
            get { return Polja.Count(); }
        }
        public RezultatGadanja Gadaj(Polje p) {

            if (Polja.Contains(p)) {
                pogodenaPolja.Add(p);
                if (pogodenaPolja.Count == Polja.Count())
                    return RezultatGadanja.Potonuce;
                return RezultatGadanja.Pogodak;
            }
            return RezultatGadanja.Promasaj;
        }

        public readonly IEnumerable<Polje> Polja;
        private HashSet<Polje> pogodenaPolja = new HashSet<Polje>();
    }
}
