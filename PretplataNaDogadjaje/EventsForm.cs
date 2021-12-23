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
            buttonDelete.Enabled = textBox.Text.Length != 0;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 0)
            {
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonDelete.Enabled = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // TODO:000 Pokrenuti program i pogledati koje kontrole se nalaze na glavnoj formi.

    // 001 Dodati metodu za obradu događaja (event handler) koja će biti pozvana kada se promijeni sadržaj textBox kontrole (na događaj TextChanged).
    // 002 Unutar metode treba onemogućiti tipku buttonDelete ako nema upisanog teksta u kontroli textBox, odnosno omogućiti ju kada je neki tekst upisan.
    // 003 Pokrenuti program i provjeriti ponašanje tipke.

    // 004 Dodati metodu za obradu događaja koja će biti pozvana pri pritisku na tipku buttonDelete (događaj Click) i koja će obrisati sadržaj kontrole textBox.

    // TODO:005 Pokrenuti program i provjeriti funkcionalnost tipke.

    // 006 Dodati metodu za obradu događaja koja će biti pozvana pri pritisku na tipku buttonClose i koja će zatvoriti formu.

    // TODO:007 Pokrenuti program i provjeriti funkcionalnost tipke.

    // TODO:008 Pokrenuti i provjeriti testove (4 testa u grupi "PretplataNaDogađaje" moraju proći).
}
