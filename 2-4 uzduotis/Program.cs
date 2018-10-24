using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 420;
            Console.WriteLine(skaicius + " " + skaicius + " " + skaicius + " " + skaicius + " " + skaicius);

            /*Susikurkite šiuos kintamuosius, saugančius informaciją apie gyvūną: pavadinimas, amžius, kailio spalva, svoris. 
            Išveskite šiuos duomenis gražiai suformatuotus vienoje eilutėje, sakinio forma. Pavyzdžiui:
            Gyvūnas - šuo(2 m.) turi rudą kailio spalvą ir sveria 1.4 kg.*/

            string pavadinimas = "Kate";
            int amzius = 4;
            string kailioSpalva = "pilka";
            var svoris = 8.6;
            Console.WriteLine("Gyvunas - " + pavadinimas + " (" + amzius + " m.) " + "turi " + kailioSpalva + " kailio spalva ir sveria " + svoris + " kg.");

        }
    }
}
