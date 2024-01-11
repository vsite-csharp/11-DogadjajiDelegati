namespace Vsite.CSharp.DogađajiDelegati
{
    // 064 Klasu AlarmEventArgs definirati da je izvedena iz klase EventArgs. AlarmEventArgs treba omogućiti da se podaci o alarmu prenesu slušatelju.
    // 065 U tu klasu dodati javna readonly polja Vrijeme (DateTime), Mjesto (string), Razina (int) i Opis (string) koja treba inicijalizirati u konstruktoru klase.

    internal class AlarmEventArgs : EventArgs
    {
        public AlarmEventArgs(string place, int lvl, string desc) {
            time = DateTime.Now;
            this.place = place;
            this.lvl = lvl;
            this.desc = desc;
        }
        public readonly DateTime time;
        public readonly string place;
        public readonly int lvl;
        public readonly string desc;
    }
}
