using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r0 = new Random();
            while (true)
            {
                var s1 = r0.Next();
                Console.WriteLine(s1);
                if (s1%3==0 && s1%5==0)
                {
                    Console.WriteLine("Laimingas skaicius yra: " + s1);

                    break;
                }
            }
        }
    }
}
