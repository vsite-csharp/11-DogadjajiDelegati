using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.DogađajiDelegati
{
    //  Klasu AlarmEventArgs definirati da je izvedena iz klase EventArgs. AlarmEventArgs treba omogućiti da se podaci o alarmu prenesu slušatelju.
    //          U tu klasu dodati javna readonly polja Vrijeme (DateTime), Mjesto (string), Razina (int) i Opis (string) koja treba inicijalizirati u konstruktoru klase.

    public class AlarmEventArgs : EventArgs
    {
        public readonly DateTime vrijeme;
        public readonly string mjesto;
        public readonly int razina;
        public readonly string opis;

        
        public AlarmEventArgs(string mjesto, int razina, string opis)
        {
            this.vrijeme = DateTime.Now;
            this.mjesto = mjesto;
            this.razina = razina;
            this.opis = opis;
        }
    }
}
