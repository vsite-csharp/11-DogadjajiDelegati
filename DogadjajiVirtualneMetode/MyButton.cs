using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.CSharp.DogađajiDelegati
{
    class MyButton : Button
    {
        protected override void OnClick(EventArgs e)
        {
            //base.OnClick(e);
            MessageBox.Show("Nadglasana metoda OnClick!", "My Button");
        }

    }
}
