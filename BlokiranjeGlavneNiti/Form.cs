using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.CSharp.DogađajiDelegati
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        // TODO:070 Na glavnu formu dodati timer (npr. povlačenjem s alatne trake/toolboxa, pod Components) i postaviti ga u aktivno stanje


        // TODO:071 U glavnu formu dodati metodu koja će biti okinuta togađajem Tick objekta timer. Unutar metode treba ažurirati sadržaj kontrole textBoxTime tako da prikazuje vrijeme u sekundama, pozivom metode DateTime.Now.ToLongTimeString();


        // TODO:072 U glavnu formu dodati metodu koja će biti okinuta događajem Click tipke buttonBlock. Metoda treba zaustaviti izvođenje glavne niti na 10 sekundi pozivom metode Thread.Sleep(10000)


        // TODO:073 Pokrenuti program i provjeriti odziv forme nakon pritiska tipke Block

    }
}
