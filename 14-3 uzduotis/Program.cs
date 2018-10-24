using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_3_uzduotis
{
    class Program
    {
        //Parašykite metodą, kuris sugeneruotų ir grąžintų 100 atsitiktinių skaičių.
        static void Main(string[] args)
        {
            var p = new Program();
            var r0 = new Random();
            var sugeneruoti = p.RandMas1(r0);
            p.Spausdinti(sugeneruoti);


        }
        public List<int> RandMas1(Random rand)
        {
            var skaiciai = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                skaiciai.Add(rand.Next(100));

            }
            return skaiciai;
        }
        public void Spausdinti (List<int> skaiciai)
        {
            foreach (var s1 in skaiciai)
            {
                Console.Write(s1 + " ");
            }
            Console.WriteLine();
        }
    }
}
