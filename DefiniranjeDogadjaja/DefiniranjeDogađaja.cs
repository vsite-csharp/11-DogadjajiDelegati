using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    class DefiniranjeDogađaja
    {
        static void Main(string[] args)
        {
            // Pogledati definicije klasa GeneratorAlarma, GeneratorAlarma.AlarmEventArgs i SlušateljAlarma te njihovo korištenje u kodu dolje.

            //  Pokrenuti program i provjeriti ispise.

            // kreiramo objekt koji će generirati alarme
            GeneratorAlarma ga = new GeneratorAlarma();


            Console.WriteLine("Kada stisnemo tipku dići će se alarm, ali prijavljenog slušatelja nema...");
            Console.ReadKey(true);


            // test: generiramo događaj
            ga.DižiAlarm("zahod", 0, "propuh");


            Console.WriteLine();
            Console.WriteLine("Slušatelj će se prijaviti nakon što stisnemo tipku");
            Console.ReadKey(true);


            // kreiramo objekt koji će se pretplatiti na događaje
            SlušateljAlarma sa = new SlušateljAlarma();
            // dodajemo ga kao slušatelja događaja
            ga.Alarm += sa.AlarmNotifikacija;


            Console.WriteLine("Slušatelj se prijavio na slušanje alarma");
            Console.WriteLine("Kada stisnemo tipku dići će se alarm i obavijestiti pretplaćene slušatelje");
            Console.ReadKey(true);

            // test: generiramo događaj
            ga.DižiAlarm("učiona", 3, "počinitelj krade žarulje");

            Console.WriteLine("Slušatelj će se odjaviti nakon što stisnemo tipku");
            Console.ReadKey(true);

            // odjavimo se od primanja događaja
            ga.Alarm -= sa.AlarmNotifikacija;

            Console.WriteLine("Slušatelj se odjavio");
            Console.WriteLine("Kada stisnemo tipku dići će se alarm, ali prijavljenog slušatelja nema...");
            Console.ReadKey(true);

            ga.DižiAlarm("hodnik", 1, "mačka");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
