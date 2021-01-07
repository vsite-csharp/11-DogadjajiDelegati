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

        public override bool Equals(object obj)
        {
            var args = obj as AlarmEventArgs;
            return args != null &&
                   Vrijeme == args.Vrijeme &&
                   Mjesto == args.Mjesto &&
                   Razina == args.Razina &&
                   Opis == args.Opis;
        }

        public override int GetHashCode()
        {
            var hashCode = -608843544;
            hashCode = hashCode * -1521134295 + Vrijeme.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Mjesto);
            hashCode = hashCode * -1521134295 + Razina.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Opis);
            return hashCode;
        }
    }
}
