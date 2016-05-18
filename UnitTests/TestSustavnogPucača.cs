﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Collections.Generic;
namespace UnitTests
{
    [TestClass]
    public class TestSustavnogPucača
    {
        [TestMethod]
        public void SustavniPucač_DajeLijevoIliDesnoPoljeZaHorizontalniSmjer()
        {
            List<Polje> PogođenaPolja = new List<Polje> { new Polje(3, 2), new Polje(3, 3) };
            Mreža mreža = new Mreža(10, 10);
            SustavniPucač p = new SustavniPucač(pogođenaPolja, mreža);
            List<Polje> kandidati = new List<Polje> { new Polje(3, 1), new Polje(3, 4) };
            Assert.IsTrue(kandidati.Contains(p.UputiPUcanj()));

        }
        [TestMethod]
        public void SustavniPucač_DajeLijevoIliDesnoPoljeZaVertikalniSmjer()
        {
            List<Polje> PogođenaPolja = new List<Polje> { new Polje(2, 2), new Polje(3, 2) };
            Mreža mreža = new Mreža(10, 10);
            SustavniPucač p = new SustavniPucač(pogođenaPolja, mreža);
            List<Polje> kandidati = new List<Polje> { new Polje(1, 2), new Polje(4, 2) };
            Assert.IsTrue(kandidati.Contains(p.UputiPUcanj()));

        }
        [TestMethod]
        public void SustavniPucač_DajeDonjePoljeZaVertikalniSmjer()
        {
            List<Polje> PogođenaPolja = new List<Polje> { new Polje(0, 2), new Polje(1, 2) };
            Mreža mreža = new Mreža(10, 10);
            SustavniPucač p = new SustavniPucač(pogođenaPolja, mreža);
            Assert.AreEqual(new Polje(2,2),p.UputiPucanj));

        }
        [TestMethod]
        public void SustavniPucač_DajeDesnoPoljeZaHorizontalniSmjerAkoJeLijevoPoljeVecEliminirano()
        {
            List<Polje> PogođenaPolja = new List<Polje> { new Polje(3, 2), new Polje(3, 3) };
            Mreža mreža = new Mreža(10, 10);
            mreža.EliminirajPolje(3, 1);
            SustavniPucač p = new SustavniPucač(pogođenaPolja, mreža);
            List<Polje> kandidati = new List<Polje> { new Polje(3, 4) };
            Assert.IsTrue(kandidati.Contains(p.UputiPUcanj()));

        }
    }
}
