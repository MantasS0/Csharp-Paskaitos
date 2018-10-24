using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_6_uzduotis
{
    class Program
    {   /*Parašykite ir iškvieskite metodą, kuris per argumentų sąrašą priimtų skaičių, kuris nurodo kiek atsitiktinių skaičių yra norima sugeneruoti. 
        Metodas turi sugeneruoti ir išvesti nurodytą kiekį atsitiktinių skaičių, kiekvieną jų atskiriant tarpu.*/
        Random r0 = new Random();
        static void Main(string[] args)
        {
            var p = new Program();
            p.RandomCount1(50);
        }
        public void RandomCount1(int kiek)
        {
            for (int i = 0; i < kiek; i++)
            {
                Console.Write(r0.Next(100) + " ");
            }
        }
    }
}
