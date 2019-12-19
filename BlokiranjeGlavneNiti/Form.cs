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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            textBoxTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void ButtonBlock_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(10000);
        }








    }
}
