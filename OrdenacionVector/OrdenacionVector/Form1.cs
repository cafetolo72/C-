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

namespace OrdenacionVector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int knum = 10;
        int[] vector = new int[knum];

        void LeerVector(int []vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce número : " + i));
            }
        }

        int EncontrarValor(int [] vector, int valor)
        {
            int resul;
            bool encontrado = false;
            int i = 0;
            while (!encontrado && i< vector.Length)
            {
                if (vector[i] == valor)
                    encontrado = true;
                else
                    i++;
            }
            if (encontrado)
                resul = i;
            else
                resul = -1;
            return resul;
        }
        void OrdenarVector(int [] vector)
        {
            int i, j;
            int aux;
            for ( i = 0; i < vector.Length-1; i++)
            {
                for ( j = i+1; j < vector.Length; j++)
                {
                    if(vector[j] > vector[i])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;                    }
                }
            }
        }

        string MostrarVector(int []vector)
        {
            string texto = "";
            for (int i = 0; i < vector.Length; i++)
            {
                texto += vector[i] + ",";
            }
            return texto;
        }

        private void bIntroducir_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            int elemento = int.Parse(Interaction.InputBox("Introduce un elemento : "));
            int num = EncontrarValor(vector, elemento);
            if (num == -1)
                MessageBox.Show("El número introducido no está en el vector " + num);
            else
                MessageBox.Show("El número se encuentra en la posición  : " + num);
        }

        private void bOrdenar_Click(object sender, EventArgs e)
        {
            OrdenarVector(vector);
        }

        private void bMostrarV_Click(object sender, EventArgs e)
        {
            string texto = MostrarVector(vector);
            MessageBox.Show(texto);
        }
    }
}
