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
namespace MayorMenorVector
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
                vector[i] = int.Parse(Interaction.InputBox("Introduce número : " + i));
            }
        }

        int Mayor(int[] vector)
        {
           int mayor = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if(vector[i] >= mayor)
                {
                    mayor = vector[i];
                }
            }
            return mayor;
        }
        int Menor(int [] vector)
        {
            int menor = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if(vector[i]<=menor)
                {
                    menor = vector[i];
                }
            }
            return menor;
        }
        void ContarVecesMenor(int [] vector,int menor, out int vecesmenor)
        {
            vecesmenor = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == menor)
                    vecesmenor ++;
            }
        }
        void ContarVecesMayor(int[]vector, int mayor, out int vecesmayor)
        {
            vecesmayor = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == mayor)
                    vecesmayor++;
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

        private void bLeerVector_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void bMostrarMenor_Click(object sender, EventArgs e)
        {
            int vecesmenor = 0;
            int menor = Menor(vector);
            ContarVecesMenor(vector, menor, out vecesmenor);
            MessageBox.Show("El número menor es : " + menor + "\n" + "Y se repite "+ vecesmenor + " veces");
        }

        private void bMostrarMayor_Click(object sender, EventArgs e)
        {
            int vecesmayor = 0;
            int mayor = Mayor(vector);
            ContarVecesMayor(vector, mayor, out vecesmayor);
            MessageBox.Show("El número mayor es : " + mayor + "\n" + "Y se repite " + vecesmayor + " veces");
        }

        private void bMostrarVector_Click(object sender, EventArgs e)
        {
            string texto = MostrarVector(vector);
            MessageBox.Show(texto);
        }
    }
}
