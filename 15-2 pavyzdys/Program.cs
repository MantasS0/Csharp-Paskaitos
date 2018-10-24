using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            var knygynas = new Knygynas("Pegasas", "Akropolis", new List<Knyga>
            {
                new Knyga("Haris Poteris ir inkstu akmuo","Rowling",420,"Fantasy",16.99,5),
                new Knyga("Haris Poteris ir azkabano kotletai","Rowling",150,"Fantasy",12.89,13),
                new Knyga("Haris Poteris ir bobule","Rowling",360,"Fantasy",16.50,15),
                new Knyga("Haris Poteris ir trumpa koja","Rowling",130,"Fantasy",10.18,50),
                new Knyga("Haris Poteris ir brangus sikanas","Rowling",210,"Fantasy",15.20,5),
            });
            knygynas.Isvedimas();

        }


    }
}
