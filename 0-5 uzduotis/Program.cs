using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Iveskite skaiciu: ");
                var s1 = Convert.ToInt32(Console.ReadLine());
                
                if (s1%9==0)
                {
                    Console.WriteLine("jusu ivestas skaicius {0} dalinasi is 9!", s1);
                    break;
                }

            }

        }
    }
}
