using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite laipsnius (pagal Celsiju).");
            Double l1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pagal Farenheita yra: " + (l1*9/5+32));
            Console.WriteLine("Pagal Kelvina yra: " + (l1+273.15));

            
        }
    }
}
