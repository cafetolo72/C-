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

namespace EjerciciosPrueba5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int knum = 10;
        int[] vector = new int[knum];
        int[] vector2 = new int[knum];

        void LeerVector(int [] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce un número : " + i));
            }
        }
        void PasarValores(ref int[] vector,ref int [] vector2)
        {
            int j = 0;
            int i = knum - 1;
            while (j < vector.Length)
            {
                vector2[j] = vector[i];
                j++;
                i--;
            }
        }
        string MostrarVector(int[] vector)
        {
            string texto = "";
            for (int i = 0; i < vector.Length; i++)
            {
                texto += vector[i] + ",";
            }
            return texto;
        }
        string MostrarVectores(int [] vector, int[] vector2)
        {
            string texto = "";
            texto ="Primer vector : " + MostrarVector(vector) + "\n";
            texto += "Segundo Vector : " + MostrarVector(vector2);
            return texto;

        }
        private void bIntroducirVector_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void bPasarVector_Click(object sender, EventArgs e)
        {
            PasarValores(ref vector, ref vector2);
        }

        private void bMostrarVectores_Click(object sender, EventArgs e)
        {
            string texto = MostrarVectores(vector, vector2);
            MessageBox.Show(texto);
        }
    }
}
