using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.CSharp.DogađajiDelegati.Testovi
{
    [TestClass]
    public class TestLambdaIzraza
    {
        [TestMethod]
        public void MetodaKorijenujČlanoveVraćaNizKorijenovanihBrojeva()
        {
            double[] niz = new double[] { 0, 1, 2, 3, 4 };
            var rezultat = LambdaIzrazi.KorijenujČlanoveNiza(niz).ToArray();
            Assert.AreEqual(0.0, rezultat[0], 1e-5);
            Assert.AreEqual(1.0, rezultat[1], 1e-5);
            Assert.AreEqual(Math.Sqrt(niz[2]), rezultat[2], 1e-5);
            Assert.AreEqual(Math.Sqrt(niz[3]), rezultat[3], 1e-5);
            Assert.AreEqual(2.0, rezultat[4], 1e-5);
        }

        [TestMethod]
        public void MetodaKvadrirajČlanoveVraćaNizKvadriranihBrojeva()
        {
            double[] niz = new double[] { 0, 1, 2, 3, 4 };
            var rezultat = LambdaIzrazi.KvadrirajČlanoveNiza(niz).ToArray();
            Assert.AreEqual(0.0, rezultat[0], 1e-5);
            Assert.AreEqual(1.0, rezultat[1], 1e-5);
            Assert.AreEqual(4.0, rezultat[2], 1e-5);
            Assert.AreEqual(9.0, rezultat[3], 1e-5);
            Assert.AreEqual(16.0, rezultat[4], 1e-5);
        }

        [TestMethod]
        public void MetodaKapitalizirajVraćaSVelikimSlovima()
        {
            string[] niz = new string[] { "ana", "sad", "nikad" };
            var rezultat = LambdaIzrazi.Kapitaliziraj(niz).ToArray();
            Assert.AreEqual("ANA", rezultat[0]);
            Assert.AreEqual("SAD", rezultat[1]);
            Assert.AreEqual("NIKAD", rezultat[2]);
        }
    }
}
