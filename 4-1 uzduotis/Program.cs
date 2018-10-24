using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var tekstas1 = Console.ReadLine();
            
            Console.WriteLine(tekstas1 + " " + tekstas1);

            Console.Write("Vardas: ");
            var line1 = Console.ReadLine();
            Console.Write("Pavarde: ");
            var line2 = Console.ReadLine();
            Console.WriteLine("Labas, {0} {1}", line1, line2);

            Console.Write("Gyvuno pavadinimas: ");
            var pav1 = Console.ReadLine();
            Console.Write("Gyvuno seima: ");
            var seima1 = Console.ReadLine();
            Console.Write("Regionas kuriame sutinkamas: ");
            var regionas1 = Console.ReadLine();
            Console.WriteLine("Gyvunas {0} prikauso {1} seimai ir yra randamas {2} regione.", pav1, seima1,regionas1);





            /*Iš konsolės nuskaitykite vieną norimą žodį. Jį išveskite du kartus, atskiriant tarpu.
Iš konsolės nuskaitykite savo vardą ir pavardę. Išveskite nuskaitytą informaciją pasisveikinime, pavyzdžiui:
Labas, Tomas Tomauskas.
Iš konsolės nuskaitykite šią informaciją apie gyvūną: pavadinimas, šeima, regionas kuriame galima sutikti. Išveskite nuskaitytą informaciją sakinio pavidalu. Pavyzdžiui:
Gyvūnas liūtas priklauso katinų šeimai ir yra randamas afrikoje.*/


        }
    }
}
