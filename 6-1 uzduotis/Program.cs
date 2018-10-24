using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu nuo 1 iki 4");
            var s1 = Convert.ToInt32(Console.ReadLine());
            switch (s1) { case 1:
                    Console.WriteLine("Jus pasirinkote vandeni.");
                    break;
                case 2:
                    Console.WriteLine("Jus pasirinkote limonada.");
                    break;
                case 3:
                    Console.WriteLine("Jus pasirinkote arbata.");
                    break;
                case 4:
                    Console.WriteLine("Jus pasirinkote kava.");
                    break;
                default:
                    Console.WriteLine("Jus esate retardas.");
                    break;
            }




            /* Išveskite vartotojui pasirinkimų informaciją (pavyzdžiui: pasirinkite 1, jei vanduo, 2 - jei …, 3 - jei ...). Liepkite vartotojui įvesti pasirinkimo numerį. Tikrinkite:
Ar pasirinkimas lygus 1? Jei taip, išveskite, kad vartotojas pasirinko vandenį.
Ar pasirinkimas lygus 2? Jei taip, išveskite, kad vartotojas pasirinko limonadą.
Ar pasirinkimas lygus 3? Jei taip, išveskite, kad vartotojas pasirinko arbatą.
Ar pasirinkimas lygus 4? Jei taip, išveskite, kad vartotojas pasirinko kavą.
Jei pasirinkimas neegzistuoja, išveskite klaidos pranešimą.
*/


        }
    }
}
