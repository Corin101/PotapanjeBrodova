using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class LinijskiPucač : IPucač
    {

        public LinijskiPucač(Mreža mreza, IEnumerable<Polje> pogođeni, int duljinaBroda)
        {
            mreža = mreza;
            pogođenaPolja = new List<Polje>(pogođeni);
            this.duljinaBroda = duljinaBroda;
        }

        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                return pogođenaPolja;
            }
        }

        public Polje Gađaj()
        {
            var kandidati = DajKandidate();
            gađanoPolje = kandidati[izbornik.Next(kandidati.Count)];
            return gađanoPolje;
        }

        private List<Polje> DajKandidate()
        {
            if (pogođenaPolja.First().Redak == pogođenaPolja.Last().Redak)
                return DajHorizontalnaPolja();
            return DajVertikalnaPolja();
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

        List<Polje> DajHorizontalnaPolja()
        {
            List<Polje> polja = new List<Polje>();
            Polje prvo = pogođenaPolja.First();
            Polje zadnje = pogođenaPolja.Last();
            var lijevaPolja = mreža.DajNizSlobodnihPolja(prvo, Smjer.Lijevo);
            if (lijevaPolja.Count() > 0)
                polja.Add(lijevaPolja.First());
            var desnaPolja = mreža.DajNizSlobodnihPolja(zadnje, Smjer.Desno);
            if (desnaPolja.Count() > 0)
                polja.Add(desnaPolja.First());
            return polja;
        }

        List<Polje> DajVertikalnaPolja()
        {
            List<Polje> polja = new List<Polje>();
            Polje gornje = pogođenaPolja.First();
            Polje donje = pogođenaPolja.Last();
            var gornjaPolja = mreža.DajNizSlobodnihPolja(gornje, Smjer.Gore);
            if (gornjaPolja.Count() > 0)
                polja.Add(gornjaPolja.First());
            var doljaPolja = mreža.DajNizSlobodnihPolja(donje, Smjer.Dolje);
            if (doljaPolja.Count() > 0)
                polja.Add(doljaPolja.First());
            return polja;
        }

        private Mreža mreža;
        private List<Polje> pogođenaPolja;
        private int duljinaBroda;
        private Random izbornik = new Random();
        private Polje gađanoPolje;
    }
}
