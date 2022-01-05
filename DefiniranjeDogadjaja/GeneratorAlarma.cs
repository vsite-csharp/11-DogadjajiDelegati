using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    // 060 U klasi GeneratorAlarma definirati događaj Alarm s delegatom tipa EventHandler te metodu protected virtual void OnAlarm(EventArgs e) koja treba okidati događaj Alarm.

    // 066 U klasu GeneratorAlarma dodati definiciju delegata AlarmEventHandler koji kao drugi argument prima objekt tipa AlarmEventArgs.
    // 067 Modificirati klasu GeneratorAlarma tako da je događaj Alarm tipa AlarmEventHandler.
    class GeneratorAlarma
    {
        // ovaj GeneratorAlarma ce definirati javno dostupan dogadaj koji se zove Alarm
        // ono sto ce tracati ovaj dogadaj/odnosno metode koje ce se pretplacivati na njega su tipa EventHandler:
        //public event EventHandler Alarm;

        //definira se virtualna metoda koja ce pozvati event Alarm:
        //protected virtual void OnAlarm(EventArgs e)
        //{
        //    if (Alarm != null)
        //    {
        //        Alarm(this, e); //this - objekt koji je digao alarm
        //    }
        //    //ili jednostavnije:
        //    Alarm?.Invoke(this, e);
        //}
        
        public delegate void AlarmEventHandler(object sender, AlarmEventArgs a);

        public event AlarmEventHandler Alarm;

        protected virtual void OnAlarm(AlarmEventArgs e)
        {
            Alarm?.Invoke(this, e);
        }

        // 061 U metodu DižiAlarm dodati poziv metode OnAlarm.
        public void DižiAlarm(string mjesto, int razina, string opis)
        {
            Console.WriteLine($"!!!Generator diže alarm {DateTime.Now}: mjesto={mjesto}, razina={razina}, opis={opis}!!!");
            //OnAlarm(EventArgs.Empty);
            OnAlarm(new AlarmEventArgs(mjesto, razina, opis));
        }
    }
}
