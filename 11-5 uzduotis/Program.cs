using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek vardu norite ivesti?");
            int kiek = Convert.ToInt32(Console.ReadLine());
            var v1 = new List<string>();
            for (int i = 0; i < kiek; i++)
            {
                v1.Add(Console.ReadLine());
            }
            Console.WriteLine("Jusu pirmas ir paskutinis ivesti vardai: {0} ir {1}",v1.First(),v1.Last());

        }
    }
}
