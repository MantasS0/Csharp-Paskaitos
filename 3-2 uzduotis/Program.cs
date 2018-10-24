using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int k1 = 3;
            int k2 = 2;
            Console.WriteLine("{0} + {1} = {2}", k1, k2, k1 + k2);
            Console.WriteLine("{0} - {1} = {2}", k1, k2, k1 - k2);
            Console.WriteLine("{0} * {1} = {2}", k1, k2, k1 * k2);
            Console.WriteLine("{0} / {1} = {2}", k1, k2, k1 / k2);


            Console.WriteLine();
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            /*Išveskite į ekraną šių veiksmų atsakymus:
-1 + 4 * 6
(35 + 5) % 7
14 + -4 * 6 / 11
2 + 15 / 6 * 1 - 7 % 2
Turite gauti: 23, 5, 12, 3.*/


        }
    }
}
