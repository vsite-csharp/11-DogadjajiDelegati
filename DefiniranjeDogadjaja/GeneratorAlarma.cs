using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    class GeneratorAlarma
    {
        public delegate void AlarmEventHandler(object sender, AlarmEventArgs e);
        //public event EventHandler Alarm;
        public event AlarmEventHandler Alarm;
        protected virtual void OnAlarm(AlarmEventArgs e)
        {
            Alarm?.Invoke(this, e);
        }
        public void DižiAlarm(string mjesto, int razina, string opis)
        {
            Console.WriteLine($"!!!Generator diže alarm {DateTime.Now}: mjesto={mjesto}, razina={razina}, opis={opis}!!!");
            OnAlarm(new AlarmEventArgs(mjesto, razina, opis));
        }
    }
}
