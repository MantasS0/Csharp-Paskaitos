using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite bet koki skaiciu (norint baigti ir sudeti ivestus skaicius ivesti 0):");
            var s1 = Convert.ToInt32(Console.ReadLine());
            var sum = s1;

            while (s1!=0)
            {
                Console.WriteLine("iveskite bet koki skaiciu (norint baigti ir sudeti ivestus skaicius ivesti 0");
                s1 = Convert.ToInt32(Console.ReadLine());
                sum += s1;

            }
            Console.WriteLine("suvestu skaiciu suma yra: " + sum);
        }
    }
}
