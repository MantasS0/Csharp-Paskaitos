using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vardai = { "Arnas", "Dyma", "Edgaras", "Lukas", "Simas", "Kostas" };

            for (int i = 0; i < vardai.Length; i++)
            {
                Console.WriteLine("{0} | {1}",i,vardai[i]);
            }



        }
    }
}
