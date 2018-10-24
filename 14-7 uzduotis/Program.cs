using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_7_uzduotis
{
    class Program
    {
        /*Parašykite šiuos metodus:
Priimtų skaičių masyvą, grąžintų mažiausią rastą skaičių.
Priimtų skaičių masyvą, grąžintų didžiausią rastą skaičių.
Priimtų skaičių masyvą, grąžintų sumą.
Priimtų sumą ir kiekį, grąžintų vidurkį.
Priimtų skaičių masyvą, iškviestų visus ankstesnius metodus, išvedant visus papildomus tekstus, kurie apibūdintų atliktus skaičiavimus ir gautus rezultatus.*/


        static void Main(string[] args)
        {
            Program p = new Program();
            var r0 = new Random();
            int[] masyvas1 = new int[30];
            for (int i = 0; i < masyvas1.Length; i++)
            {
                masyvas1[i] = r0.Next(100);
            }

            p.Rezultatai(masyvas1);
        }
        public int MinSk (int[] mas1)
        {
            int mins1 = mas1[0];
            foreach (var s1 in mas1)
            {
                if (mins1>s1)
                {
                    mins1 = s1;
                }
            }
            return mins1;

        }
        public int MaxSk(int[] mas1)
        {
            int maxs1 = mas1[0];
            foreach (var s1 in mas1)
            {
                if (maxs1 < s1)
                {
                    maxs1 = s1;
                }
            }
            return maxs1;

        }
        public int SumSk(int[] mas1)
        {
            int sum = 0;
            foreach (var s1 in mas1)
            {
                sum += s1;
            }
            return sum;
        }
        public double VidSk(int sum,int kiek)
        {
            double vid1 = sum / kiek;
            return vid1;
        }
        public void Rezultatai (int[] mas1)
        {
            Console.WriteLine("Maziausias skaiciu yra: {0}",MinSk(mas1));
            Console.WriteLine("Didziausias skaiciu yra: {0}", MaxSk(mas1));
            Console.WriteLine("Visu skaiciu suma yra: {0}", SumSk(mas1));
            Console.WriteLine("Visu skaiciu vidurkis yra: {0}", VidSk(SumSk(mas1),mas1.Length));

        }

    }
}
