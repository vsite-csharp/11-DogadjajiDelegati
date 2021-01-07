using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    class SlušateljAlarma
    {
        public void AlarmNotifikacija(object sender, AlarmEventArgs e)
        {
            Console.WriteLine("***Dobivena je notifikacija o alarmu***");
            Console.WriteLine($"***{e.Vrijeme}: mjesto={e.Mjesto}, razina={e.Razina}, opis={e.Opis}");
        }
    }

}
