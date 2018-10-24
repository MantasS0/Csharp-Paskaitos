using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prasau iveskite savo amziu.");
            int a1 = Convert.ToInt32(Console.ReadLine());
            if(a1>=18)
            { Console.WriteLine("Jus galite balsuoti!"); }
            Console.WriteLine();
            Console.WriteLine("iveskite 3 pazymius");
            int p1 = Convert.ToInt32(Console.ReadLine());
            int p2 = Convert.ToInt32(Console.ReadLine());
            int p3 = Convert.ToInt32(Console.ReadLine());
            if((p1+p2+p3)/3>=5)
            { Console.WriteLine("jusu pazymiu vidurkis teigiamas"); }
            Console.WriteLine();
            Console.WriteLine("iveskite betkoki skaiciu.");
            double s1 = Convert.ToDouble(Console.ReadLine());
            int d1 = 1;
            if(s1%5==0)
            { Console.WriteLine("{0}*{1}={2}",s1,d1,s1*d1);
              Console.WriteLine("{0}*{1}={2}",s1,++d1,s1*d1);
              Console.WriteLine("{0}*{1}={2}", s1, ++d1, s1 * d1);
              Console.WriteLine("{0}*{1}={2}", s1, ++d1, s1 * d1);
              Console.WriteLine("{0}*{1}={2}", s1, ++d1, s1 * d1);
            }
            if(s1%2==0)
            { Console.WriteLine(s1);
                Console.WriteLine(Math.Pow(s1,2));
                Console.WriteLine(s1/2);
            }
            if(s1%7!=0)
            { Console.WriteLine("iveskite antraji skaiciu");
                double s2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0}+{1}={2}",s1,s2,s1+s2);
                Console.WriteLine("{0}-{1}={2}", s1, s2, s1 - s2);
                Console.WriteLine("{0}*{1}={2}", s1, s2, s1 * s2);
                Console.WriteLine("{0}/{1}={2}", s1, s2, s1 / s2);



            }
        }
    }
}
