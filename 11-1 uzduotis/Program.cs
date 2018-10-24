using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sk1 = new List<int>();
            var r0 = new Random();
            for (int i = 0; i < 10; i++)
            {
                sk1.Add(r0.Next(100));

            }
            Console.WriteLine(sk1.Min());
        }
    }
}
