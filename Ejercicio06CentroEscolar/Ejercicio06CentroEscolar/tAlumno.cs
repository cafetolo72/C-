using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio06CentroEscolar
{
    public class tAlumno
    {
        private string mNombre;
        private string mDNI;
        private string mTelefono;
        private string mCodigo;
        private ArrayList mListaNotas;

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public string DNI
        {
            get { return mDNI; }
            set { mDNI = value; }
        }

        public string Telefono
        {
            get { return mTelefono; }
            set { mTelefono = value; }
        }

        public string Codigo
        {
            get { return mCodigo; }
            set { mCodigo = value; }
        }

        public tAlumno()
        {
            mNombre = "";
            mDNI = "";
            mTelefono = "";
            mCodigo = "";
            mListaNotas = new ArrayList();
        }

        public void AnyadirNota(double nota)
        {
            if (nota >=0 && nota <=10)
                mListaNotas.Add(nota);
        }

        public string MostrarNotas()
        {
            string texto;
            int i;

            if (mListaNotas.Count > 0)
            {
                texto = "Notas : ";
                for (i = 0; i < mListaNotas.Count; i++)
                    texto += mListaNotas[i] + ", ";
                texto += "\n";
            }
            else
                texto = "Alumno sin notas \n";
            return texto;
        }

        public double NotaMedia()
        {
            double nota = 0;
            for (int i = 0; i < mListaNotas.Count; i++)
                nota += (double)mListaNotas[i];

            nota = nota / (double)mListaNotas.Count;
            
            return nota;
        }

        public void EliminarNota()
        {
            mListaNotas.Clear();
        }

        public string MostrarDatos()
        {
            string texto = "Datos : \n";
            texto += "Nombre : " + mNombre + "\n";
            texto += "DNI : " + mDNI + "\n";
            texto += "Codigo curso : " + mCodigo + "\n";
            texto += "Teléfono : " + mTelefono + "\n";
            texto += MostrarNotas();

            return texto;
        }
    }
}
