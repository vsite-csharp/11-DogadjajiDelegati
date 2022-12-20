using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.DogađajiDelegati.Testovi
{
    [TestClass]
    public class GetInvocationList : ConsoleTest
    {
        [TestMethod]
        public void IspisTablicaFunkcijaZasebno()
        {
            DogađajiDelegati.GetInvocationList.Funkcija f = Math.Cos;
            f += Math.Sin;

            DogađajiDelegati.GetInvocationList.IspišiFunkcijeZasebno(f, 0, Math.PI / 2, 2);
            Assert.AreEqual("Ispis funkcije Double Cos(Double):", cw?.GetString());
            string[]? zaglavlje = cw?.GetString()?.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, zaglavlje?.Length);
            Assert.AreEqual("x", zaglavlje[0]);
            Assert.AreEqual("y", zaglavlje[1]);
            string[]? vrijednosti = cw?.GetString()?.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, vrijednosti?.Length);
            Assert.AreEqual(0.0, double.Parse(vrijednosti[0]), 1e-10);
            Assert.AreEqual(Math.Cos(0.0), double.Parse(vrijednosti[1]), 1e-10);
            vrijednosti = cw?.GetString()?.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, vrijednosti?.Length);
            Assert.AreEqual(Math.PI / 2, double.Parse(vrijednosti[0]), 1e-10);
            Assert.AreEqual(Math.Cos(Math.PI / 2), double.Parse(vrijednosti[1]), 1e-10);

            Assert.AreEqual("Ispis funkcije Double Sin(Double):", cw?.GetString());
            zaglavlje = cw?.GetString()?.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, zaglavlje?.Length);
            Assert.AreEqual("x", zaglavlje[0]);
            Assert.AreEqual("y", zaglavlje[1]);
            vrijednosti = cw?.GetString()?.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, vrijednosti?.Length);
            Assert.AreEqual(0.0, double.Parse(vrijednosti[0]), 1e-10);
            Assert.AreEqual(Math.Sin(0.0), double.Parse(vrijednosti[1]), 1e-10);
            vrijednosti = cw?.GetString()?.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, vrijednosti?.Length);
            Assert.AreEqual(Math.PI / 2, double.Parse(vrijednosti[0]), 1e-10);
            Assert.AreEqual(Math.Sin(Math.PI / 2), double.Parse(vrijednosti[1]), 1e-10);
        }
    }
}
