using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 3;
            int kvadratas = 2;
            int kubas = 3;
            Console.WriteLine(skaicius);
            Console.WriteLine(Math.Pow(skaicius, kvadratas));
            Console.WriteLine(Math.Pow(skaicius, kubas));
            Console.WriteLine("{0}, {1}, {2}.", skaicius, Math.Pow(skaicius, kvadratas), Math.Pow(skaicius, kubas));
            int k1 = 4;
            int k2 = 8;
            int k3 = 3;
            Console.WriteLine(k1 + k2 + k3);
            Console.WriteLine(k1 * k2 * k3);
            Console.WriteLine();
            int k4 = 3;
            int k5 = 5;
            Console.WriteLine(k4+k5);
            Console.WriteLine(k4-k5);
            Console.WriteLine((k4+k5)*(k4-k5));
            Console.WriteLine((k4 + k5) / (k4 - k5));
            int k6 = 3;
            int k7 = 5;
            int k8 = 7;
            int k9 = 9;
            Console.WriteLine((k6 + k7 + k8 + k9) / 4);

        }
    }
}
