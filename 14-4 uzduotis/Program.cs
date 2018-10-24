using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_4_uzduotis
{
    class Program
    {

        //Parašykite metodą, kuris priimtų žodžių masyvą. Šis metodas, turi sujungti visus šiuos žodžius į vieną bendrą string kintamąjį ir grąžinti jį.
        static void Main(string[] args)
        {
            var p = new Program();
            string[] zodz1 = { "Alfa", "Beta", "Gamma", "Omega", "Delta", "Zeta" };
            Console.WriteLine(p.ZodziuString(zodz1));

        }
        public string ZodziuString(string[] mas1)
        {
            string ilgas1 ="";
            foreach (var i in mas1)
            {
                ilgas1 += i + " ";
            }
            return ilgas1;
        }

    }
}
