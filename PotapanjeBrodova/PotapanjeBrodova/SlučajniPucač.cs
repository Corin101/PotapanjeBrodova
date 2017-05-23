using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class SlučajniPucač : IPucač
    {
        // moja implementacija konstruktora za slučajniPucač
        public SlučajniPucač(Mreža mreza, List<int>brodovi)
        {
            mreža = mreza;
            najdužiBrod = brodovi.Max();
        }

        // konstruktor napravljen na vježbi
        public SlučajniPucač(Mreža mreza, int duljinaBroda)
        {
            mreža = mreza;
            this.najdužiBrod = duljinaBroda;
        }

        Polje TraziNajboljePolje()
        {
            foreach (IEnumerable<IEnumerable<Polje>> nizPolja in mreža.DajNizoveSlobodnihPolja(najdužiBrod))
            {
                foreach (Polje polje in nizPolja)
                {
                    if (!mapa.ContainsKey(polje))
                    {
                        mapa.Add(polje, 0);
                    }
                    else
                    {
                        mapa[polje] += 1; 
                    }                       
                }
            }
            var poslozeniRijecnik = mapa.OrderBy(x => x.Value);
          
            int max = poslozeniRijecnik.First().Value;
            foreach (KeyValuePair<Polje, int> izborPolja in poslozeniRijecnik)
            {
                if (izborPolja.Value != max)
                    mapa.Remove(izborPolja.Key);                      
            }
            List<Polje> keyList = new List<Polje>(mapa.Keys);
            return keyList[slucajniBroj.Next(keyList.Count())];
        }

        public Polje Gađaj()
        {
            var kandidati = DajKandidate();
            Debug.Assert(kandidati.Count > 0);
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

        private Dictionary<Polje, int> mapa;
        private Polje gađanoPolje;
        private Mreža mreža;
        private int najdužiBrod;
        private int duljinaBroda;
        private List<Polje> pogođenaPolja = new List<Polje>();
        private Random slucajniBroj = new Random();
        private Random izbornik = new Random();

        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                return pogođenaPolja.Sortiraj();
            }
        }
        private List<Polje> DajKandidate()
        {
            return mreža.DajNizoveSlobodnihPolja(duljinaBroda).SelectMany(niz => niz).ToList();
        }
    }
}
