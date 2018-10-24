using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius.");
            int k1 = Convert.ToInt32(Console.ReadLine());
            int k2 = Convert.ToInt32(Console.ReadLine());
            int k3 = Convert.ToInt32(Console.ReadLine());
            if (k1 == k2)
            { Console.WriteLine(k1 + " = " + k2); }
            if (k2 == k3)
            { Console.WriteLine(k2 + " = " + k3); }
            if (k1 > k2)
            { Console.WriteLine(k1 + " > " + k2); }
            if (k2 > (k3*2))
            { Console.WriteLine(k2 + " > " + k3 + "*2"); }
            if (k1 %2==0)
            { Console.WriteLine(k1 + " yra lyginis"); }
            if (k2 % 2 != 0)
            { Console.WriteLine(k2 + " yra nelyginis"); }
            if (k3 > 0)
            { Console.WriteLine(k3 + " yra teigiamas"); }
            if (k1 < 0)
            { Console.WriteLine(k1 + " yra neigiamas"); }
            if (k2 % 4 == 0)
            { Console.WriteLine(k2 + " dalinasi is 4"); }
            if (k3 % 8 == 0)
            { Console.WriteLine(k3 + " dalinasi is 8"); }

        }
    }
}
