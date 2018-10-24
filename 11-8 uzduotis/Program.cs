using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var zl1 = new List<string> { "Medis", "Zodynelis", "Burbulas", "As", "Nebeprisikiskekopusteliaudamiesiems" };
            var min1 = zl1[0];
            var max1 = zl1[0];
            for (int i = 0; i < zl1.Count; i++)
            {
                if (zl1[i].Length<min1.Length)
                {
                    min1 = zl1[i];
                }
                if (zl1[i].Length>max1.Length)
                {
                    max1 = zl1[i];
                }
            }
            Console.WriteLine("Trumpiausias zodis yra {0} ir susideda is {1} raidziu.", min1, min1.Length);
            Console.WriteLine("Ilgiausias zodis yra {0} ir susideda is {1} raidziu.", max1, max1.Length);


            /*Susikurti žodžių sąrašą. Rasti trumpiausią ir ilgiausią žodžius, juos išvesti į ekraną, prie kiekvieno pasakant iš kiek raidžių jis yra sudarytas.
            Tip: string kintamasis iš tiesų yra char masyvas, todėl galite naudoti zodis.Length*/

        }
    }
}
