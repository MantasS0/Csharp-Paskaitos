﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] medziai = { "azuolas", "liepa", "berzas", "pusis", "egle", "uosis", "klevas" };
            for (int i = 0; i < medziai.Length; i++)
            {
                Console.WriteLine("-{0};",medziai[i]);
            }


        }
    }
}
