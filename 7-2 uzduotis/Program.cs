using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k1 = 0; k1 <= 15; k1++)
            { if (k1 % 2 != 0) { continue; }
                Console.Write(k1 + " ");

             }
            Console.WriteLine();
            for (int k1 = 0; k1 <= 15; k1+=2)
            { Console.Write(k1 + " "); }
        }

    }
}
