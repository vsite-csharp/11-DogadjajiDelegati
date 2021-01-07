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
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.TextLength != 0)
            {
                buttonDelete.Enabled = true;                
            }
            else
            {
                buttonDelete.Enabled = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    //  Dodati metodu za obradu događaja (event handler) koja će biti pozvana kada se promijeni sadržaj textBox kontrole (na događaj TextChanged). Unutar metode treba onemogućiti tipku buttonDelete ako nema upisanog teksta u kontroli textBox, odnosno omogućiti ju kada je neki tekst upisan.

    //  Pokrenuti program i provjeriti ponašanje tipke.

    //  Dodati metodu za obradu događaja koja će biti pozvana pri pritisku na tipku buttonDelete (događaj Click) i koja će obrisati sadržaj kontrole textBox.

    //  Pokrenuti program i provjeriti funkcionalnost tipke.

    //  Dodati metodu za obradu događaja koja će biti pozvana pri pritisku na tipku buttonClose i koja će zatvoriti formu.

    //  Pokrenuti program i provjeriti funkcionalnost tipke.

    //  Pokrenuti i provjeriti testove (4 testa u grupi "PretplataNaDogađaje" moraju proći)
}
