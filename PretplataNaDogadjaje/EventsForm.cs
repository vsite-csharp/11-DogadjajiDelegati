using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Vsite.CSharp.DogađajiDelegati
{
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
            buttonDelete.Enabled = false;

            //kad se dogodi taj dogadaj, zelimo tom dogadaju pridruziti metodu
            //a to radimo s +=
            //a automatski TABom ce VS generairati ime metode te njenu deklaraciju
            textBox.TextChanged += TextBoxOnTextChanged; 
            //dakle, svaki put kad se u texBoxu promijeni text, bit ce pozvana
            //ova metoda TextBoxOnTextChanged
        }

        private void TextBoxOnTextChanged(object sender, EventArgs e)
        {
            // je li duljina texta 0, ako ne, moze se deletati
            buttonDelete.Enabled = (textBox.TextLength != 0);
            //no, enablean je na samom pocetku kad nema jos inicjalnog upisa
            //=> to cmeo srediti prilikom inicjalizacije forme
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            //ili:
            Application.Exit();
        }
    }

    // 000 Pokrenuti program i pogledati koje kontrole se nalaze na glavnoj formi.

    // 001 Dodati metodu za obradu događaja (event handler) koja će biti pozvana kada se promijeni sadržaj textBox kontrole (na događaj TextChanged).

    // 002 Unutar metode treba onemogućiti tipku buttonDelete ako nema upisanog teksta u kontroli textBox, odnosno omogućiti ju kada je neki tekst upisan.
    // 003 Pokrenuti program i provjeriti ponašanje tipke.

    // 004 Dodati metodu za obradu događaja koja će biti pozvana pri pritisku na tipku buttonDelete (događaj Click) i koja će obrisati sadržaj kontrole textBox.

    // 005 Pokrenuti program i provjeriti funkcionalnost tipke.

    // 006 Dodati metodu za obradu događaja koja će biti pozvana pri
    // pritisku na tipku buttonClose i koja će zatvoriti formu.

    // 007 Pokrenuti program i provjeriti funkcionalnost tipke.

    // 008 Pokrenuti i provjeriti testove (4 testa u grupi "PretplataNaDogađaje" moraju proći).
}
