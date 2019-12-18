using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    // TODO:060 U klasi GeneratorAlarma definirati događaj Alarm s delegatom tipa EventHandler te metodu protected virtual void OnAlarm(EventArgs e)
    //           koja treba okidati događaj Alarm

    // TODO:065 U klasu GeneratorAlarma dodati definiciju delegata AlarmEventHandler koji kao drugi argument prima objekt tipa AlarmEventArgs.
    // TODO:066 Modificirati klasu GeneratorAlarma tako da je događaj Alarm tipa AlarmEventHandler.
    class GeneratorAlarma
    {
        // TODO:061 U metodu DižiAlarm dodati poziv metode OnAlarm.
        public void DižiAlarm(string mjesto, int razina, string opis)
        {
            Console.WriteLine($"!!!Generator diže alarm {DateTime.Now}: mjesto={mjesto}, razina={razina}, opis={opis}!!!");
        }
    }
}
