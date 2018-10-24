using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_9_uzduotis
{
    class Program
    {
        Random r0 = new Random();
        static void Main(string[] args)
        {
            var p = new Program();
            p.Summon1();
            p.Summon1();
            p.Summon1();

        }
        public void Summon1()
        {
            Zod1();
            Console.Write(" ");
            Skaic1();
            Console.WriteLine();

        }
        public void Zod1()
        {
            var zl1 = new List<string> { "Meh", "I must go!", "Roger, roger", "Bansaiii", "NANI!?" };
            Console.Write(zl1[r0.Next(zl1.Count)]);
        }
        public void Skaic1()
        {
            var sk1 = new List<int> {52, 420, 360, 4, 78};
            Console.Write(sk1[r0.Next(sk1.Count)]);
        }
    }
}
