﻿namespace Vsite.CSharp.DogađajiDelegati
{
    class UlančavanjeDelegata
    {
        delegate void IspišiPoruku(string poruka);

        // dvije metode koje možemo pridružiti delegatu
        private static void IspišiNaKonzolu(string poruka)
        {
            Console.WriteLine(poruka);
        }

        private static void IspišiUFajl(string poruka)
        {
            writer.WriteLine(poruka);
            writer.Flush();
        }

        public static void IspisPoruka(params string[] poruke)
        {
            IspišiPoruku ispisPoruke = IspišiUFajl;

            ispisPoruke(poruke[0]);

            // TODO:030 Pokrenuti program i pogledati sadržaj datoteke "poruke.txt" (u potkazalu bin\Debug).

            // TODO:031 Dodajte delegatu metodu IspišiNaKonzolu.

            ispisPoruke(poruke[1]);

            // TODO:032 Pokrenite program i usporedite prikaz na konzoli sa sadržajem datoteke "poruke.txt".

            // TODO:033 Iz delegata uklonite IspišiUFajl, pokrenite program i provjerite sadržaj datoteke "poruke.txt".

            ispisPoruke(poruke[2]);
        }

        static UlančavanjeDelegata()
        {
            if (File.Exists("poruke.txt"))
            {
                File.Delete("poruke.txt");
            }
            writer = new StreamWriter(new FileStream("poruke.txt", FileMode.Append, FileAccess.Write));
        }

        public static TextWriter writer;

        // TODO:034 Pokrenite i provjerite testove (dva testa u grupi "UlančavanjaDelegata" moraju proći)
        static void Main()
        {
            IspisPoruka("Dobar dan", "Bok", "Guten Tag");

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
