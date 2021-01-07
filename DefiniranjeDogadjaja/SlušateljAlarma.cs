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
        // TODO:067 Modificirati metodu AlarmNotifikacija tako da ispiše sve podatke o alarmu (vrijeme, mjesto, razinu i opis). Pokrenuti program i provjeriti ispis.
    }

    // TODO:068 Pokrenuti testove u grupi DefiniranjeDogađaja (5 testova mora proći)
}
