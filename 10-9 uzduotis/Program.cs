using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new[] { 1, 8, 9, 5, 4, 6, 8 };
            var s2 = new[] { 5, 3, 4, 8, 4, 7, 1 };
            var sum1 = 0;
            var sum2 = 0;

            foreach (var sk1 in s1)
            {
                sum1 += sk1;
            }
            foreach (var sk2 in s2)
            {
                sum2 += sk2;
            }

            if (sum1>sum2)
            {
                Console.Write("Pirmojo masymo suma yra didesne ir yra: ");
            }
            else if (sum2>sum1)
            {
                Console.Write("Antrojo masymo suma yra didesne ir yra: ");

            }

            int [] s3 = new int[2];
            s3[0] = sum1;
            s3[1] = sum2;

            var ats1 = s3.Max();
            Console.WriteLine(ats1);


        }
    }
}
