using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2_uzduotis
{
    class Program
    {
        /*Parašykite ir iškvieskite metodą, kuris per argumentų sąrašą priimtų vardą, pavardę, amžių ir profesiją. 
        Šis metodas, turi išvesti sakinį panaudojant gautus žodžius. Metodą kvieskite du kartus, jam duodant skirtingus duomenis.*/
        static void Main(string[] args)
        {
            var p = new Program();
            p.sakinys("Antanas", "Kindziulis", 29, "Ropiu poliruotojas");
            p.sakinys("Robertas", "Barzdyla", 42, "Vyresnysis buroku tarkuotojas");

        }
        public void sakinys(string vardas,string pavarde, int amzius, string profesija)
        {
            Console.WriteLine("{0} {1} ({2}m.) yra {3}",vardas,pavarde,amzius,profesija);
        }
    }
}
