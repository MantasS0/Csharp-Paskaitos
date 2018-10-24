using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_2_pavyzdys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iseitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nuskaitytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            OpenFileDialog failas = new OpenFileDialog();
            failas.Filter = "CSV failas|*.csv";
            failas.Title = "CSV failas";

            
            if (failas.ShowDialog() == DialogResult.OK)
            {
                
                //MessageBox.Show(failas.FileName);

                //cia visa nuskaitymo logika

                dataGridView1.DataSource = pasirinktasSarasas;
            }
        }
    }
}
