using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace PotapanjeBrodova
{
    public class KružniPucač : IPucač
    {


        public KružniPucač(Mreža mreza, Polje pogođeno, int duljinaBroda)
        {
            this.mreža = mreza;
            pogođenaPolja.Add(pogođeno);
            this.duljinaBroda = duljinaBroda;
        }

        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                Debug.Assert(pogođenaPolja.Count <= 2);
                return pogođenaPolja.Sortiraj();
            }
        }

        public Polje Gađaj()
        {
            List<Polje> kandidati = DajKandidate();
            gađanoPolje = kandidati[izbornik.Next(kandidati.Count)];
            return gađanoPolje;
        }

        public void ObradiGađanja(RezultatGađanja rezultat)
        {
            mreža.UkloniPolje(gađanoPolje);
            switch (rezultat)
            {
                case RezultatGađanja.Promašaj:
                    return;
                case RezultatGađanja.Pogodak:
                    pogođenaPolja.Add(gađanoPolje);
                    return;
                case RezultatGađanja.Potopljen:
                    pogođenaPolja.Add(gađanoPolje);
                    TerminatorPolja terminator = new TerminatorPolja(mreža);
                    terminator.UkloniPolja(pogođenaPolja);
                    return;
                default:
                    Debug.Assert(false);
                    break;
            }
        }
        private List<Polje> DajKandidate()
        {
            Debug.Assert(pogođenaPolja.Count == 1);
            List<Polje> kandidati = new List<Polje>();
            foreach (Smjer smjer in Enum.GetValues(typeof(Smjer)))
            {
                var niz = mreža.DajNizSlobodnihPolja(pogođenaPolja[0], smjer);
                if (niz.Count() > 0)
                    kandidati.Add(niz.ElementAt(0));
            }
            Debug.Assert(kandidati.Count() > 0);
            return kandidati;
        }
        private Mreža mreža;
        private Polje gađanoPolje;
        private int duljinaBroda;
        private List<Polje> pogođenaPolja = new List<Polje>();
        private Random izbornik = new Random();
    }
}
