using System;
using kaffe;
using KaffeNetCore.kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNet.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CortadoTest()
        {
            Cortado cortado = new Cortado();

            int pris = cortado.Pris();

            Assert.AreEqual(25,pris);
        }
        [TestMethod]
        public void CortadoTest2()
        {
            Cortado cortado = new Cortado();

            int ml = cortado.MlMælk();

            Assert.AreEqual(25,ml);
        }

        [TestMethod]
        public void FlatWhiteTest()
        {
            FlatWhite flatWhite = new FlatWhite();

            int ml = flatWhite.MlMælk();

            Assert.AreEqual(160, ml);
        }

        [TestMethod]
        public void FlatWhiteTest2()
        {
            FlatWhite flatWhite = new FlatWhite();

            int pris = flatWhite.Pris();

            Assert.AreEqual(45, pris);
        }

        [TestMethod]
        public void FlatWhiteTest3()
        {
            FlatWhite flatWhite = new FlatWhite();

            string styrke = flatWhite.Styrke();

            Assert.AreEqual("Mild", styrke);
        }

        [TestMethod]
        public void LatteTest()
        {
            Latte latte = new Latte();

            int ml = latte.MlMælk();

            Assert.AreEqual(120, ml);
        }

        [TestMethod]
        public void LatteTest2()
        {
            Latte latte = new Latte();

            int pris = latte.Pris();

            Assert.AreEqual(40, pris);
        }

        [TestMethod]
        public void SortKaffeTest()
        {
            SortKaffe sortKaffe = new SortKaffe();

            int pris = sortKaffe.Pris();

            Assert.AreEqual(20, pris);
        }

        [TestMethod]
        public void SortKaffeTest2()
        {
            SortKaffe sortKaffe = new SortKaffe(10);

            int pris = sortKaffe.Pris();

            Assert.AreEqual(10, pris);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortKaffeTest3()
        {
            SortKaffe sortKaffe = new SortKaffe(25);
            int pris = sortKaffe.Pris();

            Assert.Fail();
        }

        [TestMethod]
        public void SortKaffeTest4()
        {
            SortKaffe sortKaffe = new SortKaffe();

            string styrk = sortKaffe.Styrke();

            Assert.AreEqual("stærk", styrk);
        }


    }
}
