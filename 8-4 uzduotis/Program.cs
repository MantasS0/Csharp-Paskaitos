using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = 25;
            while (s1<=50)
            {
                if (s1%3==0)
                {
                    Console.WriteLine("dalinasi is 3");
                }
                else
                {
                    Console.WriteLine(s1);
                }
                s1++;
            }
        }
    }
}
