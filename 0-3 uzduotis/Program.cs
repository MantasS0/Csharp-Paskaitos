using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ar norite skaiciuoti? t/n");
                var a1 = Convert.ToChar(Console.ReadKey().KeyChar);
                if (a1 == 't')
                {
                    Console.WriteLine();
                    Console.WriteLine("iveskite 2 skaicius: ");
                    var s1 = Convert.ToDouble(Console.ReadLine());
                    var s2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("{0} + {1} = {2}", s1, s2, s1 + s2);
                    Console.WriteLine("{0} - {1} = {2}", s1, s2, s1 - s2);
                    Console.WriteLine("{0} * {1} = {2}", s1, s2, s1 * s2);
                    Console.WriteLine("{0} / {1} = {2}", s1, s2, (double)s1 / s2);


                }
                else if (a1=='n')
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine();

                    Console.WriteLine("ar tikrai nuspaudete teisingai?");
                    continue;
                }

            }

        }
    }
}
