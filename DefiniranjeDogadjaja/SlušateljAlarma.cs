using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    // TODO:062 U klasu SlušateljAlarma dodati metodu AlarmNotifikacija koja će se moći predbilježiti na događaj Alarm u klasi GeneratorAlarma. 
    // Unutar te metode na konzolu ispisati poruku da je dobivena poruka o alarmu
    class SlušateljAlarma
    {

        // TODO:068 Modificirati metodu AlarmNotifikacija tako da ispiše sve podatke o alarmu (vrijeme, mjesto, razinu i opis). Pokrenuti program i provjeriti ispis.
        public void AlarmNotifikacija(object sender, AlarmEventArgs e)
        {
            Console.WriteLine("AlarmNotifikacija");
            Console.WriteLine($"{e.Vrijeme}: Mjesto: {e.Mjesto}, {e.Razina}, {e.Opis}");
        }
    }

    // TODO:069 Pokrenuti testove u grupi DefiniranjeDogađaja (5 testova mora proći).
}
