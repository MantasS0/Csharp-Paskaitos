using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Mantas";
            int amzius = 26;
            Console.WriteLine("vardas: {0}", vardas);
            Console.WriteLine("amzius: {0}", amzius);

            string pavadinimas = "azuolas";
            var aukstis = 5.6;
            var storis = 0.64;
            Console.WriteLine("Medis {0} yra {1} metru aukscio ir {2} m storio.", pavadinimas, aukstis, storis);
            int skaicius = 420;
            Console.WriteLine("{0}{0}{0}{0}{0}", skaicius);


        }
    }
}
