using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k1 = 1; k1 <=10; k1++)
            {
                if (k1 % 2 != 0) { continue; }
                Console.WriteLine(k1);
                        }
            Console.WriteLine();

            for (int k1 = 1; k1 <= 10; k1++)
            {
                if (k1 % 2 == 0) { Console.WriteLine(k1); ; }
               
            }
            Console.WriteLine();

        }
    }
}
