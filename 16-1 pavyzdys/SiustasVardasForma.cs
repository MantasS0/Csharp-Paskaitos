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
    public partial class SiustasVardasForma : Form
    {
        public SiustasVardasForma(string vardas)
        {
            InitializeComponent();
            label1.Text = "Labas, " + vardas;
        }
    }
}
