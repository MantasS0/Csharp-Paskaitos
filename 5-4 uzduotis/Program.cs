using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 3 skaicius");
            var k1 = Convert.ToInt32(Console.ReadLine());
            var k2 = Convert.ToInt32(Console.ReadLine());
            var k3 = Convert.ToInt32(Console.ReadLine());
            if (k1 > k2) { Console.WriteLine("{0}>{1}",k1,k2); }
            else if (k3 > k1) { Console.WriteLine("{0}>{1}", k3, k1); }
            else if (k1 == k2) { Console.WriteLine("{0}={1}", k1, k2); }
            else if (k2 == k3) { Console.WriteLine("{0}={1}", k2, k3); }
            /*Liepkite vartotojui įvesti egzamino pažymį [0-10]. Naudojant else if dalis patikrinkite šias sąlygas ir išveskite atitinkamą tekstą:
Jei pažymys yra lygus 10 išvesti “puiku”.
Jei pažymys yra lygus arba didesnis nei 9 išvesti “labai gerai”.
Jei pažymys yra lygus arba didesnis nei 7 išvesti “gerai”.
Jei pažymys yra lygus arba didesnis nei 5 išvesti “patenkinamai”.
Jei pažymys mažesnis nei 5 išvesti “egzaminas neišlaikytas”.
*/

            Console.WriteLine("Iveskite savo pazymi [1-10]");
            var p1 = Convert.ToInt32(Console.ReadLine());
            if (p1 == 10) { Console.WriteLine("Puiku!"); }
            else if (p1 >= 9) { Console.WriteLine("labai gerai"); }
            else if (p1 >= 7) { Console.WriteLine("gerai"); }
            else if (p1 >= 5) { Console.WriteLine("patenkinamai"); }
            else if (p1 < 5) { Console.WriteLine("egzaminas neislaikytas"); }

        }
    }
}
