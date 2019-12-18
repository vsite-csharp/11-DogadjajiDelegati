using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.DogađajiDelegati.Testovi
{
    [TestClass]
    public class TestPretplateNaDogađaje
    {
        EventsForm forma = new EventsForm();

        [TestInitializeAttribute]
        public void Setup()
        {
            forma.ShowInTaskbar = false;
            forma.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        [TestMethod]
        public void KadaSeUTekstKontroluUpišeTekstTipkaDeleteJeOmogućena()
        {
            forma.textBox.Text = "Neki tekst";
            Assert.IsTrue(forma.buttonDelete.Enabled);
            forma.textBox.Text = "";
            Assert.IsFalse(forma.buttonDelete.Enabled);
        }

        [TestMethod]
        public void KadaUTekstKontroliNemaTekstaTipkaDeleteJeOnemogućena()
        {
            forma.textBox.Text = "";
            Assert.IsFalse(forma.buttonDelete.Enabled);
            forma.textBox.Text = "Neki tekst";
            Assert.IsTrue(forma.buttonDelete.Enabled);
        }

        [TestMethod]
        public void PritisakNaTipkuDeleteBrišeSadržajTextBoxa()
        {
            forma.textBox.Text = "Neki tekst";
            forma.Show();
            forma.buttonDelete.PerformClick();
            Assert.IsTrue(forma.textBox.TextLength == 0);
            forma.Close();
        }

        [TestMethod]
        public void PritisakNaTipkuCloseZatvaraFormu()
        {
            forma.Show();
            Assert.IsTrue(forma.Visible);
            forma.buttonClose.PerformClick();
            Assert.IsFalse(forma.Visible);
            forma.Close();
        }
    }
}
