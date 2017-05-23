using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;

namespace Test
{
    [TestClass]
    public class TestLinijskogPucača
    {
        [TestMethod]
        public void LinijskiPucač_GađajVraćaJednoOdDvaPoljaLijevoIliDesnoOdHorizontalnogNiza()
        {
            Mreža m = new Mreža(10, 10);
            Polje[] polja = { new Polje(2, 3), new Polje(2, 4) };
            LinijskiPucač p = new LinijskiPucač(m, polja, 3);
            Polje polje = p.Gađaj();
            Polje[] kandidati = { new Polje(2, 2), new Polje(2, 5) };
            CollectionAssert.Contains(kandidati, polje);
        }

        [TestMethod]
        public void LinijskiPucač_GađajVraćaSamoSlobodnoPoljeLijevoOdHorizontalnogNiza()
        {
            Mreža m = new Mreža(10, 10);
            Polje[] polja = { new Polje(2, 3), new Polje(2, 4) };
            m.UkloniPolje(2, 5);
            LinijskiPucač p = new LinijskiPucač(m, polja, 3);
            Assert.AreEqual(new Polje(2, 2), p.Gađaj());
        }

        [TestMethod]
        public void LinijskiPucač_GađajVraćaSamoSlobodnoPoljeDesnoOdHorizontalnogNiza()
        {
            Mreža m = new Mreža(10, 10);
            Polje[] polja = { new Polje(2, 3), new Polje(2, 4) };
            m.UkloniPolje(2, 2);
            LinijskiPucač p = new LinijskiPucač(m, polja, 3);
            Assert.AreEqual(new Polje(2, 5), p.Gađaj());
        }

        [TestMethod]
        public void LinijskiPucač_GađajVraćaJednoOdDvaPoljaGoreIliDoljeOdVertikalnogNiza()
        {
            Mreža m = new Mreža(10, 10);
            Polje[] polja = { new Polje(2, 3), new Polje(3, 3) };
            LinijskiPucač p = new LinijskiPucač(m, polja, 3);
            Polje polje = p.Gađaj();
            Polje[] kandidati = { new Polje(1, 3), new Polje(4, 3) };
            CollectionAssert.Contains(kandidati, polje);
        }

        [TestMethod]
        public void LinijskiPucač_GađajVraćaSamoSlobodnoPoljeGoreOdVertikalnogNiza()
        {
            Mreža m = new Mreža(10, 10);
            Polje[] polja = { new Polje(2, 3), new Polje(3, 3) };
            m.UkloniPolje(4, 3);
            LinijskiPucač p = new LinijskiPucač(m, polja, 3);
            Polje pogodak = p.Gađaj();
            Assert.AreEqual(new Polje(1, 3), pogodak);
        }

        [TestMethod]
        public void LinijskiPucač_GađajVraćaSamoSlobodnoPoljeDoljeOdVertikalnogNiza()
        {
            Mreža m = new Mreža(10, 10);
            Polje[] polja = { new Polje(2, 3), new Polje(3, 3) };
            m.UkloniPolje(1, 3);
            LinijskiPucač p = new LinijskiPucač(m, polja, 3);
            Polje pogodak = p.Gađaj();
            Assert.AreEqual(new Polje(4, 3), pogodak);
        }
    }
}