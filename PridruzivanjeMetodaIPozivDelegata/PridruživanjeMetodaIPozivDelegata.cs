﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.DogađajiDelegati
{
    class PridruživanjeMetodaIPozivDelegata
    {
        // definicija delegata
        delegate void MojDelegat();

        private static void StatičkaMetoda()
        {
            Console.WriteLine("Pozvana je statička metoda");
        }

        private void MetodaInstance()
        {
            Console.WriteLine("Pozvana je metoda instance");
        }

        private void DrugaMetodaInstance()
        {
            Console.WriteLine("Pozvana je druga metoda instance");
        }

        public static void PozivStatičkeMetodePrekoDelegata()
        {
            MojDelegat md = StatičkaMetoda;
            md();
        }

        public static void PozivMetodeInstancePrekoDelegata()
        {
            PridruživanjeMetodaIPozivDelegata pm = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat md = pm.MetodaInstance;
            md();

        }

        public static void PozivStatičkeIDvijeMetodeInstancePrekoDelegata()
        {
            // TODO:014 Instancirati delegata tipa MojDelegat metodom MetodaInstance. 
            PridruživanjeMetodaIPozivDelegata pm = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat md = pm.MetodaInstance;

            // TODO:015 Delegatu dodati metodu Statička metoda i metodu DrugaMetodaInstance te pozvati delegata.
            md += StatičkaMetoda;
            md += pm.DrugaMetodaInstance;
            md();
            // TODO:016 Pokrenuti program i provjeriti ispis.

            // TODO:017 Pokrenuti i provjeriti testove (3 testa u grupi "TestDelegatskihMetoda" moraju proći).
        }

        static void Main(string[] args)
        {
            PozivStatičkeMetodePrekoDelegata();

            Console.WriteLine();

            PozivMetodeInstancePrekoDelegata();

            Console.WriteLine();

            PozivStatičkeIDvijeMetodeInstancePrekoDelegata();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
