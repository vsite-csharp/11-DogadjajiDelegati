using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    class SlušateljAlarma
    {
        public void AlarmNotifikacija(object s, EventArgs e)
        {
            Console.WriteLine("***Dobivena je notifikacija o alarmu");
        }
    }

    // TODO:068 Pokrenuti testove u grupi DefiniranjeDogađaja (5 testova mora proći)
}
