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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Naujas tekstas";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pirmas = Convert.ToInt32(textBoxPirmasSkaicius.Text);
            var antras = Convert.ToInt32(textBoxAntrasSkaicius.Text);
            var suma = pirmas + antras;
            //mbox
            MessageBox.Show(@"suma: " + suma);
            textBoxPirmasSkaicius.Text = "";
            textBoxAntrasSkaicius.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var vardas = ivedimasVardas.Text;
            var forma = new SiustasVardasForma(vardas);
            ivedimasVardas.Text = "";
            forma.ShowDialog();

        }


        private void button4_Click(object sender, EventArgs e)
        {
            using (var forma = new IvestiZmogusForma())
            {
                forma.ShowDialog();

                if (forma.DialogResult==DialogResult.OK)
                {
                    label5.Text = String.Format("{0} ({1} m.)\ndirba {2}.",
                        forma.Zmogus.Vardas,
                        forma.Zmogus.Amzius,
                        forma.Zmogus.Profesija);
                    
                }
                else
                {
                    label5.Text = "Error 404";
                }

            }
        }
    }
}
