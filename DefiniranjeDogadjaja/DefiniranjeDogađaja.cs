using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    internal static class DefiniranjeDogađaja
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8; // osigurava ispis naših znakova čžš

            GeneratorAlarma ga = new GeneratorAlarma();

            Console.WriteLine("Kada stisnemo tipku dići će se alarm, ali prijavljenog slušatelja nema...");
            Console.ReadKey(true);

            ga.DižiAlarm("zahod", 0, "propuh");

            Console.WriteLine();
            Console.WriteLine("Slušatelj će se prijaviti tek nakon što stisnemo tipku");
            Console.ReadKey(true);

            SlušateljAlarma sa = new SlušateljAlarma();
            // TODO:063a Otkomentirati donju naredbu tako da se slušatelj može predbilježiti na događaj Alarm. Pokrenuti program i pogledati ispis.
            //ga.Alarm += sa.AlarmNotifikacija;

            Console.WriteLine("Slušatelj se prijavio na slušanje alarma");
            Console.WriteLine("Kada stisnemo tipku dići će se alarm i obavijestiti pretplaćene slušatelje");
            Console.ReadKey(true);

            ga.DižiAlarm("učiona", 3, "počinitelj krade žarulje");

            Console.WriteLine("Slušatelj će se odjaviti nakon što stisnemo tipku");
            Console.ReadKey(true);

            // TODO:063b Otkomentirati donju naredbu tako da se slušatelj može odjaviti od događaja Alarm. Pokrenuti program i pogledati ispis.
            //ga.Alarm -= sa.AlarmNotifikacija;

            Console.WriteLine("Slušatelj se odjavio");
            Console.WriteLine("Kada stisnemo tipku dići će se alarm, ali prijavljenog slušatelja nema...");
            Console.ReadKey(true);

            ga.DižiAlarm("hodnik", 1, "mačka");

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
