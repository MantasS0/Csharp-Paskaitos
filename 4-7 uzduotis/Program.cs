using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Nuskaitykite iš konsolės šiuos duomenis apie darbuotoją: vardas; pavardė; gimimo metai; specialybė; etatas (nuo 0 iki 1);
             gaunama alga. Iš turimų gimimo metų paskaičiuokite koks darbuotojo amžius. Išveskite visą šią informaciją ekrane sakinio pavidalu. Pavyzdžiui:
             Algis Algiausias (52 m.) dirba policininku 0.5 etatu ir uždirba 500 eur/mėn.*/
            Console.Write("Vardas: ");
            var vardas = Console.ReadLine();
            Console.Write("Pavarde: ");
            var pavarde = Console.ReadLine();
            Console.Write("Gimimo metai: ");
            var metai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Specialybe: ");
            var spec = Console.ReadLine();
            Console.Write("Etatas: ");
            var etatas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Uzdarbis: ");
            var uzdarbis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1} ({2} m.) dirba {3} etatu ir uzdirba {4} eur/men.",vardas,pavarde,2018-metai,spec,etatas,uzdarbis);

        }
    }
}
