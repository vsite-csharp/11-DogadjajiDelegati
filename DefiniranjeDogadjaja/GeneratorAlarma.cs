using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    // :060 U klasi GeneratorAlarma definirati događaj Alarm s delegatom tipa EventHandler te metodu protected virtual void OnAlarm(EventArgs e) koja treba okidati događaj Alarm.

    // TODO:066 U klasu GeneratorAlarma dodati definiciju delegata AlarmEventHandler koji kao drugi argument prima objekt tipa AlarmEventArgs.
    // TODO:067 Modificirati klasu GeneratorAlarma tako da je događaj Alarm tipa AlarmEventHandler.
    class GeneratorAlarma
    {
        //public event EventHandler Alarm;
        //definirati virtualne metode - protected 

        public event AlarmEventHandler Alarm;

        public delegate void AlarmEventHandler(object sender, AlarmEventArgs a);

        protected virtual void OnAlarm(AlarmEventArgs e)
        {
            //if (Alarm != null)
            //    Alarm(this, e); ili
            Alarm?.Invoke(this, e);
        }

        // :061 U metodu DižiAlarm dodati poziv metode OnAlarm.
        public void DižiAlarm(string mjesto, int razina, string opis)
        {
            Console.WriteLine($"!!!Generator diže alarm {DateTime.Now}: mjesto={mjesto}, razina={razina}, opis={opis}!!!");
            //OnAlarm(EventArgs.Empty);
            OnAlarm(new AlarmEventArgs(mjesto, razina, opis));
        }
    }
}
