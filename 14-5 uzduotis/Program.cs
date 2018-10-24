using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_5_uzduotis
{
    class Program
    {
        //Parašykite metodą, kuris iš duotų trijų skaičių parinktų bet kurį ir jį grąžintų.

        static void Main(string[] args)
        {
            var r0 = new Random();
            Program p = new Program();
            int[] skm1 = new int[3];

            for (int i = 0; i < skm1.Length; i++)
            {
                Console.WriteLine("Irasykite {0}-aji skaiciu:",i+1);
                skm1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Atsitiktinai isrinktas skaicius yra: {0}.",p.RandSk1(skm1,r0));



        }
        public int RandSk1(int[] mas1, Random r1)
        {
            var sk1 = mas1[r1.Next(mas1.Length)];
            return sk1;
        }
    }
}
