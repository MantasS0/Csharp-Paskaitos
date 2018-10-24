using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_17_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pav1 = { "Vilnius", "Kaunas", "Klaipeda", "Siauliai", "Panevezys" };
            int[] sk1 = { 500000, 400000, 300000, 200000, 100000 };
            for (int i = 0; i < pav1.Length; i++)
            {
                Console.WriteLine("{0} yra Lietuvos miestas, kuriame gyvena {1} gyventoju.",pav1[i],sk1[i]);

            }

        }
    }
}
