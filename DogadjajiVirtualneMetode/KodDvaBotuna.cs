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
    public partial class KodDvaBotuna : Form
    {
        public KodDvaBotuna()
        {
            InitializeComponent();
            button.Click += Button_Click;
            buttonMy.Click += ButtonMy_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kliknuo si me!", "Botun obični");
        }

        private void ButtonMy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kliknuo si me!", "Moj botun");
        }

        class MyButton : Button
        {
            //protected override void OnClick(EventArgs e)
            //{
            //    MessageBox.Show("Poruka OnClick iz override");
            //}
        }
    }
}
