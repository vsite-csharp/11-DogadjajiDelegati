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
            MessageBox.Show("U overrideanoj metodi");
            //base.OnClick(e);
        }
    }
}
