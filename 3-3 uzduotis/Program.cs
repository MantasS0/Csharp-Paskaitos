using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int k1 = 7;
            int k2 = 1;
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2++);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2++);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2++);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2++);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2++);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2++);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2++);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2++);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2++);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2++);

            int k3 = 73;
            Console.WriteLine("{0} -> {1} + {2} = {3}", k3, k3 / 10, k3 % 10, k3 / 10 + k3 % 10);


        }
    }
}
