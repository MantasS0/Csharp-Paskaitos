using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var r0 = new Random();
            var sl1 = new List<int> ();
            for (int i = 0; i < 100; i++)
            {
                sl1.Add(r0.Next(100));
            }
            foreach (var s1 in sl1)
            {
                Console.Write(s1 + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Paskutinis skaicius: " + sl1.Last());
            Console.WriteLine("Atsitiktinis skaicius: " + sl1[r0.Next(100)]);
            Console.WriteLine("Maziausias skaicius: " + sl1.Min());
            Console.WriteLine("Didziausias skaicius: " + sl1.Max());
            Console.WriteLine("Skaiciu suma: " + sl1.Sum());
            Console.WriteLine("Vidurkis: : " + sl1.Average());
            var kieklyg = 0;
            foreach (var s1 in sl1)
            {
                if (s1%2==0)
                {
                    kieklyg++;
                }
            }
            Console.WriteLine("Lyginiu skaiciu skaicius sarase: " + kieklyg);
        }
    }
}
