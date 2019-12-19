using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.DogađajiDelegati
{
    class LambdaIzrazi
    {
        private static IEnumerable<T> PrimijeniOperaciju<T>(IEnumerable<T> niz, Func<T, T> funkcija)
        {
            List<T> rezultat = new List<T>(niz.Count());
            foreach (T član in niz)
                rezultat.Add(funkcija(član));
            return rezultat;
        }

        public static IEnumerable<double> KorijenujČlanoveNiza(IEnumerable<double> niz)
        {
            return PrimijeniOperaciju(niz, (double x) => Math.Sqrt(x));
        }

        public static IEnumerable<double> KvadrirajČlanoveNiza(IEnumerable<double> niz)
        {
            return PrimijeniOperaciju(niz, (double x) => x * x);
        }

        public static IEnumerable<string> Kapitaliziraj(IEnumerable<string> niz)
        {
            return PrimijeniOperaciju(niz, (string x) => x.ToUpper());
        }


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
