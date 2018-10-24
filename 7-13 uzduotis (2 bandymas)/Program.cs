using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_13_uzduotis__2_bandymas_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*(Pažengusiems) Parašyti for ciklą, kuris išvestų norimą kiekį fibonačiaus skaičių į ekraną. 
            * Fibonačiaus sekoje kiekvienas skaičius yra lygus prieš jį ėjusių dviejų skaičių sumai: 1, 1, 2, 3, 5, 8, 13, 21… Pagalba kaip atlikti užduotį:
Susikurkite tris sveikųjų skaičių kintamuosius. Pirmi du kintamieji saugos paskutinius du skaičius. Trečiasis bus šių pirmų dviejų skaičių suma.
Pirmus du skaičius išveskite ne cikle, o prieš jį ir ciklą pradėkite vykdyti nuo 2, o ne nuo 0.
Kiekvieno ciklo metu turite perskaičiuot trečiąjį skaičių (pirmų dviejų skaičių sudėtis), 
tuomet pirmojo skaičiaus reikšmę pakeisti į tokią kokia yra saugoma antrąjame, o antrojo kintamojo reikšmę - į trečiojo. Išvesti į ekraną trečią skaičių.
*/


            Console.WriteLine("Irasykine norima skaiciu fibonaciaus skaiciu :D");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            uint s1 = 1;
            uint s2 = 1;
            uint s3 = 2;
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            for (uint i = 1; i <= skaicius; s3 = s1 + s2)
            {
                s1 = s2;
                s2 = s3;
                Console.WriteLine(s3);
                i++;
            }
            
        }
    }
}
