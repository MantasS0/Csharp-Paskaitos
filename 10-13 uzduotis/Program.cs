using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pav1 = { "burokai", "morkos", "petrazoles", "bulves", "citrinos" };
            double[] kaina1 = { 1.39, 0.89, 5.19, 0.99, 6.89 };
            Console.WriteLine("--------------------------");
            for (int i = 0; i < pav1.Length; i++)
            {
                Console.WriteLine("{0,-12}| {1,3}eu",pav1[i],kaina1[i]);
                Console.WriteLine("--------------------------");


            }

        }
    }
}
