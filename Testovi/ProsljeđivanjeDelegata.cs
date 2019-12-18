using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.DogađajiDelegati.Testovi
{
    [TestClass]
    public class ProsljeđivanjeDelegata : ConsoleTest
    {
        [TestMethod]
        public void IspisFunkcijeSinus()
        {
            DogađajiDelegati.ProsljeđivanjeDelegata.IspisFunkcijeSinus();
            Assert.AreEqual(12, cw.Count);
            Assert.AreEqual("Ispis funkcije Double Sin(Double):", cw.GetString());
            string[] zaglavlje = cw.GetString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, zaglavlje.Length);
            Assert.AreEqual("x", zaglavlje[0]);
            Assert.AreEqual("y", zaglavlje[1]);
            string[] vrijednosti = cw.GetString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, vrijednosti.Length);
            Assert.AreEqual(0.0, double.Parse(vrijednosti[0]));
            Assert.AreEqual(0.0, double.Parse(vrijednosti[1]));
            vrijednosti = cw.GetString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, vrijednosti.Length);
            Assert.AreEqual(Math.PI / 9, double.Parse(vrijednosti[0]), 1e-4);
            Assert.AreEqual(Math.Sin(Math.PI / 9), double.Parse(vrijednosti[1]), 1e-4);
        }

        [TestMethod]
        public void IspisFunkcijeE()
        {
            DogađajiDelegati.ProsljeđivanjeDelegata.IspisFunkcijeE();
            Assert.AreEqual(7, cw.Count);
            Assert.AreEqual("Ispis funkcije Double Exp(Double):", cw.GetString());
            string[] zaglavlje = cw.GetString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, zaglavlje.Length);
            Assert.AreEqual("x", zaglavlje[0]);
            Assert.AreEqual("y", zaglavlje[1]);
            string[] vrijednosti = cw.GetString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, vrijednosti.Length);
            Assert.AreEqual(0.0, double.Parse(vrijednosti[0]));
            Assert.AreEqual(1.0, double.Parse(vrijednosti[1]));
            vrijednosti = cw.GetString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, vrijednosti.Length);
            Assert.AreEqual(2.5, double.Parse(vrijednosti[0]), 1e-4);
            Assert.AreEqual(Math.Exp(2.5), double.Parse(vrijednosti[1]), 1e-4);
        }
    }
}
