using System.Collections.Generic;

namespace PotapanjeBrodova
{
    public class Flota
    {
        public void DodajBrod(Brod b)
        {
            brodovi.Add(b);
        }

        public IEnumerable<Brod> Brodovi
        {
            get { return brodovi; }
        }

        public int BrojBrodova
        {
            get { return brodovi.Count; }
        }
        public RezultatGadanja Gadaj(Polje polje) {
            foreach (Brod b in brodovi) {
                b.Gadaj(polje);
                var rezultat = b.Gadaj(polje);
                if (b.Gadaj(polje) != RezultatGadanja.Promasaj){

                    return rezultat;
                }
                
            }
            return RezultatGadanja.Promasaj;
        }
        List<Brod> brodovi = new List<Brod>();
    }
}
