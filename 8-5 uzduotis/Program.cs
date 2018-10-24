using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = 0;
            var lyginiai = 0;
            var nelyginiai = 0;
            while (s1 <=100)
            {
                if (s1%2==0)
                {
                    lyginiai += s1;
                }
                else if (s1%2!=0)
                {
                    nelyginiai += s1;
                }
                s1++;
            }
            Console.WriteLine("lyginiu skaiciu nuo 1 iki 100 suma:" + lyginiai);
            Console.WriteLine("nelyginiu skaiciu nuo 1 iki 100 suma:" + nelyginiai);

        }
    }
}
