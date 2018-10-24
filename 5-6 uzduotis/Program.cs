using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            var k1 = Convert.ToInt32(Console.ReadLine());
            if (k1 % 2 == 0) { Console.WriteLine("{0} dalinasi is 2",k1); }
            else if (k1 % 3 == 0) { Console.WriteLine("{0} dalinasi is 3", k1); }
            else if (k1 % 4 == 0) { Console.WriteLine("{0} dalinasi is 4", k1); }
            else if (k1 % 5 == 0) { Console.WriteLine("{0} dalinasi is 5", k1); }
            else if (k1 % 7 == 0) { Console.WriteLine("{0} dalinasi is 7", k1); }
            else { Console.WriteLine("{0} nesidalina is nurodytu dalmenu", k1); }
            Console.WriteLine("iveskite 2 skaicius");
            var k2 = Convert.ToInt32(Console.ReadLine());
            var k3 = Convert.ToInt32(Console.ReadLine());
            if (k2 > k3) { Console.WriteLine("{0} > {1}", k2,k3); }
            else if (k2 < k3) { Console.WriteLine("{0} < {1}", k2,k3); }
            else { Console.WriteLine("Skaciai yra lygus"); }
        }
    }
}
