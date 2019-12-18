using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    class GeneratorAlarma
    {
        // 1. Tip koji sadrži podatke koji se prosljeđuju primateljima:
        public class AlarmEventArgs : EventArgs
        {
            // samo konstruktor
            public AlarmEventArgs(DateTime vrijeme, string mjesto, int razina, string opis)
            {
                Vrijeme = vrijeme;
                Mjesto = mjesto;
                Razina = razina;
                Opis = opis;
            }

            // članovi koji sadrže podatke o alarmu
            public readonly DateTime Vrijeme;
            public readonly string Mjesto;
            public readonly int Razina;
            public readonly string Opis;
        }

        // 2. Delegat koji definira prototip (callback) metode
        //    koju primatelji moraju implementirati.
        //    On je (uvijek) tipa void jer ne smije vraćati nikakav rezultat
        //    budući da više slušatelja može biti pretplaćeno (ulančano) na slušanje.
        public delegate void AlarmEventHandler(object pošiljatelj, AlarmEventArgs args);

        // 3. Sam događaj (event):
        public event AlarmEventHandler Alarm;

        // 4. Kod za odašiljanje događaja:
        protected virtual void OnAlarm(AlarmEventArgs e)
        {
            // ako ima registriranih interesenata za poruku, pošalji
            if (Alarm != null)
                Alarm(this, e);
        }

        // metoda koja aktivira alarm (tj. inicijalizira događaj tipa Alarm)
        public void DižiAlarm(string mjesto, int razina, string opis)
        {
            Console.WriteLine("Generator diže alarm!!! {0}: mjesto={1}, opis={3}", DateTime.Now, mjesto, razina, opis);

            AlarmEventArgs e = new AlarmEventArgs(DateTime.Now, mjesto, razina, opis);
            OnAlarm(e);
        }
    }
}
