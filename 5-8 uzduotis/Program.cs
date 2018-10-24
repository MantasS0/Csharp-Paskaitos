using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 3 egzu rezultatus");
            var k1 = Convert.ToInt32(Console.ReadLine());
            var k2 = Convert.ToInt32(Console.ReadLine());
            var k3 = Convert.ToInt32(Console.ReadLine());
            var vid1 = (k1 + k2 + k3) / 3;
            if (k1 > 10 || k2 > 10 || k3 > 10) { Console.WriteLine("Nepisk proto, seniuk..."); }
            else if ((vid1 == 10) || (vid1 == 9) || (vid1 == 8)) { Console.WriteLine("Pavarei, seni!"); }
            else if ((vid1 == 5) || (vid1 == 6) || (vid1 == 7)) { Console.WriteLine("Praslydai, seni!"); }
            else if (vid1 <5) { Console.WriteLine("Seni, kas nutiko!?"); }
            Console.WriteLine("iveskite 2 skaicius");
            var s1 = Convert.ToInt32(Console.ReadLine());
            var s2 = Convert.ToInt32(Console.ReadLine());
            if (s1 > s2 || s1 == 0) { Console.WriteLine(s1 + ">" + s2 + " arba = 0"); }
            if (s2 > s1 || s2 == 5) { Console.WriteLine(s2 + ">" + s1 + " arba = 5"); }
            if (s1 > s2 && s1 == 20) { Console.WriteLine(s1 + ">" + s2 + " ir yra = 20"); }
            if (s2 > s1 && s2 < 100) { Console.WriteLine(s2 + ">" + s1 + " ir yra < 100"); }





        }
    }
}
