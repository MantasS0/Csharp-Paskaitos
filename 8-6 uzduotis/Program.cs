using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r0 = new Random();
            var sum = 0;
            var i = 1;
            while (i <=10)
            {
                var s1 = r0.Next(100);
                Console.WriteLine(s1);
                sum += s1;
                i++;
            }
            Console.WriteLine("Siu skaiciu suma yra: "+sum);
        }
    }
}
