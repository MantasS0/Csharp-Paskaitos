using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Ivedimas();

        }
        public void Ivedimas()
        {
            Console.Write("Iveskite savo varda: ");
            var v1 = Console.ReadLine();
            Console.WriteLine("Sveikas, "+v1+".");
        }

    }
}
