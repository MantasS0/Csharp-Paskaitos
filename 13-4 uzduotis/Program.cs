using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_4_uzduotis
{
    class Program
    {
        /*Parašykite metodą, kuris priimtų du skaičius. Jame išveskite tą skaičių, kuris yra didesnis. O jei skaičiai lygūs - išvestų tekstą “skaičiai lygūs”*/


        static void Main(string[] args)
        {
            var p = new Program();
            p.Didesnis(5,10);
            p.Didesnis(-50,-100);
            p.Didesnis(5, 5);

            var r0 = new Random();
            p.Didesnis(r0.Next(100), r0.Next(100));
            p.Didesnis(r0.Next(100), r0.Next(100));
            p.Didesnis(r0.Next(100), r0.Next(100));


        }
        public void Didesnis (int a, int b)
        {
            if (a>b)
            {
                Console.WriteLine("{0} yra didesnis uz {1}",a,b);
            }
            else if (b>a)
            {
                Console.WriteLine("{0} yra didesnis uz {1}",b,a);
            }
            else
            {
                Console.WriteLine("Skaiciai {0} ir {1} yra lygus",a,b);
            }
        }

    }
}
