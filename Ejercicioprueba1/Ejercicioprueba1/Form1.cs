using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicioprueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int EncontrarMenor(int num1, int num2)
        {
            int menor = 0;

            if (num1 < num2)
                menor = num1;
            else
                menor = num2;

            return menor;
        }

        int MaximoComunDivisor(int num1, int num2)
        {
            int mcd = 1, menor;
            menor = EncontrarMenor(num1, num2);
            for (int i = 0; i < menor; i++)
            {
                if(num1%i==0 && num2 % i == 0)
                {
                    mcd = i;
                }
            }
            return mcd;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = int.Parse(tNum1.Text);
            num2 = int.Parse(tNum2.Text);
            MessageBox.Show("El máximo común divisor es : " + EncontrarMenor(num1, num2));
        }
    }
}
