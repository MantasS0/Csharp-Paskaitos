using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_pavyzdys
{
    class Knygynas
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Knyga> Knygos { get; private set; }

        public Knygynas(string pavadinimas, string adresas, List<Knyga> knygos)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Knygos = knygos;
        }
        public void Isvedimas()
        {
            Console.WriteLine("Knygyno pavadinimas: " + Pavadinimas);
            Console.WriteLine("Adresas: " + Adresas);
            Console.WriteLine("-----------------------");
            Console.WriteLine("Jame turimos knygos:");
            Console.WriteLine("-----------------------");
            foreach (var knyga in Knygos)
            {
                knyga.Isvedimas();
            }
            Console.WriteLine("-----------------------");

            var didziausia = DidziausiaKnyga();              //vienas budas.
            Console.WriteLine("Didziausia knyga:");
            didziausia.Isvedimas();
            Console.WriteLine("-----------------------");

            Console.WriteLine("Didziausia knyga:");         // kitas budas.
            DidziausiaKnyga().Isvedimas();
            Console.WriteLine("-----------------------");

            Console.WriteLine("Bendra apyvarta pardavus viska:");
            Console.WriteLine(BendraApyvarta() + "eur");

        }
        public Knyga DidziausiaKnyga()
        {
            var didziausia = Knygos.First();
            foreach (var knyga in Knygos)
            {
                if (knyga.Puslapiai>didziausia.Puslapiai)
                {
                    didziausia = knyga;
                }
            }
            return didziausia;
        }
        public double BendraApyvarta()
        {
            double bendraApyv = 0;
            foreach (var knyga in Knygos)
            {
                bendraApyv += knyga.Apyvarta();
            }
            return bendraApyv;
        }
        public Knyga BrangiausiaKnyga()
        {
            var brangiausia = Knygos.First();
            foreach (var knyga in Knygos)
            {
                if (knyga.Kaina>brangiausia.Kaina)
                {

                }
            }
        }

    }
    
}
