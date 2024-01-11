using System.Data;

namespace Vsite.CSharp.DogađajiDelegati
{
    // Klasu AlarmEventArgs definirati da je izvedena iz klase EventArgs. AlarmEventArgs treba omogućiti da se podaci o alarmu prenesu slušatelju.
    
    
    // TODO:065 U tu klasu dodati javna readonly polja Vrijeme (DateTime), Mjesto (string), Razina (int) i Opis (string) koja treba inicijalizirati u konstruktoru klase.

    internal class AlarmEventArgs
    {
        public AlarmEventArgs(string mjesto, int razina, string opis)
        {
            Vrijeme = DateTime.Now;
            Mjesto = mjesto;
            Razina = razina;
            Opis = opis;
        }
        public readonly DateTime Vrijeme;
        public readonly string Mjesto;
        public readonly int Razina;
        public readonly string Opis;
    }
}
