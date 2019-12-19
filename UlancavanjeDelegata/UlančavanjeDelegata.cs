﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Vsite.CSharp.DogađajiDelegati
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

            ispisPoruke += IspišiNaKonzolu;


            ispisPoruke(poruke[1]);

            ispisPoruke -= IspišiUFajl;


            ispisPoruke(poruke[2]);
        }

        static UlančavanjeDelegata()
        {
            if (File.Exists("poruke.txt"))
                File.Delete("poruke.txt");
            writer = new StreamWriter(new FileStream("poruke.txt", FileMode.Append, FileAccess.Write));
        }

        public static TextWriter writer;

        

        static void Main(string[] args)
        {
            IspisPoruka("Dobar dan", "Bok", "Guten Tag");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
