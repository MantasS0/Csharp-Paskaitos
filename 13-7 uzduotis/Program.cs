using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_7_uzduotis
{
    class Program
    {
        /*Parašykite ir iškvieskite metodą, kuris priimtų šiuos skaičius: kiek – kiek atsitiktinių skaičių norima sugeneruoti; 
         minimumas – mažiausia galima atsitiktinio skaičiaus reikšmė; maksimumas – didžiausia galima atsitiktinio skaičiaus reikšmė. 
         Metodas turi sugeneruoti nurodytą kiekį atsitiktinių skaičių, atsižvelgdamas į generuojamų skaičių min ir max reikšmes. 
         Šiuos skaičius jis turi išvesti atskiriant kiekvieną skaičių kableliu.*/
        Random r1 = new Random();

        static void Main(string[] args)
        {
            Random r0 = new Random();
            var p = new Program();
            p.Random1(r0.Next(30), r0.Next(50), r0.Next(50,100));


        }
        public void Random1(int kiek,int min, int max)
        {
            for (int i = 0; i < kiek; i++)
            {
                Console.Write(r1.Next(min,max) + ",");
            }
        }

    }
}
