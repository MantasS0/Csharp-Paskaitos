using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Irasykite simboli.");
            var s1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}",s1);
            Console.WriteLine("{0} {0}", s1);
            Console.WriteLine("{0}{0}{0}", s1);
            Console.Write("Irasykite simboli.");
            var s2 = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.WriteLine("{0}", s2);
            Console.WriteLine("{0}{0}", s2);
            Console.WriteLine("{0}{0}{0}", s2);
            Console.WriteLine();



        }
    }
}
