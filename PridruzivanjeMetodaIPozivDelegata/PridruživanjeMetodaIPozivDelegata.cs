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
            // TODO:010 Instancirati delegata tipa MojDelegat metodom StatičkaMetoda te pozvati delegata.
            // TODO:011 Pokrenuti program i pogledati ispis.
            MojDelegat md = StatičkaMetoda;
            md();
            
        }

        public static void PozivMetodeInstancePrekoDelegata()
        {
            // TODO:012 Instancirati delegata tipa MojDelegat metodom MetodaInstance te pozvati delegata. 
            // TODO:013 Pokrenuti program i provjeriti ispis.
            PridruživanjeMetodaIPozivDelegata pm = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat md = pm.MetodaInstance;
            md();
        }

        public static void PozivStatičkeIDvijeMetodeInstancePrekoDelegata()
        {
            // TODO:014 Instancirati delegata tipa MojDelegat metodom MetodaInstance. 
            // TODO:015 Delegatu dodati metodu Statička metoda i metodu DrugaMetodaInstance te pozvati delegata.
            // TODO:016 Pokrenuti program i provjeriti ispis.
            // TODO:017 Pokrenuti i provjeriti testove (3 testa u grupi "TestDelegatskihMetoda" moraju proći).
            PridruživanjeMetodaIPozivDelegata pm = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat md = pm.MetodaInstance;
            md += StatičkaMetoda;
            md += pm.DrugaMetodaInstance;
            md();
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
