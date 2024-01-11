namespace Vsite.CSharp.DogađajiDelegati
{
    // U klasu SlušateljAlarma dodati metodu AlarmNotifikacija koja će se moći predbilježiti na događaj Alarm u klasi GeneratorAlarma. 
    // Unutar te metode na konzolu ispisati poruku da je dobivena poruka o alarmu
    internal class SlušateljAlarma
    {
        public void AlarmNotifikacija(object? sender, AlarmEventArgs e)
        {
            Console.WriteLine($"Vrijeme: {e.Vrijeme}, Mjesto: {e.Mjesto}, Razina: {e.Razina}, Opis: {e.Opis}");
        }
        // Modificirati metodu AlarmNotifikacija tako da ispiše sve podatke o alarmu (vrijeme, mjesto, razinu i opis). Pokrenuti program i provjeriti ispis.
    }

    // Pokrenuti testove u grupi DefiniranjeDogađaja (5 testova mora proći).
}
