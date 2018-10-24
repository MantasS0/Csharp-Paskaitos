using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_3_uzduotis
{
    class Program
    {
        /*Sukurkite 4 skirtingus metodus sumos, skirtumo, sandaugos bei dalmens radimui. Kiekvienas iš jų turi priimti po du sveikuosius skaičius, 
         turi išvesti kokį veiksmą ir su kokiais skaičiais atliko, bei atsakymą (pvz.: 5 + 7 = 12). 
         Iškvieskite šiuos metodus bent po vieną kartą, duodant skirtingus arba tuos pačius skaičius.*/
        
        static void Main(string[] args)
        {
            Random r0 = new Random();
            var p = new Program();
            p.Sudetis(r0.Next(100), r0.Next(100));
            p.Atimtis(r0.Next(100), r0.Next(100));
            p.Daugyba(r0.Next(100), r0.Next(100));
            p.Dalyba(r0.Next(100), r0.Next(100));
        }
        public void Sudetis(int a,int b)
        {
            Console.WriteLine("{0} + {1} = {2}",a,b,a+b);
        }
        public void Atimtis(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        public void Daugyba(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        public void Dalyba(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, (double)a / b);
        }
    }
}
