﻿namespace Vsite.CSharp.DogađajiDelegati
{
    // primjer programa s delegatima
    internal class ProsljeđivanjeDelegata
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
            // TODO:020 Pozvati metodu IspišiFunkciju tako da ispiše vrijednosti funkcije Math.Sin za 10 točaka u intervalu od 0 do Math.PI.

            // TODO:021 Pokrenuti program i provjeriti ispis.
        }

        public static void IspisFunkcijeE()
        {
            // TODO:022 Pozvati metodu IspišiFunkciju tako da ispiše vrijednosti funkcije Math.Exp za 5 točaka u intervalu od 0 do 10.

            // TODO:023 Pokrenuti program i provjeriti ispis
        }

        // TODO:024 Pokrenuti i provjeriti testove (2 testa u grupi "ProsljeđivanjaDelegata" moraju proći).

        static void Main()
        {
            IspisFunkcijeSinus();

            Console.WriteLine();

            IspisFunkcijeE();

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
