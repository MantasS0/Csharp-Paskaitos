using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite neigiama skaiciu: ");
            var s1 = Convert.ToInt32(Console.ReadLine());
            if (s1<0)
            {
                do
                {
                    Console.WriteLine(s1);
                    s1++;
                } while (s1 <= 0);

            }
            else
            {
                Console.WriteLine("bandykite dar karta");
            }
        }
    }
}
