using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite teigiama skaiciu");
            var k1 = Convert.ToInt32(Console.ReadLine());
            if (k1 > 0) { Console.WriteLine("Congratulations, u are as smart as a monkey"); }
            else { Console.WriteLine("U HAD ONE JOB!"); }
            Console.WriteLine("iveskite skaiciu");
            var k2 = Convert.ToInt32(Console.ReadLine());
            if (k2 % 2 == 0) { Console.WriteLine("Ivestas skaicius yra lyginis"); }
            else { Console.WriteLine("Ivestas skacius yra nelyginis"); }
            Console.WriteLine("iveskite teigiama skaiciu");
            var k3 = Convert.ToInt32(Console.ReadLine());
            if (k3 % 7 ==0) { Console.WriteLine("Congratulations, u are as smart as a child"); }
            else { Console.WriteLine("Try again, n00b"); }
            Console.WriteLine("iveskite du skaicius");
            var k4 = Convert.ToInt32(Console.ReadLine());
            var k5 = Convert.ToInt32(Console.ReadLine());

            if (k4 > k5) { Console.WriteLine("{0}>{1}",k4,k5); }
            else { Console.WriteLine("Whoups, something went wrong..."); }
        }
    }
}
