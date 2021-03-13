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
namespace Prueba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] vector = new int[10];

        void LeerVector(int[] vector)
        {
            vector[0] = int.Parse(Interaction.InputBox("Introduce un número"));
            int i=1;
            while (i <vector.Length)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce un número"+ i));
                if (vector[i] <=vector[i-1])
                {
                    MessageBox.Show("Tiene que ser mayor que el anterior");
                }
                else
                    i++;
            }
        }
         string mostrarvector(int []vector)
        {
            string texto = "";
            for (int i = 0; i < vector.Length; i++)
            {
                texto += vector[i];
            }
            return texto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeerVector(vector);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = mostrarvector(vector);
            MessageBox.Show(texto);
        }
    }
}
