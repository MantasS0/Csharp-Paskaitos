using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_8_uzduotis
{
    class Program
    {
        //Parašykite ir iškvieskite metodą, kuris per argumentus priimtų skaičių sąrašą. Metodas turi rasti ir išvesti mažiausią rastą skaičių.

        static void Main(string[] args)
        {
            var p = new Program();
            var skl1 = new List<int> { 5, 80, 67, 844, 23, 2, 887, -5, -7 };
            p.MinSkaic1("Maziausias skaicius sarase: ",skl1);

        }
        public void MinSkaic1 (string comment, List<int> skaiciuList)
        {
            var minSk = skaiciuList.First();
            Console.Write(comment);
            for (int i = 0; i < skaiciuList.Count; i++)
            {
                if (minSk>skaiciuList[i])
                {
                    minSk = skaiciuList[i];
                }
            }
            Console.Write(minSk);
            Console.WriteLine();
        }
    }
}
