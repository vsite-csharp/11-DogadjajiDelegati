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
            MojDelegat mojDelegat = StatičkaMetoda;
            mojDelegat();
            // Pokrenuti program i pogledati ispis.
        }

        public static void PozivMetodeInstancePrekoDelegata()
        {
            // Instancirati delegata tipa MojDelegat metodom MetodaInstance te pozvati delegata. 
            MojDelegat mojDelegat = new PridruživanjeMetodaIPozivDelegata().MetodaInstance;
            // Pokrenuti program i provjeriti ispis.
            mojDelegat();
        }

        public static void PozivStatičkeIDvijeMetodeInstancePrekoDelegata()
        {
            // Instancirati delegata tipa MojDelegat metodom MetodaInstance. 
            MojDelegat mojDelegat = new PridruživanjeMetodaIPozivDelegata().MetodaInstance;
            // Delegatu dodati metodu StatičkaMetoda i metodu DrugaMetodaInstance te pozvati delegata.
            mojDelegat += StatičkaMetoda;
            mojDelegat += new PridruživanjeMetodaIPozivDelegata().DrugaMetodaInstance;
            // Pokrenuti program i provjeriti ispis.
            mojDelegat();
            // Delegatu prije poziva pridružiti metodu DrugaStatičkaMetoda. Pogledati što se događa.
            //mojDelegat += DrugaStatičkaMetoda(1);
            // Pokrenuti i provjeriti testove (3 testa u grupi "DelegatskeMetode" moraju proći).
            //mojDelegat();
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
