using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_15_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sugeneruokite atsitiktinį skaičių. Sugeneruokite 100 atsitiktinių skaičių ir juos sukelkite į masyvą. 
             Iš masyvo išveskite visus skaičius žemesnius už sugeruotą atsitiktinį skaičių. Raskite išvestų skaičių sumą ir vidurkį.*/

            var r0 = new Random();
            int[] masyvas1 = new int[100];
            var tikrintojas1 = r0.Next(1,100);
            int kiek = 0;
            int[] masyvas2 = new int[100];


            for (int i = 0; i < 100; i++)
            {
                var r1 = r0.Next(100);
                masyvas1[i] = r1;
                if (r1 < tikrintojas1)
                {
                    masyvas2[kiek] = r1;
                    kiek++;
                }
                

            }
            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine(masyvas2[i]);
            }

            Console.WriteLine("Suma: " + masyvas2.Sum());
            Console.WriteLine("Vidurkis: " + masyvas2.Average());

        }
    }
}
