using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_pavyzdys
{
    class Knyga
    {
        public string Pavadinimas { get; private set; }
        public string Autorius { get; private set; }
        public int Puslapiai { get; private set; }
        public string Zanras { get; private set; }
        public double Kaina { get; private set; }
        public int Kiekis { get; private set; }
        public Knyga (string pavadinimas, string autorius, int puslapiai, string zanras, double kaina, int kiekis)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            Puslapiai = puslapiai;
            Zanras = zanras;
            Kaina = kaina;
            Kiekis = kiekis;
        }
        public void Isvedimas()
        {
            Console.WriteLine("Knyga {0} parasyta {1}. Puslapiu kiekis: {2}",Pavadinimas,Autorius,Puslapiai);
            Console.WriteLine("Knygos zanras: {0}. Siuo metu ji kainuoja tik: {1}eu (liko {2} sandelyje)",Zanras,Kaina,Kiekis);
            Console.WriteLine();
            Console.WriteLine("Pardavus visus vienetus gautusi: {0}eur.",Apyvarta());
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public double Apyvarta()
        {
            return Kiekis * Kaina;
        }
    }
}
