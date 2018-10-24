using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            while (i<=50)
            {
                Console.Write("Skaicius " );
                Console.Write(i);
                Console.Write(" dalinasi is: ");

                for (int d1 = 2; d1 < 10; d1++)
                {
                    if (i % d1 == 0)
                    {
                        Console.Write(d1 + ", ");
                    }
                
                }

                i++;
                Console.WriteLine();

                
     
            }
        }
    }
}
