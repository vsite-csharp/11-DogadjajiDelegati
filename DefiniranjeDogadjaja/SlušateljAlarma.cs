namespace Vsite.CSharp.DogađajiDelegati
{
    // TODO:062 U klasu SlušateljAlarma dodati metodu AlarmNotifikacija koja će se moći predbilježiti na događaj Alarm u klasi GeneratorAlarma. 
    // Unutar te metode na konzolu ispisati poruku da je dobivena poruka o alarmu
    internal class SlušateljAlarma
    {
        public void AlarmNotifikacija(object? sender, AlarmEventArgs e) {
            Console.WriteLine($"Vrijeme:{e.time}, Mjesto: {e.place}, Razina: {e.lvl}, Opis: {e.desc}");
        }
        // 068 Modificirati metodu AlarmNotifikacija tako da ispiše sve podatke o alarmu (vrijeme, mjesto, razinu i opis). Pokrenuti program i provjeriti ispis.
    }

    // 069 Pokrenuti testove u grupi DefiniranjeDogađaja (5 testova mora proći).
}
