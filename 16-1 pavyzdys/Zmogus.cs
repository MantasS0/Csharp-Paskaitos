using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_1_pavyzdys
{
    public class Zmogus
    {
        public string Vardas { get; set; }
        public int Amzius { get; set; }
        public string Profesija { get; set; }

        public Zmogus(string vardas, int amzius, string profesija)
        {
            Vardas = vardas;
            Amzius = amzius;
            Profesija = profesija;
        }
    }
}
