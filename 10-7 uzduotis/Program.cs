using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Susikurkite skaičių masyvą, kurį užpildykite atsitiktiniais skaičiais. Išveskite visus skaičius su indeksais į atskiras eilutes. Pavyzdžiui:
                indekse 0 yra 8
                indekse 1 yra 2
                indekse 2 yra 7*/

            int[] masyvas1 = new int[10];
            var r0 = new Random();
            for (int i = 0; i < masyvas1.Length; i++)
            {
                var r1 = r0.Next();
                masyvas1[i] = r1;
                Console.WriteLine("indekse Nr. {0} yra skaicius: {1}",i, masyvas1[i]);

            }


        }
    }
}
