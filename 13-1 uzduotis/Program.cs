using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Isvedimas("Pomidoras");
            p.Isvedimas("Agurkas");
            p.Isvedimas("Persikas");
            p.Isvedimas("Ananasas");
            p.Isvedimas("Nuka Cola");

        }
        public void Isvedimas(string zodis)
        {
            Console.WriteLine("-- {0,-10} --",zodis);
        }
    }
}
