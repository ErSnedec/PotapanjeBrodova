using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;

namespace UnitTests
{
    [TestClass]
    public class TestBroda
    {
        [TestMethod]
        public void Brod_GadajVraćaPromasajZaPoljeKojeNijeUBrodu()
        {
            Polje[] polja = { new Polje(1, 2), new Polje(1, 3), new Polje(1, 4) };
            Brod b = new Brod(polja);
            Assert.AreEqual(RezultatGadanja.Promasaj, b.Gadaj(new Polje(2, 3)));
        }

        [TestMethod]
        public void Brod_GadajVraćaPogodakZaPoljeKojeJeUBrodu()
        {
            Polje[] polja = { new Polje(1, 2), new Polje(1, 3), new Polje(1, 4) };
            Brod b = new Brod(polja);
            Assert.AreEqual(RezultatGadanja.Pogodak, b.Gadaj(new Polje(1, 2)));
        }

        [TestMethod]
        public void Brod_GadajVraćaPotonuceZaZadnjePoljeKojeJeUBrodu()
        {
            Polje[] polja = { new Polje(1, 2), new Polje(1, 3), new Polje(1, 4) };
            Brod b = new Brod(polja);
            Assert.AreEqual(RezultatGadanja.Pogodak, b.Gadaj(new Polje(1, 2)));
            Assert.AreEqual(RezultatGadanja.Pogodak, b.Gadaj(new Polje(1, 3)));
            Assert.AreEqual(RezultatGadanja.Potonuce, b.Gadaj(new Polje(1, 4)));
        }

        [TestMethod]
        public void Brod_GadajVraćaPogodakZaZadnjePoljeKojeJePonovnoPogođeno()
        {
            Polje[] polja = { new Polje(1, 2), new Polje(1, 3), new Polje(1, 4) };
            Brod b = new Brod(polja);
            Assert.AreEqual(RezultatGadanja.Pogodak, b.Gadaj(new Polje(1, 2)));
            Assert.AreEqual(RezultatGadanja.Pogodak, b.Gadaj(new Polje(1, 2)));
        }

        [TestMethod]
        public void Brod_GadajVraćaPotonuceZaZadnjePoljeKojePonovnoGađano()
        {
            Polje[] polja = { new Polje(1, 2), new Polje(1, 3), new Polje(1, 4) };
            Brod b = new Brod(polja);
            Assert.AreEqual(RezultatGadanja.Pogodak, b.Gadaj(new Polje(1, 2)));
            Assert.AreEqual(RezultatGadanja.Pogodak, b.Gadaj(new Polje(1, 4)));
            Assert.AreEqual(RezultatGadanja.Potonuce, b.Gadaj(new Polje(1, 3)));
            Assert.AreEqual(RezultatGadanja.Potonuce, b.Gadaj(new Polje(1, 4)));
        }
    }
}