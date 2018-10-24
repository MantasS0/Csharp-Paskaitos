using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_14_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Irasykite Fibonaciaus skaiciu kieki: ");
            var k1 = Convert.ToInt32(Console.ReadLine());
            uint[] fib1 = new uint[k1];
            

            uint s1 = 1;
            uint s2 = 1;
            uint s3 = s1+s2;
            fib1[0] = s2;

            for (uint i = 1; i < k1; s3 = s1 + s2)
            {
                s1 = s2;
                s2 = s3;
                fib1[i] = s3;
                i++;
            }
            foreach (var f1 in fib1)
            {
                Console.Write(f1 + ",");
            }



        }
    }
}
