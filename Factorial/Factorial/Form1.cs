using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int CalcularFactorial(int num)
        {
            int fact = 0;
            for (int i = 1; i <=num; i++)
            {
                fact *= i;
            }
            return fact;
        }
        string MostrarFactorial(int num)
        {
            string texto = "";
            for (int i = num; i > 0; i++)
            {
                texto += i + "*"; 
            }
            texto = num + "! = " + texto;
            return texto;
        }

        private void bNumero_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tNum.Text);
            string texto = MostrarFactorial(num);
            int fact =CalcularFactorial(num);
            MessageBox.Show(texto + "=" +fact);
        }

       
        
    }
}
