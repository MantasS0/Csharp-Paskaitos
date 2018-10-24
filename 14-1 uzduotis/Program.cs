using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_uzduotis
{
    class Program
    {
        //Parašykite metodą, kuris priimtų du skaičius ir grąžintų tą kuris yra didesnis iš jų, o jei skaičiai lygūs – grąžintų bet kurį iš jų.
        static void Main(string[] args)
        {
            var p = new Program();
            var r0 = new Random();
            Console.Write("Iveskite pirma skaiciu: ");
            var s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu: ");
            var s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Didesnis skaicius yra: " + p.Didesnis(s1,s2));


        }
        public int Didesnis(int s1, int s2)
        {
            int did1;
            if (s1>s2)
            {
                did1 = s1;
            }
            else if (s2>s1)
            {
                did1 = s2;
            }
            else
            {
                did1 = s1;
            }
            return did1;
        }

    }
}
