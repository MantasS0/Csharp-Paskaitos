using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vardas: ");
            Console.ReadLine();
            Console.Write("pavarde: ");
            Console.ReadLine();
            Console.Write("grupes kodas: ");
            Console.ReadLine();
            Console.Write("aukstosios mokyklos pavadinimas: ");
            Console.ReadLine();
            Console.WriteLine("iveskite 3 pazymius");
            var s1 = Convert.ToDouble(Console.ReadLine());
            var s2 = Convert.ToDouble(Console.ReadLine());
            var s3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Siu pazymiu vidurkis yra: )"+(s1+s2+s3)/3);
            Console.WriteLine();

            

            /*Nuskaitykite iš konsolės šiuos duomenis apie studentą: vardas; pavardė; grupės kodas; aukštosios mokyklos pavadinimas; 
             norimą kiekį pažymių (pavyzdžiui 3 pažymius). Raskite vidurkį iš turimų pažymių. Visą informaciją norima forma išveskite ekrane.*/

        }
    }
}
