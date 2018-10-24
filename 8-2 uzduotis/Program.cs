using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = 1;
            while (s1<=50)
            {
                Console.Write(s1);
                if (s1 % 2 == 0)
                { Console.Write(" lyginis"); }
                else if (s1%2!=0)
                {
                    Console.Write(" nelyginis");
                }
                Console.WriteLine();
                s1++;

            }
        }
    }
}
