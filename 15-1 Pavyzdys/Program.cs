using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1_Pavyzdys
{
    class Lektuvas
    {
        public int SparnuIlgis;
        public string Pavadinimas;
        public int Vietos;
        public string Klase;
        public int VarikliuSkaicius;
        public string VariklioTipas;

        public Lektuvas()
        {

        }
        public Lektuvas(int sparnuIlgis, string pavadinimas, int vietos, string klase, int varikliuSkaicius, string variklioTipas)
        {
            SparnuIlgis = sparnuIlgis;
            Pavadinimas = pavadinimas;
            Vietos = vietos;
            Klase = klase;
            VarikliuSkaicius = varikliuSkaicius;
            VariklioTipas = variklioTipas;
        }
        public void Isvedimas()
        {
            Console.WriteLine("Lektuvas {0}, jo vietu skaicius yra {1}, sparnu ilgis {2}. Lektuvo klase {3}, variklio tipas {4}, varikliu skaicius {5}.",Pavadinimas,Vietos,SparnuIlgis,Klase,VariklioTipas,VarikliuSkaicius);
        }
        public void Sparnas()
        {
            Console.WriteLine("Vieno sparno ilgis: " + SparnuIlgis/2);
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            var lektuvas1 = new Lektuvas();
            var lektuvas2 = new Lektuvas();

            lektuvas1.Pavadinimas = "Boyeing";
            lektuvas1.Vietos = 300;
            lektuvas1.Klase = "Tarpatlantinis";
            lektuvas1.SparnuIlgis = 30;
            lektuvas1.VarikliuSkaicius = 6;
            lektuvas1.VariklioTipas = "Turbininis";

            lektuvas2.Pavadinimas = "MIG-22";
            lektuvas2.Vietos = 2;
            lektuvas2.Klase = "Naikintuvas";
            lektuvas2.SparnuIlgis = 12;
            lektuvas2.VarikliuSkaicius = 2;
            lektuvas2.VariklioTipas = "Reaktyvinis";

            //Console.WriteLine("Lektuvas {0}, jo vietu skaicius yra {1}, sparnu ilgis {2}. Lektuvo klase {3}, variklio tipas {4}, varikliu skaicius {5}.",lektuvas1.Pavadinimas,lektuvas1.Vietos,lektuvas1.SparnuIlgis,lektuvas1.Klase,lektuvas1.VariklioTipas,lektuvas1.VarikliuSkaicius);
            lektuvas1.Isvedimas();
            lektuvas1.Sparnas();
            lektuvas2.Isvedimas();
            lektuvas2.Sparnas();

            var lektuvas3 = new Lektuvas(15, "Rapptor", 1, "Typhoon", 4, "Turbo reactor");
            lektuvas3.Isvedimas();

        }
    }
}
