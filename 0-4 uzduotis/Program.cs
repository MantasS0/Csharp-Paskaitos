using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string suma = "";

            while (true)
            {
                Console.Write("Iveskite zodi: ");
                string z1 = Console.ReadLine();
                if (z1 == "exit")
                {
                    suma += ".";
                    break;
                }
                suma += z1 + " ";
            }
            Console.WriteLine(suma);
        }
    }
}
