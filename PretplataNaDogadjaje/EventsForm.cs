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
            buttonDelete.Enabled = textBox.Text.Length > 0;
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

    // TODO:006 Pokrenuti i provjeriti testove (4 testa u grupi "TestPretplateNaDogađaje" moraju proći)

}
