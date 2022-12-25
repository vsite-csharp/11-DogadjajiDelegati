using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    // primjer programa s delegatima
    class ProsljeđivanjeDelegata
    {
        // definicija delegata
        delegate double Funkcija(double x);

        // metoda koja prihvaća delegata
        static void IspišiFunkciju(Funkcija fja, double x1, double x2, int n)
        {
            Console.WriteLine("Ispis funkcije {0}:", fja.Method);
            Console.WriteLine("{0,4} {1,20}", "x", "y");
            for (int i = 0; i < n; ++i)
            {
                double x = x1 + (x2 - x1) / (n - 1) * i;
                Console.WriteLine("{0,15:0.0000000000} {1,20:0.0000000000}", x, fja(x));
            }
        }

        public static void IspisFunkcijeSinus()
        {
            // :020 Pozvati metodu IspišiFunkciju tako da ispiše vrijednosti funkcije Math.Sin za 10 točaka u intervalu od 0 do Math.PI.
            Funkcija fun = Math.Sin;
            IspišiFunkciju(fun, 0, Math.PI, 10);
            // :021 Pokrenuti program i provjeriti ispis.
        }

        public static void IspisFunkcijeE()
        {
            // :022 Pozvati metodu IspišiFunkciju tako da ispiše vrijednosti funkcije Math.Exp za 5 točaka u intervalu od 0 do 10.
            Funkcija fun = Math.Exp;
            IspišiFunkciju(fun, 0, 10, 5);
            // :023 Pokrenuti program i provjeriti ispis
        }

        // TODO:024 Pokrenuti i provjeriti testove (2 testa u grupi "ProsljeđivanjaDelegata" moraju proći).

        static void Main(string[] args)
        {
            IspisFunkcijeSinus();

            Console.WriteLine();

            IspisFunkcijeE();

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
