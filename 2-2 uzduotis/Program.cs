using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Mantas";
            string pavarde = "Sasnauskas";
            int amzius = 26;
            string akademinesGrupesKodas = "SA-0/1";

            Console.WriteLine(vardas);
            Console.WriteLine(pavarde);
            Console.WriteLine(amzius);
            Console.WriteLine(akademinesGrupesKodas);
            Console.WriteLine();
        
            int kintamasis = 7;
            Console.Write(kintamasis);
            Console.Write(kintamasis);
            Console.Write(kintamasis);
            Console.Write(kintamasis);
            Console.Write(kintamasis);
            Console.WriteLine();

            var aukstis = 1.0;
            var plotis = 0.9;
            var ilgis = 1.6;
            var kojuSkaicius = 4;
            string gamintojas = "IKEA";

            Console.WriteLine("{0:0.0}", aukstis); //taip parodyt kad rodytu per kableli jei nebutina. Daugiau google "c# console writeline double with precision"
            Console.WriteLine(plotis);
            Console.WriteLine(ilgis);
            Console.WriteLine(kojuSkaicius);
            Console.WriteLine(gamintojas);

        }
    }
}
