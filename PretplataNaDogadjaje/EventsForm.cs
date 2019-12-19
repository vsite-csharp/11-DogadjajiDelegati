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
            buttonDelete.Enabled = false;
            textBox.TextChanged += TextBox_TextChanged;
            buttonDelete.Click += buttonDelete_Click;
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
}
