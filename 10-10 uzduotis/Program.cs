using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas1 = { 1, 5, 9, 8, 7, 8, 5 };
            int[] mas2 = { 2, 8, 9, 4, 6, 8, 3 };
            Console.WriteLine("Pirmo masyvo suma: " + mas1.Sum());
            Console.WriteLine("Antro masyvo suma: " + mas2.Sum());
            Console.WriteLine("---------------------");
            Console.WriteLine("Pirmo masyvo vidurkis yra: " + mas1.Average());
            Console.WriteLine("Antro masyvo vidurkis yra: " + mas2.Average());
            Double[] average1 = new Double[2];
            average1[0] = (double)mas1.Average();
            average1[1] = mas2.Average();
            Console.WriteLine("Is abieju masyvu didziausias vidurkis yra: " + average1.Max());






        }
    }
}
