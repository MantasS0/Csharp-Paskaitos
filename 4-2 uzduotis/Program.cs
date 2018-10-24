using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 2 skaicius.");
            var k1 = Convert.ToInt32(Console.ReadLine());
            var k2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(k1 + " + " + k2 + " = " + (k1 + k2));

            Console.Write("Jusu vardas: ");
            var vardas = Console.ReadLine();
            Console.Write("Jusu amzius: ");
            var amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jus deklavavote kad jusu vardas yra {0} ir jusu amzius yra {1}.", vardas, amzius);

            Console.WriteLine("Iveskite skaiciu.");
            var k3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jus ivedete skaiciu {0}. Jo kvadratas yra {1}.", k3, Math.Pow(k3,2));
            Console.WriteLine();
            Console.WriteLine("Iveskite 5 skaicius");
            var s1 = Convert.ToInt32(Console.ReadLine());
            var s2 = Convert.ToInt32(Console.ReadLine());
            var s3 = Convert.ToInt32(Console.ReadLine());
            var s4 = Convert.ToInt32(Console.ReadLine());
            var s5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jus ivedete {0}, {1}, {2}, {3}, {4}.",s1,s2,s3,s4,s5);
            var vid1 = (s1 + s2 + s3 + s4 + s5) / 5;
            Console.WriteLine("Siu skaiciu vidurkis yra: " + vid1);


        }
    }
}
