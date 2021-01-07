using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    // U klasi GeneratorAlarma definirati događaj Alarm s delegatom tipa EventHandler te metodu protected virtual void OnAlarm(EventArgs e)
    //           koja treba okidati događaj Alarm

    // U klasu GeneratorAlarma dodati definiciju delegata AlarmEventHandler koji kao drugi argument prima objekt tipa AlarmEventArgs.
    // Modificirati klasu GeneratorAlarma tako da je događaj Alarm tipa AlarmEventHandler.
    class GeneratorAlarma
    {
        public delegate void AlarmEventHandler(object sender, AlarmEventArgs e);
        //public event EventHandler Alarm;
        public event AlarmEventHandler Alarm;

        protected virtual void OnAlarm(AlarmEventArgs e)
        {
            //if (Alarm != null)
            //{
            //    Alarm(this, e);
            //}
            Alarm?.Invoke(this, e);
        }

        // U metodu DižiAlarm dodati poziv metode OnAlarm.
        public void DižiAlarm(string mjesto, int razina, string opis)
        {
            Console.WriteLine($"!!!Generator diže alarm {DateTime.Now}: mjesto={mjesto}, razina={razina}, opis={opis}!!!");
            OnAlarm(new AlarmEventArgs(mjesto, razina, opis));
        }
    }
}
