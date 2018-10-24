using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_5_uzduotis
{
    class Program
    {
        /*Sukurkite šiuos metodus:
        Kuris priimtų vardą, pavardę, akademinės grupės kodą. Metodas turi išvesti gautą informaciją.
        Kuris priimtų tris skaičius (pažymius). Metodas turi suskaičiuoti ir išvesti pažymių vidurkį.
        Apjungiantį metodą, kuris per argumentų sąrašą priimtų vardą, pavardę, akademinės grupės kodą bei tris skaičius (pažymius). 
        Jame iškvieskite kitus du, prieš tai sukurtus metodus. Šį pagrindinį metodą kvieskite bent 2 kartus su skirtingais duomenimis.*/


        static void Main(string[] args)
        {
            var p = new Program();
            p.Info("Kastytis", "Brazauskas", "BK-0/1", 4, 5, 5);
            p.Info("Patricija", "Leo", "KK-9/2", 9, 10, 8);


        }
        public void Info(string vardas, string pavarde, string grupe, int a, int b, int c)
        {
            Stud1(vardas, pavarde, grupe);
            Pazym1(a, b, c);
            Console.WriteLine("-------------------------------------------");
        }
        public void Stud1(string vardas,string pavarde, string grupe)
        {
            Console.WriteLine("{0} {1} ({2} gr.)", vardas,pavarde,grupe);
        }
        public void Pazym1(int a, int b, int c)
        {
            Console.WriteLine("Pazymiai: {0}, {1}, {2}.\nVidurkis: {3}",a,b,c,(double)(a+b+c)/3);
        }


    }
}
