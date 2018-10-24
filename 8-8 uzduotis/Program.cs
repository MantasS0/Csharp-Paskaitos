using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r0 = new Random();
            int i = 1;
            var sum = 0;
            while (i <= 100) 
            {
                var s1 = r0.Next(100);
                Console.Write(s1 + ", ");
                sum += s1;
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Siu skaiciu suma yra: " + sum);
            Console.WriteLine("siu skaiciu vidurkis yra: " + sum/i);
        }
    }
}
