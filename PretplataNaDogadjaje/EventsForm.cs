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
            this.buttonDelete.Enabled = false; // Tekst u kontroli je inicijalno prazan, stoga je tipka Delete nedostupan.
            this.textBox.TextChanged += TextBoxTextChanged;
        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            this.buttonDelete.Enabled = this.textBox.TextLength != 0;
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            this.textBox.Clear();
        }

        private void ButtonCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Pokrenuti program i pogledati koje kontrole se nalaze na glavnoj formi.

    // Dodati metodu za obradu događaja (event handler) koja će biti pozvana kada se promijeni sadržaj textBox kontrole (na događaj TextChanged).

    // Unutar metode treba onemogućiti tipku buttonDelete ako nema upisanog teksta u kontroli textBox, odnosno omogućiti ju kada je neki tekst upisan.
    // Pokrenuti program i provjeriti ponašanje tipke.

    //  Dodati metodu za obradu događaja koja će biti pozvana pri pritisku na tipku buttonDelete (događaj Click) i koja će obrisati sadržaj kontrole textBox.

    // Pokrenuti program i provjeriti funkcionalnost tipke.

    // Dodati metodu za obradu događaja koja će biti pozvana pri pritisku na tipku buttonClose i koja će zatvoriti formu.

    // Pokrenuti program i provjeriti funkcionalnost tipke.

    // Pokrenuti i provjeriti testove (4 testa u grupi "PretplataNaDogađaje" moraju proći).
}
