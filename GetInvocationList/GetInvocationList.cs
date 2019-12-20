﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.DogađajiDelegati
{
    // primjer poziva delegata preko GetInvocationList

    class GetInvocationList
    {
        public delegate double Funkcija(double x);

        static void IspišiFunkcijeUPaketu(Funkcija fje, double x1, double x2, int n)
        {
            Console.WriteLine("Ispis funkcije {0}:", fje.Method);
            Console.WriteLine("{0,4} {1,20}", "x", "y");
            for (int i = 0; i < n; ++i)
            {
                double x = x1 + (x2 - x1) / (n - 1) * i;
                Console.WriteLine("{0,15:0.0000000000} {1,20:0.0000000000}", x, fje.DynamicInvoke(x));
            }
        }

        public static void IspišiFunkcijeZasebno(Funkcija fje, double x1, double x2, int n)
        {
            // Pomoću metode GetInvocationList dohvatiti sve delegatske funkcije zasebno i za svaku ispisati vrijednosti u traženom intervalu
            var listaFja = fje.GetInvocationList();
            foreach (var f in listaFja)
                IspišiFunkcijeUPaketu((Funkcija)f, x1, x2, n);
            // Pokrenuti program i provjeriti ispis.
        }
            // Pokrenuti i provjeriti testove (test u grupi "TestGetInvocationList" mora proći)

            static void Main(string[] args)
            {
                // Pokrenuti program i provjeriti ispis
                Funkcija f = Math.Cos;
                f += Math.Sin;

                Console.WriteLine("*** IspišiFunkcijeUPaketu ***");
                IspišiFunkcijeUPaketu(f, 0, Math.PI, 10);

                Console.WriteLine("*** IspišiFunkcijeZasebno ***");
                IspišiFunkcijeZasebno(f, 0, Math.PI, 10);

                Console.WriteLine("GOTOVO!!!");
                Console.ReadKey();
            }
    }
}
