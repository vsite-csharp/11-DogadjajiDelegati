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
            MojDelegat myDelegat = StatičkaMetoda;
            myDelegat();
        }

        public static void PozivMetodeInstancePrekoDelegata()
        {
            PridruživanjeMetodaIPozivDelegata pm = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat myDelegat = pm.MetodaInstance;
            myDelegat();
        }

        public static void PozivStatičkeIDvijeMetodeInstancePrekoDelegata()
        {
            PridruživanjeMetodaIPozivDelegata pm = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat myDelegat = pm.MetodaInstance;
            myDelegat += StatičkaMetoda;
            myDelegat += pm.DrugaMetodaInstance;
            myDelegat();
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
