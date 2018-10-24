using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite teigiama skaiciu: ");
            var s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (s1>0)
            {
                for (var i = 0; s1 > -1; s1--)
                {
                    Console.WriteLine(s1);
                    
                }
            }
            else
            {
                Console.WriteLine("bandykite dar karta");
            }
           

        }
    }
}
