using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var r0 = new Random();
            string[] vardai = { "Antanas", "Petras", "Juozas", "Martynas", "Gintaras", "Migle", "Ruta", "Laura", "Irma", "Ieva" };
            for (int i = 0; i < 5; i++)
            {
                var r1 = r0.Next(10);
                Console.WriteLine(vardai[r1]);

            }
        }
    }
}
