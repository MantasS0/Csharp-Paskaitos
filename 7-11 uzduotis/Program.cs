using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            for(int i = 0; i < 1000; i++)
            {
                if(i%3==0 || i % 5 == 0)
                {
                    sum += i;
                    Console.Write(sum + " + ");
                }
            }
            Console.WriteLine(" = " + sum);
        }
    }
}
