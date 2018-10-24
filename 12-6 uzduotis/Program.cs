using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Mas1();


        }

        public void Mas1()
        {
            var s1 = new[] { 5, 64, 84, 2, 45, 32, 1 };
            foreach (var s in s1)
            {
                Console.Write(s+" ");
            }
        }
    }
}
