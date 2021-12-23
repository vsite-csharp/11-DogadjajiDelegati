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
            // Instancirati delegata tipa MojDelegat metodom StatičkaMetoda te pozvati delegata.
            MojDelegat md = StatičkaMetoda;
            md();
            // Pokrenuti program i pogledati ispis.
        }

        public static void PozivMetodeInstancePrekoDelegata()
        {
            // Instancirati delegata tipa MojDelegat metodom MetodaInstance te pozvati delegata. 
            var instanca = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat md = instanca.MetodaInstance;
            md();

            // Pokrenuti program i provjeriti ispis.
        }

        public static void PozivStatičkeIDvijeMetodeInstancePrekoDelegata()
        {
            // Instancirati delegata tipa MojDelegat metodom MetodaInstance. 
            var instanca = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat md = instanca.MetodaInstance;
            // Delegatu dodati metodu StatičkaMetoda i metodu DrugaMetodaInstance te pozvati delegata.
            md += StatičkaMetoda;
            md += instanca.MetodaInstance;
            //md += DrugaStatičkaMetoda;
            md();

            // Pokrenuti program i provjeriti ispis.

            // Delegatu prije poziva pridružiti metodu DrugaStatičkaMetoda. Pogledati što se događa.

            // Pokrenuti i provjeriti testove (3 testa u grupi "DelegatskeMetode" moraju proći).
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
