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


        // U glavnu formu dodati metodu koja će biti okinuta togađajem Tick objekta timer. Unutar metode treba ažurirati sadržaj kontrole textBoxTime tako da prikazuje vrijeme u sekundama, pozivom metode DateTime.Now.ToLongTimeString();

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxTime.Text = DateTime.Now.ToLongTimeString();
        }

        // U glavnu formu dodati metodu koja će biti okinuta događajem Click tipke buttonBlock. Metoda treba zaustaviti izvođenje glavne niti na 10 sekundi pozivom metode Thread.Sleep(10000)

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(10000);
        }
       
        //  Pokrenuti program i provjeriti odziv forme nakon pritiska tipke Block

    }
}
