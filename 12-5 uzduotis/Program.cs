using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Lentele();
        }
        public void Lentele()
        {
            var r0 = new Random();
            for (int i = 0; i < 5; i++)
            {
                int s1 = r0.Next(100);
                int s2 = r0.Next(100);
                Console.WriteLine("{0,3} | {1,3} | {2,3}", s1, s2, s1 + s2);
            }
            
        }
    }
}
