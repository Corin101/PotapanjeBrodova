using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class KružniPucač : IPucač
    {


        public KružniPucač(Mreža mreza, Polje pogođeno, int duljinaBroda)
        {
            this.mreza = mreza;
            prvoPogođenoPolje = pogođeno;
            this.duljinaBroda = duljinaBroda;
        }

        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Polje Gađaj()
        {
            throw new NotImplementedException();
        }

        public void ObradiGađanja(RezultatGađanja rezultat)
        {
            throw new NotImplementedException();
        }
        private IEnumerable<Polje> DajKandidate()
        {
            List<Polje> kandidati = new List<Polje>();
            foreach (Smjer smjer in Enum.GetValues(typeof(Smjer)))
            {
               var lista =  mreza.DajNizSlobodnihPolja(prvoPogođenoPolje,smjer);
            }

            return kandidati;
        }
        private Mreža mreza;
        private Polje prvoPogođenoPolje;
        private int duljinaBroda;
    }
}
