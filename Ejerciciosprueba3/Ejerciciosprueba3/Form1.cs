using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejerciciosprueba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] vector = new int[10];

        void LeerVector(int [] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce nota" + i ));
            }
        }

        string MostrarVector(int [] vector)
        {
            string texto = "";

            for (int i = 0; i < vector.Length; i++)
            {
                texto += vector[i] + ",";
            }
            return texto;
        }
        float MediaVector(int [] vector)
        {
            float media = 0;
            float suma = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
            }
            media = suma / vector.Length; 
            return media;
        }



        private void bLeerVector_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void bMostrarVector_Click(object sender, EventArgs e)
        {
            string texto = MostrarVector(vector);
            MessageBox.Show(texto);
        }

        private void bMostrarMedia_Click(object sender, EventArgs e)
        {
            float media=MediaVector(vector);
            MessageBox.Show("La media es : " + media);
        }
    }
}
