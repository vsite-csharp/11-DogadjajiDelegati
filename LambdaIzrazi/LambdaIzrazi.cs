using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.DogađajiDelegati
{
    class LambdaIzrazi
    {
        //(x, y) => x* y;
        private static IEnumerable<T> PrimijeniOperaciju<T>(IEnumerable<T> niz, Func<T, T> funkcija)
        {
            List<T> rezultat = new List<T>(niz.Count());
            foreach (T član in niz)
                rezultat.Add(funkcija(član));
            return rezultat;
        }

        // 050 U donjoj metodi pozvati metodu PrimijeniOperaciju tako da vrati niz korijenovanih članova zadanog niza.
        public static IEnumerable<double> KorijenujČlanoveNiza(IEnumerable<double> niz)
        {
            //return PrimijeniOperaciju(niz, Math.Sqrt);
            return niz.Select(Math.Sqrt);
            //return niz;
        }

        // 051 U donjoj metodi pozvati metodu PrimijeniOperaciju tako da vrati niz kvadrata članova zadanog niza.
        public static IEnumerable<double> KvadrirajČlanoveNiza(IEnumerable<double> niz)
        {
            //return PrimijeniOperaciju(niz, x => x * x);
            return niz.Select(x => x * x);
            //return niz;
        }

        // 052 U donjoj metodi pozvati metodu PrimijeniOperaciju tako da vrati niz riječi iz zadanog niza sa svim velikim slovima.
        public static IEnumerable<string> Kapitaliziraj(IEnumerable<string> niz)
        {
            //return PrimijeniOperaciju(niz, x => x.ToUpper());
            return niz.Select(x => x.ToUpper());
            //return niz;
        }

        // 053 Pozive metode PrimijeniOperaciju u gornjim metodama zamijenite pozivima metode proširenja IEnumerable<T>.Select.

        // 054 Pokrenuti i provjeriti testove (3 testa u grupi "LambdaIzrazi" moraju proći).

        static void Main(string[] args)
        {
            double[] niz = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Korijeni niza:");
            foreach (var rez in KorijenujČlanoveNiza(niz))
                Console.WriteLine(rez);

            Console.WriteLine("Kvadrati niza:");
            foreach (var rez in KvadrirajČlanoveNiza(niz))
                Console.WriteLine(rez);

            Console.WriteLine("Velikim slovima:");
            foreach (var rez in Kapitaliziraj(new string[] { "zagreb", "sad", "aids" }))
                Console.WriteLine(rez);

            Console.WriteLine();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
