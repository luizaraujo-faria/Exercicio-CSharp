using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmo_arrays_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public double[] notas = new double[30];
        public double somaNota = 0,  media;


        private void btncalcular_Click(object sender, EventArgs e)
        {

                media = somaNota / 30;

                txtmedia.Text = media.ToString();

        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 30; i++)
            {
                    notas[i] = Convert.ToDouble(txtnotas.Text);
                    somaNota += notas[i];
                    txtnotas.Clear();
                    txtnotas.Focus();
                    break;

            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnotas.Clear();
            txtmedia.Clear();
            somaNota = 0;
        }
    }
}
