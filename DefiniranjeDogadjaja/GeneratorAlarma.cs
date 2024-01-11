﻿namespace Vsite.CSharp.DogađajiDelegati
{
    //  U klasi GeneratorAlarma definirati događaj Alarm s delegatom tipa EventHandler te metodu protected virtual void OnAlarm(EventArgs e) koja treba okidati događaj Alarm.
    
    // U klasu GeneratorAlarma dodati definiciju delegata AlarmEventHandler koji kao drugi argument prima objekt tipa AlarmEventArgs.
    // TODO:067 Modificirati klasu GeneratorAlarma tako da je događaj Alarm tipa AlarmEventHandler.
    internal class GeneratorAlarma
    {
        public delegate void AlarmEventHandler(object? obj, AlarmEventArgs a);
        public event AlarmEventHandler Alarm;
        // U metodu DižiAlarm dodati poziv metode OnAlarm.
        public void DižiAlarm(string mjesto, int razina, string opis)
        {
            Console.WriteLine($"!!!Generator diže alarm {DateTime.Now}: mjesto={mjesto}, razina={razina}, opis={opis}!!!");
            OnAlarm(new AlarmEventArgs(mjesto,razina,opis));

        }
        protected virtual void OnAlarm(AlarmEventArgs e) 
        {
            Alarm?.Invoke(this, e);
        }
    }
}
