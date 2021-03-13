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

namespace Ejercicioprueba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] vector = new int[6];

        void cambiovector(int []vector )
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if(vector[i] == (+vector[i]))
                {
                    vector[i] = int.Parse(Interaction.InputBox("Introduce un número : " + i+ "/"+ vector.Length));
                }
            }
        }
        string mostrarvector(int [] vector)
        {
            string texto = "";
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == +vector[i])
                        vector[i] = 0;
                texto += vector[i];
            }
            return texto;        }
        private void button1_Click(object sender, EventArgs e)
        {
            cambiovector(vector);
            string texto = mostrarvector(vector);
            MessageBox.Show(texto);
        


        }
    }
}
