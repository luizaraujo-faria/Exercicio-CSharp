using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmo_Arrays_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Random numR = new Random();

            int[] numeros = new int[15];
            string numerosPares = " ";

            for(int i = 0; i < 15; i++){
                numeros[i] = numR.Next(1, 100);
            }
            for(int i = 0; i < 15; i++){
                if (i % 2 == 0){
                    numerosPares += numeros[i] + " ";
                }
            }
            txtvalor.Text = numerosPares;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtvalor.Clear();
        }
    }
}
