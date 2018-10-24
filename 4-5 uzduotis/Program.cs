using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sveika skaiciu");
            var k1 = Convert.ToInt32(Console.ReadLine());
            var k2 = 1;
            Console.WriteLine("{0} * {1} = {2}",k1,k2,k1*k2++);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2++);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2++);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2++);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2++);
            Console.WriteLine();
            Console.WriteLine("Iveskite tris skaicius");
            var s1 = Convert.ToDouble(Console.ReadLine());
            var s2 = Convert.ToDouble(Console.ReadLine());
            var s3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Siu skaiciu kvadratai yra: {0}, {1}, {2}.", Math.Pow(s1,2), Math.Pow(s2, 2), Math.Pow(s3, 2));
            Console.WriteLine("Siu skaiciu kubai yra: {0}, {1}, {2}.", Math.Pow(s1, 3), Math.Pow(s2, 3), Math.Pow(s3, 3));
            Console.WriteLine("Sie skaiciai padalinti is 2 yra: {0}, {1}, {2}.", s1/2,s2/2,s3/2);



        }
    }
}
