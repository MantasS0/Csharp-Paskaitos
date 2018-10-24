using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            var sandauga = 1;
            while (i<=10)
            {
                sandauga *= i;
                i++;
            }
            Console.WriteLine(sandauga);
        }
    }
}
