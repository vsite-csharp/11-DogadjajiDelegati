using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurenjeMemorijeZbogNeodjave
{
    class Program
    {
        class GeneratorDogadjaja
        {
            public event EventHandler Događaj;
        }

        class SlušateljDogađaja
        {
            static int brojInstanci = 0;

            // prilikom stvaranja objekta ispisujemo koliko je trenutno objekata
            public SlušateljDogađaja()
            {
                Console.WriteLine("{0}", ++brojInstanci);
            }

            // prilikom uništavanja objekta ispisujemo koliko je trenutno objekata (s negativnim predznakom, da bude uočljivije)
            ~SlušateljDogađaja()
            {
                Console.WriteLine("-{0}", --brojInstanci);
            }

            // metoda kojom se predbilježujemo na događaj
            public void DogađajEventHandler(object sender, EventArgs a)
            {
            }

            // veliki član u klasi da bismo opteretili GC
            double[] niz = new double[10000];
        }


        static void Main(string[] args)
        {
            GeneratorDogadjaja gd = new GeneratorDogadjaja();

            for (int i = 0; i < 100000; ++i)
            {
                SlušateljDogađaja sd = new SlušateljDogađaja();

                //  Pokrenuti kod i provjeriti ispis na konzolu.

                //  Dodati naredbu kojom se objekt sd predbilježi na slušanje događaja, pokrenuti kod i provjeriti ispis.
                gd.Događaj += sd.DogađajEventHandler;

                //  Dodati naredbu kojom se objekt sd odjavljuje od slušanja događaja, pokrenuti kod i provjeriti ispis.
                gd.Događaj -= sd.DogađajEventHandler;
                ////////jako vazno!!!!!!!bez toga dolazi do curenja memorije///////
            }

            Console.WriteLine($"Zauzeta memorija na heapu: {GC.GetTotalMemory(true) / 1024.0} kB");
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
