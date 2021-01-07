using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.DogađajiDelegati
{

    public class AlarmEventArgs : EventArgs
    {
        public readonly DateTime Vrijeme;
        public readonly string Mjesto;
        public readonly int Razina;
        public readonly string Opis;

        public AlarmEventArgs(string mjesto, int razina, string opis)
        {
            Vrijeme = DateTime.Now;
            Mjesto = mjesto;
            Razina = razina;
            Opis = opis;
        }
    }
}
