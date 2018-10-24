using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_9_uzduotis
{
    class Program
    {
        //Parašykite ir iškvieskite metodą, kuris per argumentus primtų žodžių sąrašą. Metodas turi rasti ir išvesti ilgiausią rastą žodį.
        static void Main(string[] args)
        {
            var p = new Program();
            var zl1 = new List<string> { "Hallo", "Herro", "Howdee", "Zdraztvitje", "Hey"};
            p.TrumpZod("Ilgiausias zodis sarase: ", zl1);
        }
        public void TrumpZod(string comment,List<string> zodzSarasas)
        {
            var minz1 = zodzSarasas.First();
            Console.Write(comment);
            foreach (var z1 in zodzSarasas)
            {
                if (minz1.Length<z1.Length)
                {
                    minz1 = z1;
                }
            }
            Console.Write(minz1 + ".");
            Console.WriteLine();

        }
    }
}
