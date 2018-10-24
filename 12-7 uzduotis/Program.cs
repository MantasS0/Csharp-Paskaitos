using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Metodas1();


        }
        public void Metodas1()
        {
            var r0 = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(r0.Next(100) + " ");
            }
        }
    }
}
