using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class Brodograditelj
    {
        public Flota SloziFlotu(Mreža mreža, IEnumerable<int> duljinaBrodova)
        {
            Flota flota = new Flota();
            TerminatorPolja termi = new TerminatorPolja(mreža);

            foreach (int i in duljinaBrodova)
            {
                var nizovi = mreža.DajNizoveSlobodnihPolja(i);
                int index = slucajniBrojevi.Next(nizovi.Count());
                var niz = nizovi.ElementAt(index);
                flota.DodajBrod(niz);
                termi.UkloniPolja(niz);
            }
            return flota;
        }

        // TODO obratiti paznju za slucaj da se ne mogu svi brodovi sloziti.

        private Random slucajniBrojevi = new Random();
    }
}
