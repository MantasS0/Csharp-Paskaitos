using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_10_uzduotis
{
    class Program
    {
        /*Parašykite metodą, kuris iš gauto žodžių sąrašo rastų kuris žodis yra trumpiausias. Išvestų žodžius atskirose eilutėse kaip nors išskiriant rastą trumpiausią žodį. 
        Metodą kvieskite kelis kartus su skirtingais žodžių sąrašais.*/
        static void Main(string[] args)
        {
            var p = new Program();
            var zl1 = new List<string> { "Saturn", "Lopeta", "Turgus", "Tironija", "Short" };
            var zl2 = new List<string> { "Kraken", "True", "LOOOONG", "NO", "Herro" };
            p.TrumpZod("Zodziu sarasas Nr. 1",zl1);
            p.TrumpZod("Zodziu sarasas Nr. 2", zl2);

        }
        public void TrumpZod(string comment,List<string> zodzSarasas)
        {
            Console.WriteLine(comment);
            var minz1 = zodzSarasas.First();
            foreach (var z1 in zodzSarasas)
            {
                if (minz1.Length>z1.Length)
                {
                    minz1 = z1;
                }
            }
            foreach (var z1 in zodzSarasas)
            {
                if (z1 == minz1)
                {
                    Console.WriteLine("-- " +z1+" -- (Trumpiausias zodis sarase)");
                }
                else
                {
                    Console.WriteLine(z1);
                }
            }
            Console.WriteLine("----------------------------------------------");

        }
    }
}
