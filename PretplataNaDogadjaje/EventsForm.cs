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
            textBox.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            buttonDelete.Enabled = textBox.TextLength > 0;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    // 000 Dodati metodu za obradu događaja (event handler) koja će biti pozvana kada se promijeni sadržaj textBox kontrole (na događaj TextChanged). Unutar metode treba onemogućiti tipku buttonDelete ako nema upisanog teksta u kontroli textBox, odnosno omogućiti ju kada je neki tekst upisan.

    // 001 Pokrenuti program i provjeriti ponašanje tipke.

    // 002 Dodati metodu za obradu događaja koja će biti pozvana pri pritisku na tipku buttonDelete (događaj Click) i koja će obrisati sadržaj kontrole textBox.

    // 003 Pokrenuti program i provjeriti funkcionalnost tipke.

    // 004 Dodati metodu za obradu događaja koja će biti pozvana pri pritisku na tipku buttonClose i koja će zatvoriti formu.

    // 005 Pokrenuti program i provjeriti funkcionalnost tipke.

    // 006 Pokrenuti i provjeriti testove (4 testa u grupi "PretplataNaDogađaje" moraju proći)
}
