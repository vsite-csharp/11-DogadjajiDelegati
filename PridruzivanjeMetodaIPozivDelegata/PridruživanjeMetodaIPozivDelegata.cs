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
            MojDelegat md = StatičkaMetoda;
            md();
            // Instancirati delegata tipa MojDelegat metodom StatičkaMetoda te pozvati delegata.
        }

        public static void PozivMetodeInstancePrekoDelegata()
        {
            // Instancirati delegata tipa MojDelegat metodom MetodaInstance te pozvati delegata. 
            PridruživanjeMetodaIPozivDelegata pm = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat md = pm.MetodaInstance;
            md();
        }

        public static void PozivStatičkeIDvijeMetodeInstancePrekoDelegata()
        {
            // Instancirati delegata tipa MojDelegat metodom MetodaInstance. 
            PridruživanjeMetodaIPozivDelegata pm = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat md = pm.MetodaInstance;

            //Delegatu dodati metodu Statička metoda i metodu DrugaMetodaInstance te pozvati delegata.
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
