using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Pirmas();
            p.Antras();
            p.Trecias();
        }
        public void Pirmas()
        {
            Console.WriteLine("-Pirmas");
        }
        public void Antras()
        {
            Console.WriteLine("-Antras");
        }
        public void Trecias()
        {
            Console.WriteLine("-Trecias");
        }
    }
}
