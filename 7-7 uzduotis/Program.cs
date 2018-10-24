using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be daugybos veiksmo programoje, sudauginti du skaičius.

            Console.WriteLine("iveskite 2 skaicius");
            var k1 = Convert.ToInt32(Console.ReadLine());
            var k2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= k2; i++)
            {
                sum += k1; //prie sumos (0) pridedam pirma skaiciu, tada kartojam cikla, tol kol ciklas pasiekia antra skaiciu.
            }
            Console.WriteLine(sum);
        }
    }
}
