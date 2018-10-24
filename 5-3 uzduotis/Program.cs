using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigima skaiciu");
            var k1 = Convert.ToInt32(Console.ReadLine());
            if (k1 <= 0) { Console.WriteLine("U HAD ONE JOB..!"); }
            if (k1 > 0) { Console.WriteLine("Congratulations, you can do as well as a monkey."); }
            if (k1 % 2 == 0) { Console.WriteLine("Skaicius lyginis"); }
            if (k1 % 4 == 0) { Console.WriteLine("Skaicius dalinasi is 4"); }
            if (k1 > 10) { Console.WriteLine("skaicius didesnis nei 10"); }
            Console.WriteLine("iveskite kita skaiciu");
            var k2 = Convert.ToUInt32(Console.ReadLine());
            var d1 = 1;
            if (k2 % 5 == 0) { Console.WriteLine("{0}*{1}={2}",k2,d1,k2*d1);
                Console.WriteLine("{0}*{1}={2}", k2, ++d1, k2 * d1);
                Console.WriteLine("{0}*{1}={2}", k2, ++d1, k2 * d1);
                Console.WriteLine("{0}*{1}={2}", k2, ++d1, k2 * d1);
                Console.WriteLine("{0}*{1}={2}", k2, ++d1, k2 * d1);

            }
            if (k2 % 4 != 0) { Console.WriteLine("Iveskite antra skaiciu");
                var k3 = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("{0}+{1}={2}", k2, k3, k2 + k3);
                Console.WriteLine("{0}*{1}={2}",k2,k3,k2*k3);

            }
        }
    }
}
