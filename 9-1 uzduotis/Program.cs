﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = 1;
            do
            {
                Console.WriteLine(s1);
                s1++;

            } while (s1%17!=0);
        }
    }
}
