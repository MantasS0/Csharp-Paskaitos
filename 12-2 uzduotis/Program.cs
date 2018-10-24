using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Policininkas(); 

        }

        public void Policininkas()
        {
            var vardas = "Vytas";
            var pavarde = "Karabasas";
            var amzius = 35;
            var alga = 1235;
            var etatas = 1.25;
            var spec = "milicija";
            Console.WriteLine("{0} {1} yra {2} metu, uzdirba {3}eu dirbdamas {4} etatu. Jo specialybe yra {5}",vardas,pavarde,amzius,alga,etatas,spec);
        }

    }
}
