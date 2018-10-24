using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek studentu pazymiu norite suvesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());
            var p1 = new List<int>();
            Console.WriteLine("Iveskite pazymius:");
            for (int i = 0; i < kiek; i++)
            {
                p1.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Maziausias pazymys: " + p1.Min());
            Console.WriteLine("Didziausias pazymys : " + p1.Max());
            Console.WriteLine("Pazymiu vidurkis: " + (double)p1.Average());
            var r0 = new Random();
            Console.WriteLine("Atsitiktinis skaicius: " + p1[r0.Next(kiek-1)]);
            var kiek_10 = 0;
            for (int i = 0; i < p1.Count; i++)
            {
                if (p1[i] == 10)
                {
                    kiek_10++;
                }
            }
            Console.WriteLine("{0} mokiniu gavo 10!",kiek_10);
            var kiek_4 = 0;
            for (int i = 0; i < p1.Count; i++)
            {
                if (p1[i] < 4)
                {
                    kiek_4++;
                }
            }
            Console.WriteLine("{0} mokiniu gavo maziau nei 4!", kiek_4);
        }
    }
}
