using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.DogađajiDelegati
{
    //:064 Klasu AlarmEventArgs definirati da je izvedena iz klase EventArgs. AlarmEventArgs treba omogućiti da se podaci o alarmu prenesu slušatelju.
    //:065 U tu klasu dodati javna readonly polja Vrijeme (DateTime), Mjesto (string), Razina (int) i Opis (string) koja treba inicijalizirati u konstruktoru klase.

    public class AlarmEventArgs : EventArgs
    {
        public AlarmEventArgs(string mjesto, int razina, string opis)
        {
            Mjesto = mjesto;
            Razina = razina;
            Opis=opis;
            
        }
        public readonly DateTime Vrijeme = DateTime.Now;
        public readonly string Mjesto;
        public readonly int Razina;
        public readonly string Opis;
    }
}
