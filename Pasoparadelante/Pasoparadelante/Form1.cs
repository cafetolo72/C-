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

namespace Pasoparadelante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int knum = 10;
        int[] vector = new int[knum];
        int[] vector2 = new int [knum];

        void LeerVector(int [] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce un número : " + i));
            }
        }
        
        void CambioValores(ref int [] vector, ref int [] vector2)
        {
            vector2[0] = vector[knum - 1];
            int i =0;
            int j = 1;
            while (i < vector.Length-1)
            {
                vector2[j] = vector[i];
                i++;
                j++;
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
        string MostrarVectores(int[] vector, int[] vector2)
        {
            string texto = "Primer Vector : ";
            texto += MostrarVector(vector) + "\n";
            texto += "Segundo vector : " + MostrarVector(vector2);
            return texto;
        }

        private void bLeerVector_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void bPasoValores_Click(object sender, EventArgs e)
        {
            CambioValores(ref vector, ref vector2);
        }

        private void bMostrarVectores_Click(object sender, EventArgs e)
        {
            string texto = MostrarVectores(vector, vector2);
            MessageBox.Show(texto);
        }
    }
}
