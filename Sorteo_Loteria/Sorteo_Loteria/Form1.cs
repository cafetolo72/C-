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
using System.Collections;

namespace Sorteo_Loteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList lista1 = new ArrayList();
        ArrayList lista2 = new ArrayList();

        void IntroducirNumero(ArrayList lista)
        {
            int num = 1;
            int i = 1;
            while (i <= 6)
            {
                num = int.Parse(Interaction.InputBox("Introduce un número entre el 1 y 49 :  " + i + " de 6"));
                if (num >= 1 && num <= 49)
                {
                    if (!(lista.Contains(num)))
                    {
                        lista.Add(num);
                        i++;
                    }
                    else
                    {
                        MessageBox.Show("Introduce un número no repetido");
                    }
                }
                else
                {
                    MessageBox.Show("Debes introducir un número entre el 1 y 49");
                }
            }
        }
        void RealizarSorteo(ArrayList lista2)
        {
            int cont, num;
            Random r = new Random();
            cont = 0;
            while (cont < 6)
            {
                num = r.Next(1, 50);
                if (!(lista2.Contains(num)))
                {
                    lista2.Add(num);
                    cont++;
                }
            }
        }
        string Aciertos(ArrayList lista1, ArrayList lista2)
        {
            string texto = "";
            int aciertos = 0;
            foreach (int num in lista2)
            {
                if (lista1.Contains(num))
                {
                    aciertos++;
                    texto += num + " ,";
                }
            }
            if (aciertos >= 1)
                texto = "Has acertado " + aciertos + "números : " + texto;
            else
                texto = "Lo siento no ha habido aciertos";
            return texto;
        }
        string MostrarLista(ArrayList lista1)
        {
            string texto = "";
            foreach (int num in lista1)
            {
                texto += num + ",";
            }
            return texto;
        }
        string MostrarListas(ArrayList lista1, ArrayList lista2)
        {
            string texto = "Números del usurio : " + MostrarLista(lista1) + "\n";
            texto += "Números de la máquina : " + MostrarLista(lista2);
            return texto;
        }
        private void bIntroducirN_Click(object sender, EventArgs e)
        {
            IntroducirNumero(lista1);
        }

        private void bMostrarR_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MostrarListas(lista1, lista2));
        }

        private void bComparar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Aciertos(lista1, lista2));
        }

        private void bComenzarS_Click(object sender, EventArgs e)
        {
            RealizarSorteo(lista2);
        }
    }
}
