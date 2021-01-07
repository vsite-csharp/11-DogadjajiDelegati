using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    // U klasu SlušateljAlarma dodati metodu AlarmNotifikacija koja će se moći predbilježiti na događaj Alarm u klasi GeneratorAlarma. 
    // Unutar te metode na konzolu ispisati poruku da je dobivena poruka o alarmu
    class SlušateljAlarma
    {
        public void AlarmNotifikacija(object sender, AlarmEventArgs e)
        {
            Console.WriteLine("***Dobivena je notifikacija o alarmu:***");
            Console.WriteLine($"***{e.Vrijeme}: mjesto = {e.Mjesto}, razina={e.Razina}, opis={e.Opis}");
        }
        // Modificirati metodu AlarmNotifikacija tako da ispiše sve podatke o alarmu (vrijeme, mjesto, razinu i opis). Pokrenuti program i provjeriti ispis.
    }

    // Pokrenuti testove u grupi DefiniranjeDogađaja (5 testova mora proći)
}