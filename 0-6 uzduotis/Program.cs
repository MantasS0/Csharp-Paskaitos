using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var r0 = new Random();
            int gr1 = r0.Next(1, 10);
            while (true)
            {
                Console.WriteLine("Spekite skaiciu nuo 1 iki 10!");
                var s1 = Convert.ToInt16(Console.ReadLine());
                if (s1>gr1)
                {
                    Console.WriteLine("Jusu spetas skaicius yra per didelis.");
                    Console.WriteLine("Bandykite dar karta");
                    continue;
                }
                else if (s1<gr1)
                {
                    Console.WriteLine("Jusu spetas skaicius yra per mazas.");
                    Console.WriteLine("Bandykite dar karta");
                    continue;
                }
                else
                {
                    Console.WriteLine("Din! Din! Din! Laimingas skaicius yra {0}!",gr1);
                    Console.WriteLine("Sveikinu! Jus atspejote sugeneruota skaiciu!");
                    break;
                }
            }


        }
    }
}
