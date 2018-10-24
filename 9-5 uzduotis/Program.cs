using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var r0 = new Random();

            do
            {
                var s1 = r0.Next();
                Console.WriteLine(s1);
                if (s1%3==0)
                {
                    break;
                }

            } while (true);
        }
    }
}
