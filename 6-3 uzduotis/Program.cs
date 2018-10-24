using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius");
            var s1 = Convert.ToInt32(Console.ReadLine());
            var s2 = Convert.ToInt32(Console.ReadLine());
            var s3 = Convert.ToInt32(Console.ReadLine());
            switch (s1)
            {
                case 1:
                    Console.WriteLine("{0} + {1} + {2} = {3}",s1, s2,s3,s1+s2+s3);
                    break;
                case 2:
                    Console.WriteLine("{0} * {1} = {2}",s2,s3,s2*s3);
                    break;
                case 3:
                    Console.WriteLine("{0} * {0} = {1}",s1,Math.Pow(s1,2));
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }


            /*Liepkite vartotojui įvesti tris skaičius. Tikrinkite pirmą skaičių:
Ar pirmas skaičius lygus 1? Jei taip, išvesti visų trijų skaičių sumą.
Ar pirmas skaičius lygus 2? Jei taip, išvesti antro ir trečio skaičių sandaugą.
Ar pirmas skaičius lygus 3? Jei taip, išvesti pirmo skaičiaus kvadratą.
Jei nei vienas variantas netinka, išveskite klaidos pranešimą.
*/

        }
    }
}
