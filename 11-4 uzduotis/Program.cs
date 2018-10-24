using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 10 skaiciu: ");
            var sk1 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                sk1.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (var s1 in sk1)
            {
                Console.Write(s1 + " ");
            }

        }
    }
}
