using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = 0;
            var r2 = 100;
            Console.WriteLine("iveskite skaiciu nuo 0 iki 100");
            var k1 = Convert.ToInt32(Console.ReadLine());
            if (k1 >= r1 && k1 <= r2) { Console.WriteLine("Skaicius patenka i rezius"); }
            else { Console.WriteLine("Skaicius nepatenka i rezius"); }
            Console.WriteLine("iveskite teigiama skaiciu");
            var k2 = Convert.ToInt32(Console.ReadLine());
            if (k2 > 0 && k2 % 2 ==0) { Console.WriteLine("Skaicius yra teigiamas ir yra lyginis"); }
            else { Console.WriteLine("Skaicius netoks"); }
            Console.WriteLine("iveskite skaiciu");
            var k3 = Convert.ToInt32(Console.ReadLine());
            if (k3 % 2 == 0 || k3 % 3 == 0 || k3 % 7 == 0) { Console.WriteLine("Skaicius dalinasi is 2, 3 arba 7"); }
            else { Console.WriteLine("FATAL ERROR!"); }
            Console.WriteLine("iveskite 3 skaicius");
            var s1 = Convert.ToInt32(Console.ReadLine());
            var s2 = Convert.ToInt32(Console.ReadLine());
            var s3 = Convert.ToInt32(Console.ReadLine());
            if (s1 > s2 && s1 > s3) { Console.WriteLine("{0} yra didziausias skaicius", s1); }
            else if (s2 > s1 && s2 > s3) { Console.WriteLine("{0} yra didziausias skaicius", s2); }
            else if (s3 > s1 && s3 > s2) { Console.WriteLine("{0} yra didziausias skaicius", s3); }
            else { Console.WriteLine("CODE 404, SYSTEM32 NOT FOUND!"); }
            Console.WriteLine("iveskite 3 skaicius");
            var a1 = Convert.ToInt32(Console.ReadLine());
            var a2 = Convert.ToInt32(Console.ReadLine());
            var a3 = Convert.ToInt32(Console.ReadLine());
            if (a1 < a2 && a1 < a3) { Console.WriteLine("{0} yra maziausias skaicius", a1); }
            else if (a2 < a1 && a2 < a3) { Console.WriteLine("{0} yra maziausias skaicius", a2); }
            else if (a3 < a1 && a3 < a2) { Console.WriteLine("{0} yra maziausias skaicius", a3); }
            else { Console.WriteLine("CODE 404, SYSTEM32 NOT FOUND!"); }



        }
    }
}
