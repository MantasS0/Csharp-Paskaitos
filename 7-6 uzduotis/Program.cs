using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_6_uzduotis
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
                for (var i = pradzia;i <= pabaiga;i++)
                {
                    
                    if ((i%2!=0) || (i % 8 == 0)) { Console.WriteLine(i);}
                }

            }
            else Console.WriteLine("Error!");

            /*Liepkite vartotojui įvesti rėžių pradžią ir pabaigą. Patikrinkite, kad tai būtų validu (pradžia turi būti mažesnė nei pabaiga). 
             * Jei rėžiai tinkami, tuomet vykdyti for, kuris iš duotų skaičių išvestų visus nelyginius skaičius arba tuos, kurie dalinasi iš 8.*/
        }
    }
}
