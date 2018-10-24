using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2_uzduotis
{
    class Program
    {
        //Parašykite metodą, kuris priimtų žodžių masyvą. Metodas turi grąžinti trumpiausią žodį.

        static void Main(string[] args)
        {
            var p = new Program();
            string[] mas1 = { "Labas", "as", "Kebabas", "o", "tu", "sriuba" };
            var minz = p.TrumpZ(mas1);
            Console.WriteLine("Trumpiausias zodis: " + minz);

        }
        public string TrumpZ(string[] zodzMas)
        {
            string trumpzod = zodzMas[0];
            foreach (var z1 in zodzMas)
            {
                if (trumpzod.Length>z1.Length)
                {
                    trumpzod = z1;
                }
            }
            return trumpzod;
        }



    }
}
