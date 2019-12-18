using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    class SlušateljAlarma
    {
        // ovo je callback metoda koju će pozvati odašiljatelj
        public void AlarmNotifikacija(object pošiljatelj, GeneratorAlarma.AlarmEventArgs e)
        {
            Console.WriteLine(
              "Slušatelj je dobio alarm! Iz dobivenog objekta čita:\nKada: {0}\nGdje: {1}\nOzbiljnost: {2}, Opis: {3}\n",
              e.Vrijeme, e.Mjesto, e.Razina, e.Opis
            );
        }
    }
}
