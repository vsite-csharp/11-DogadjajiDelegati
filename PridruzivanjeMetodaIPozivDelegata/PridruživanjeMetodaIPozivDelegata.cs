using System;
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

        private static void DrugaStatičkaMetoda(int n)
        {
            Console.WriteLine($"Pozvana je statička metoda s cjelobrojnim argumentom {n}");
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
            // :010 Instancirati delegata tipa MojDelegat metodom StatičkaMetoda te pozvati delegata.
            MojDelegat md = new MojDelegat(StatičkaMetoda);
            md();

            // :011 Pokrenuti program i pogledati ispis.
        }

        public static void PozivMetodeInstancePrekoDelegata()
        {
            // :012 Instancirati delegata tipa MojDelegat metodom MetodaInstance te pozvati delegata. 
            PridruživanjeMetodaIPozivDelegata mi = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat md = new MojDelegat(mi.MetodaInstance);
            md();

            // :013 Pokrenuti program i provjeriti ispis.
        }

        public static void PozivStatičkeIDvijeMetodeInstancePrekoDelegata()
        {
            // :014 Instancirati delegata tipa MojDelegat metodom MetodaInstance. 
            PridruživanjeMetodaIPozivDelegata mi = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat md = mi.MetodaInstance;

            // :015 Delegatu dodati metodu StatičkaMetoda i metodu DrugaMetodaInstance te pozvati delegata.
            md += StatičkaMetoda;
            md += mi.DrugaMetodaInstance;
            md();

            // :016 Pokrenuti program i provjeriti ispis.

            // :017 Delegatu prije poziva pridružiti metodu DrugaStatičkaMetoda. Pogledati što se događa.
            //md += DrugaStatičkaMetoda();
            // nemaju isti potpis pa pridruzivanje nije moguce

            // :018 Pokrenuti i provjeriti testove (3 testa u grupi "DelegatskeMetode" moraju proći).
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
