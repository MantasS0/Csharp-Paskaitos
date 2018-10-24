using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_16_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var r0 = new Random();
            int[] mas1 = new int[25];
            for (int i = 0; i < mas1.Length; i++)
            {
                var r1 = r0.Next(100);
                mas1[i] = r1;
            }

            for (int i = 0; i < mas1.Length; i++)
            {
                if (i%5==0 && i!=0)
                {
                    Console.WriteLine();
                }
                Console.Write(mas1[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
