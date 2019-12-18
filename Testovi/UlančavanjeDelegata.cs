using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.DogađajiDelegati.Testovi
{
    [TestClass]
    public class UlančavanjeDelegata : ConsoleTest
    {
        [TestMethod]
        public void UlančavanjeNaKonzoluDajeIspisSamoDrugogITrećegTekstaTektsa()
        {
            DogađajiDelegati.UlančavanjeDelegata.IspisPoruka("Janko", "Marko", "Pero");
            Assert.AreEqual(2, cw.Count);
            Assert.AreEqual("Marko", cw.GetString());
            Assert.AreEqual("Pero", cw.GetString());
        }

        [TestMethod]
        public void UlančavanjeUStreamWriterDajeIspisPrvaDvaTeksta()
        {
            StringBuilder sb = new StringBuilder();
            DogađajiDelegati.UlančavanjeDelegata.writer = new StringWriter(sb);
            DogađajiDelegati.UlančavanjeDelegata.IspisPoruka("Janko", "Marko", "Pero");
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
