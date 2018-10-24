using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = 1;
            do
            {
                if (s1%5==0)
                {
                    Console.WriteLine("skaicius dalinasi is 5");

                }
                else
                {
                    Console.WriteLine(s1);

                }
                s1++;


            } while (s1%100!=0);
        }
    }
}
