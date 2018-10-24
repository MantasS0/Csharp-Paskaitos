using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_6_uzduotis
{
    class Program
    {
        //Parašykite metodą, kuris priimtų skaičių masyvą bei grąžintų didžiausią rastą skaičių.

        static void Main(string[] args)
        {
            Random r0 = new Random();
            Program p = new Program();
            int[] mas1 = new int[50];
            for (int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = r0.Next(100);
            }
            Console.WriteLine("Sugeneruoti skaiciai:");
            foreach (var s1 in mas1)
            {
                Console.Write(s1 + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Didziausias is ju: " + p.SkMax(mas1));
        }
        public int SkMax (int[] skMas1)
        {
            var sm1 = skMas1[0];
            foreach (var s1 in skMas1)
            {
                if (sm1<s1)
                {
                    sm1 = s1;
                }
            }
            return sm1;
        }
    }
}
