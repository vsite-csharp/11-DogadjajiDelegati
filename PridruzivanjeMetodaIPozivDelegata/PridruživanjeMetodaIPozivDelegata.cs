namespace Vsite.CSharp.DogađajiDelegati
{
    internal class PridruživanjeMetodaIPozivDelegata
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
            MojDelegat md = StatičkaMetoda;
            md(); // ili: md.Invoke();
            // :011 Pokrenuti program i pogledati ispis.
        }

        public static void PozivMetodeInstancePrekoDelegata()
        {
            // :012 Instancirati delegata tipa MojDelegat metodom MetodaInstance te pozvati delegata. 
            var instanca = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat md = instanca.MetodaInstance;
            // :013 Pokrenuti program i provjeriti ispis.
            md();
        }

        public static void PozivStatičkeIDvijeMetodeInstancePrekoDelegata()
        {
            var instanca = new PridruživanjeMetodaIPozivDelegata();
            MojDelegat md = instanca.MetodaInstance;
            md += StatičkaMetoda;
            md += instanca.DrugaMetodaInstance;

            md();
            // :014 Instancirati delegata tipa MojDelegat metodom MetodaInstance. 

            // :015 Delegatu dodati metodu StatičkaMetoda i metodu DrugaMetodaInstance te pozvati delegata.

            // :016 Pokrenuti program i provjeriti ispis.

            //md += DrugaStatičkaMetoda; - ne odgovara potpisu
            // :017 Delegatu prije poziva pridružiti metodu DrugaStatičkaMetoda. Pogledati što se događa.

            // :018 Pokrenuti i provjeriti testove (3 testa u grupi "DelegatskeMetode" moraju proći).
        }

        static void Main()
        {
            PozivStatičkeMetodePrekoDelegata();

            Console.WriteLine();

            PozivMetodeInstancePrekoDelegata();

            Console.WriteLine();

            PozivStatičkeIDvijeMetodeInstancePrekoDelegata();

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
