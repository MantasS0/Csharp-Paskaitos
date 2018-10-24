using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite reziu pradzia");
            var pradzia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite reziu pabaiga");
            var pabaiga = Convert.ToInt32(Console.ReadLine());
            if (pradzia < pabaiga)
            {
                for (int i = pradzia; i <= pabaiga; i++) { Console.WriteLine(i + " " + Math.Pow(i,2)); }

            }
            else Console.WriteLine("Error -1");

            Console.WriteLine();

            /*Liepkite vartotojui įvesti rėžių pradžią ir pabaigą. Patikrinkite, kad tai būtų validu (pradžia turi būti mažesnė nei pabaiga). 
             * Jei rėžiai tinkami, tuomet vykdyti for, kuris atskirose eilutėse išvestų kiekvieną skaičių iš tų rėžių, bei atskiriant tarpu - tų skaičių kvadratus.*/
        }
    }
}
