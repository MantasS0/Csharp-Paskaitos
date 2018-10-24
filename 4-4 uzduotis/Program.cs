using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 2 skaicius");
            var k1 = Convert.ToInt32(Console.ReadLine());
            var k2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", k1,k2,k1+k2);
            Console.WriteLine("{0} - {1} = {2}", k1, k2, k1 - k2);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2);
            Console.WriteLine("{0} / {1} = {2}", k1, k2, (double)k1 / k2);

            Console.WriteLine("Iveskite 3 skaicius");
            var k3 = Convert.ToDouble(Console.ReadLine());
            var k4 = Convert.ToDouble(Console.ReadLine());
            var k5 = Convert.ToDouble(Console.ReadLine());
            double vidurkis = (k3 + k4 + k5) / 3;
            Console.WriteLine("Vidurikis: " + vidurkis);

        }
    }
}
