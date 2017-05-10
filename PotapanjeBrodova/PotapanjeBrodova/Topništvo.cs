﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public enum TaktikaGađanja
    {
        Nasumično,
        Kružno,
        Linijsko
    }
    public class Topništvo
    {
        public Topništvo(int redaka, int stupaca, IEnumerable<int>duljineBrodova)
        {
            mreza = new Mreža(redaka, stupaca);
            this.duljineBrodova = new List<int>(duljineBrodova);
            TaktikaGađanja = TaktikaGađanja.Nasumično;
            //  poziv pucača za mju implementaciju
            //  pucač = new SlučajniPucač(mreza,this.duljineBrodova);
            pucač = new SlučajniPucač(mreza, duljineBrodova.First());
        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            if (rezultat == RezultatGađanja.Promašaj)
                return;
            if (rezultat == RezultatGađanja.Pogodak)
            {
                switch (TaktikaGađanja)
                {
                    case TaktikaGađanja.Nasumično:
                        PromijeniTaktikuUKružno();
                        return;
                    case TaktikaGađanja.Kružno:
                        PromijeniTaktikuULinijsko();
                        return;
                    case TaktikaGađanja.Linijsko:
                        return;
                    default:
                        Debug.Assert(false);
                        break;
                }
            }
            Debug.Assert(rezultat == RezultatGađanja.Potopljen);
            PromijeniTaktikuUNasumično();
        }

       private  void PromijeniTaktikuUKružno()
        {
            TaktikaGađanja = TaktikaGađanja.Kružno;
        }
        private void PromijeniTaktikuULinijsko()
        {
            TaktikaGađanja = TaktikaGađanja.Linijsko;
        }
        private void PromijeniTaktikuUNasumično()
        {
            TaktikaGađanja = TaktikaGađanja.Nasumično;
        }

        public TaktikaGađanja TaktikaGađanja { get; private set; }

        private Mreža mreza;
        private List<int> duljineBrodova;
        private IPucač pucač;
    }
}
