using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kelione = {110,55,65,84,11,100,200};
            double avg1 = 90.6;
            double price = 1.25;
            double consumption = 11.5 / 100;
            var sum1 = kelione.Sum();
            var kainavo = sum1 * consumption * price;
            var laikas = sum1 / avg1;
            Console.WriteLine("Nuvaziuotas atstumas: " + sum1 + "km");
            Console.WriteLine("Kelione kainavo: " + kainavo + "eu");
            Console.WriteLine("Sugaistas laikas: " + laikas + "val");



        }
    }
}
