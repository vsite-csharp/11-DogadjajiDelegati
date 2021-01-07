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
            MojDelegat md = new MojDelegat(StatičkaMetoda);

            md();
        }

        public static void PozivMetodeInstancePrekoDelegata()
        {
            MojDelegat md = new PridruživanjeMetodaIPozivDelegata().MetodaInstance;

            md();
        }

        public static void PozivStatičkeIDvijeMetodeInstancePrekoDelegata()
        {
            var instanca = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat md = instanca.MetodaInstance;
            md += StatičkaMetoda;
            md += instanca.DrugaMetodaInstance;
            md();
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
