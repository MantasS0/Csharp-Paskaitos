using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var mod1 = new List<string> ();
            mod1.Add("w208");
            mod1.Add("w209");
            mod1.Add("w210");
            mod1.Add("w211");
            mod1.Add("w201");
            mod1.Add("w203");
            foreach (var m1 in mod1)
            {
                Console.Write(m1 + ",");
            }

        }
    }
}
