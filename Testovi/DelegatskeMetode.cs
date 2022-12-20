using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.DogađajiDelegati.Testovi
{
    [TestClass]
    public class DelegatskeMetode : ConsoleTest
    {
        [TestMethod]
        public void PozivDelegataZaStatičkuMetodu()
        {
            PridruživanjeMetodaIPozivDelegata.PozivStatičkeMetodePrekoDelegata();
            Assert.AreEqual(1, cw?.Count);
            Assert.AreEqual("Pozvana je statička metoda", cw?.GetString());
        }

        [TestMethod]
        public void PozivDelegataZaNestatičkuMetodu()
        {
            PridruživanjeMetodaIPozivDelegata.PozivMetodeInstancePrekoDelegata();
            Assert.AreEqual(1, cw?.Count);
            Assert.AreEqual("Pozvana je metoda instance", cw?.GetString());
        }

        [TestMethod]
        public void PozivStatičkeIDvijeMetodeInstancePrekoDelegataDajeTriIspisa()
        {
            PridruživanjeMetodaIPozivDelegata.PozivStatičkeIDvijeMetodeInstancePrekoDelegata();
            Assert.AreEqual(3, cw?.Count);
            Assert.IsTrue(cw?.Items.Contains("Pozvana je metoda instance"));
            Assert.IsTrue(cw?.Items.Contains("Pozvana je statička metoda"));
            Assert.IsTrue(cw?.Items.Contains("Pozvana je druga metoda instance"));
        }
    }
}
