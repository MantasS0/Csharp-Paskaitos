using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = 1;
            var sum = 0;
            do
            {
                if (s1%2==0)
                {
                    Console.WriteLine(s1);
                    sum += s1;
                }
                s1++;
            } while (s1%20!=0);
            Console.WriteLine(sum);
        }
    }
}
