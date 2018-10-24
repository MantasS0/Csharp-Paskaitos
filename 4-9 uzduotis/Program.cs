using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pirmas automobilis:");
            Console.Write("Marke: ");
            var a1 = Console.ReadLine();
            Console.Write("modelis: ");
            var a2 = Console.ReadLine();
            Console.Write("gamybos metai: ");
            var a3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("darbinis turis: ");
            var a4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Rida: ");
            var a5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ar galioja technikine apziura? (true/false)");
            var a6 = Convert.ToBoolean(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Antras automobilis:");
            Console.Write("Marke: ");
            var b1 = Console.ReadLine();
            Console.Write("modelis: ");
            var b2 = Console.ReadLine();
            Console.Write("gamybos metai: ");
            var b3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("darbinis turis: ");
            var b4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Rida: ");
            var b5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ar galioja technikine apziura? (true/false)");
            var b6 = Convert.ToBoolean(Console.ReadLine());
            Console.Clear();

            const int MaxLength = 10;
            if (a1.Length > MaxLength) { a1 = a1.Substring(0, MaxLength); }
            if (a2.Length > MaxLength) { a2 = a2.Substring(0, MaxLength); }
            if (b1.Length > MaxLength) { b1 = b1.Substring(0, MaxLength); }
            if (b2.Length > MaxLength) { b2 = b2.Substring(0, MaxLength); }


            Console.WriteLine("+----------+----------+----------+----------+----------+----------+");
            Console.WriteLine("|Marke     |Modelis   |Metai     |Turis     |Rida      |Technikine|");
            Console.WriteLine("+----------+----------+----------+----------+----------+----------+");
            Console.WriteLine("|{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|",a1,a2,a3,a4,a5,a6);
            Console.WriteLine("+----------+----------+----------+----------+----------+----------+");
            Console.WriteLine("|{0,10}|{1,10}|{2,10}|{3,10}|{4,10}|{5,10}|", b1, b2, b3, b4, b5, b6);
            Console.WriteLine("+----------+----------+----------+----------+----------+----------+");



            /*Nuskaitykite iš konsolės duomenis apie du automobilius, kiekvieno automobilio duomenys: markė; modelis; gamybos metai; darbinis tūris; rida;
             ar yra galiojanti techninė apžiūra.
             Iš pradžių nuskaitinėkite viską kas priklauso pirmąjam automobiliui, tuomet - antrąjam. Visus nuskaitytus duomenis išveskite lentelėje.*/
        }
    }
}
