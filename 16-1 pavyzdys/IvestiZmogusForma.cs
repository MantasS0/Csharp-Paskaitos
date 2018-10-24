using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_1_pavyzdys
{
    public partial class IvestiZmogusForma : Form
    {
        public Zmogus Zmogus { get; set; }

        public IvestiZmogusForma()
        {
            InitializeComponent();
        }

        private void buttonGerai_Click(object sender, EventArgs e)
        {
            var vardas = textBoxVardas.Text;
            var amzius = Convert.ToInt32(textBoxAmzius.Text);
            var profesija = textBoxProfesija.Text;
            Zmogus = new Zmogus(vardas, amzius, profesija);
        }
    }
}
