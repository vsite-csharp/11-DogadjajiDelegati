using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.DogađajiDelegati.Testovi
{
    [TestClass]
    public class TestUlančavanjaDelegata : ConsoleTest
    {
        [TestMethod]
        public void UlančavanjeNaKonzoluDajeIspisSamoDrugogITrećegTekstaTektsa()
        {
            UlančavanjeDelegata.IspisPoruka("Janko", "Marko", "Pero");
            Assert.AreEqual(2, cw.Count);
            Assert.AreEqual("Marko", cw.GetString());
            Assert.AreEqual("Pero", cw.GetString());
        }

        [TestMethod]
        public void UlančavanjeUStreamWriterDajeIspisPrvaDvaTeksta()
        {
            StringBuilder sb = new StringBuilder();
            UlančavanjeDelegata.writer = new StringWriter(sb);
            UlančavanjeDelegata.IspisPoruka("Janko", "Marko", "Pero");
            Assert.AreEqual(2, cw.Count);
            Assert.AreEqual("Marko", cw.GetString());
            Assert.AreEqual("Pero", cw.GetString());

            string[] učitaniReci = sb.ToString().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(2, učitaniReci.Length);
            Assert.AreEqual("Janko", učitaniReci[0]);
            Assert.AreEqual("Marko", učitaniReci[1]);
        }
    }
}
