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
             MojDelegat m = new MojDelegat(StatičkaMetoda);
            m();

            // TODO:011 Pokrenuti program i pogledati ispis.
        }

        public static void PozivMetodeInstancePrekoDelegata()
        {
            PridruživanjeMetodaIPozivDelegata pm = new PridruživanjeMetodaIPozivDelegata();
            // TODO:012 Instancirati delegata tipa MojDelegat metodom MetodaInstance te pozvati delegata. 
            MojDelegat m = new MojDelegat(pm.MetodaInstance);

            m();
            // TODO:013 Pokrenuti program i provjeriti ispis.
        }

        public static void PozivStatičkeIDvijeMetodeInstancePrekoDelegata()
        {
            PridruživanjeMetodaIPozivDelegata mm = new PridruživanjeMetodaIPozivDelegata();
            // TODO:014 Instancirati delegata tipa MojDelegat metodom MetodaInstance. 
            MojDelegat m = new MojDelegat(mm.MetodaInstance);
            // TODO:015 Delegatu dodati metodu Statička metoda i metodu DrugaMetodaInstance te pozvati delegata.
            m += StatičkaMetoda;
            m += mm.DrugaMetodaInstance;
            // TODO:016 Pokrenuti program i provjeriti ispis.
            m();
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
