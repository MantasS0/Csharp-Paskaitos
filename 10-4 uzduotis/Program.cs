using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] s1 = { 1, 8, 7, 9, 5 };
            int [] s2 = { 2, 3, 7, 6, 4 };
            int[] s3 = { 0, 9, 8, 4, 3 };
            var r0 = new Random();

            var r1 = r0.Next(5);
            var k1 = s1[r1];
            Console.WriteLine(k1);
            r1 = r0.Next(5);
            var k2 = s2[r1];
            Console.WriteLine(k2);
            r1 = r0.Next(5);
            var k3 = s3[r1];
            Console.WriteLine(k3);
            if (k1>k2 && k1>k3)
            {
                Console.WriteLine("Didziausias skaicius: " + k1);
            }
            else if (k2>k1 && k2>k3)
            {
                Console.WriteLine("Didziausias skaicius: " + k2);

            }
            else if (k3 > k1 && k3 > k2)
            {
                Console.WriteLine("Didziausias skaicius: " + k3);

            }
            else
            {
                Console.WriteLine("Du arba trys skaiciai buvo vienodi.");
            }




        }
    }
}
