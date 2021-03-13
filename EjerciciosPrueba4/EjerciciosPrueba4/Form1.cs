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

namespace EjerciciosPrueba4
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
                vector[i] = int.Parse(Interaction.InputBox("Introduce números : " + i));
            }
        }

        void CambioVector(ref int [] vector)
        {
            int i,j;
            int cont = 0;
            for ( i = 0; i < vector.Length-1; i++)
            {
                if(vector[i]!= -1)
                    for (j = i+1; j < vector.Length; j++)
                    {
                        if (vector[j] == vector[i])
                        {
                            vector[j] = -1;
                            cont++;
                        }
                    }
            }
        }
        string MostrarVector(int [] vector)
        {
            string texto = "";
            for (int i = 0; i < vector.Length; i++)
            {
                texto += vector[i]+ ",";
            }
            return texto;
        }
        private void bLeerVector_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void bCambiar_Click(object sender, EventArgs e)
        {
            CambioVector(ref vector);
        }

        private void bMostrarVector_Click(object sender, EventArgs e)
        {
            string texto= MostrarVector(vector);
            MessageBox.Show(texto);
        
        }
    }
}
