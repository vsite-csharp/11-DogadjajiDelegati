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
            // Instancirati delegata tipa MojDelegat metodom StatičkaMetoda te pozvati delegata.
            MojDelegat md = new MojDelegat(StatičkaMetoda);
            md();
            // Pokrenuti program i pogledati ispis.
        }

        public static void PozivMetodeInstancePrekoDelegata()
        {
            // Instancirati delegata tipa MojDelegat metodom MetodaInstance te pozvati delegata. 
            PridruživanjeMetodaIPozivDelegata instanca = new PridruživanjeMetodaIPozivDelegata();

            MojDelegat md = instanca.MetodaInstance;

            md();
            // Pokrenuti program i provjeriti ispis.
        }

        public static void PozivStatičkeIDvijeMetodeInstancePrekoDelegata()
        {
            // Instancirati delegata tipa MojDelegat metodom MetodaInstance. 
            PridruživanjeMetodaIPozivDelegata instanca = new PridruživanjeMetodaIPozivDelegata();

            MojDelegat md = instanca.MetodaInstance;

            // Delegatu dodati metodu Statička metoda i metodu DrugaMetodaInstance te pozvati delegata.
            md += StatičkaMetoda;
            md += instanca.DrugaMetodaInstance;

            md();

            // Pokrenuti program i provjeriti ispis.

            // Pokrenuti i provjeriti testove (3 testa u grupi "DelegatskeMetode" moraju proći).
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
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
