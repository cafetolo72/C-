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

namespace Temperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int knum = 20;
        int[] vector = new int[knum];

        void LeerVector(int [] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introducir temepratura : " + i));
            }
        }
        
        int VerMayor(int [] vector)
        {
            int mayor = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] >= mayor)
                    mayor = vector[i];
            }
            return mayor;
        }

        int VerMenor(int [] vector)
        {
            int menor = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] <= menor)
                    menor = vector[i];
            }
            return menor;
        }

        float CalcularMedia(int [] vector)
        {
            float media = 0;
            float suma = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
            }
            media = suma / knum;
            return media;
        }
        string MostrarVector(int [] vector)
        {
            string texto = "";
            for (int i = 0; i < vector.Length; i++)
            {
                texto += vector[i] + " ,";
            }
            return texto;
        }
        private void bIntroducir_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void bMostrarMayor_Click(object sender, EventArgs e)
        {
            int mayor=VerMayor(vector);
            MessageBox.Show("La temperatura mayor es : " + mayor);
        }

        private void bMostrarMenor_Click(object sender, EventArgs e)
        {
            int menor = VerMenor(vector);
            MessageBox.Show("La temperatura menor es : " + menor);
        }

        private void bMostrarMedia_Click(object sender, EventArgs e)
        {
            float media = CalcularMedia(vector);
            MessageBox.Show("La temperatura media es : " + media);
        }

        private void bMostrarTemperaturas_Click(object sender, EventArgs e)
        {
            string texto = MostrarVector(vector);
            MessageBox.Show(texto);
        }
    }
}
