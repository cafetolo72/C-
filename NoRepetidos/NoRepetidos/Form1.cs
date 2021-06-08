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

namespace NoRepetidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int knum = 10;
        int[] vector = new int[knum];

        bool mismoNum(int []vector, int posicion, int num)
        {
            bool encontrado = false;
            int i = 0;
            while(i<posicion && encontrado == false)
            {
                if (vector[i] == num)
                    encontrado = true;
            }
            return encontrado;
        }

        void LeerNumero(int [] vector)
        {
            bool mismo;
            int num;
            int i = 0;
            while(i<vector.Length)
            {
                 num = int.Parse(Interaction.InputBox("Introduce un número"));
                mismo = mismoNum(vector, i, num);
                if (mismo)
                    MessageBox.Show("El número introducido ya está en el vector");
                else
                {
                    vector[i] = num;
                    i++;
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
            LeerNumero(vector);
        }

        private void bMostrar_Click(object sender, EventArgs e)
        {
            string texto= MostrarVector(vector);
            MessageBox.Show(texto);
        }
    }
}
