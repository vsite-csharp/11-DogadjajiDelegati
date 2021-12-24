using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.CSharp.DogađajiDelegati
{
    class MojBotun : Button
    {
        protected override void OnClick(EventArgs e)
        {
            //base.OnClick(e);
            MessageBox.Show("Kliknuo si me!", "Moj botun");
        }
    }
}
