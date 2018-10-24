using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] { 1, 8, 9, 4, 6, 8, 6 };
            var sum = 0;
            foreach (var sk in skaiciai)
            {
                sum += sk;
            }
            Console.WriteLine("Suma: " + sum);
            Console.WriteLine("Vidurkis: " + (double)sum/skaiciai.Length);



        }
    }
}
