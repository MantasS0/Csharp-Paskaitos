using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = 1;
            Console.Write(s1);
            while (s1<100)
            {
                s1++;
                Console.Write("," + s1);
            }
        }
    }
}
