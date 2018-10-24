using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___8_uzduotis
{
    class Program
    {
        Random r0 = new Random();

        static void Main(string[] args)
        {
            var p = new Program();

            for (int i = 0; i < 100; i++)
            {
                p.Metodas1();
            }

        }
        public void Metodas1()
        {
            Console.Write(r0.Next(100) + " ");
        }
    }
}
