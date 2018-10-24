using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo role");

            var r1 = Console.ReadLine();
            switch (r1) {
                case "vartotojas":
                    Console.WriteLine("jus esate plebas");
                    break;
                case "moderatorius":
                    Console.WriteLine("Jus esate wannabe admin");
                    break;
                case "adminas":
                    Console.WriteLine("jus esate MASTER");
                    break;
                default:
                    Console.WriteLine("jus esate nepageidaujamas");
                    break;
                        }

        }
    }
}
