using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.VisualBasic;

namespace Ejercicio06CentroEscolar
{
    public class tCurso
    {
        private string mNombre;
        private string mCodigo;

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public string Codigo
        {
            get { return mCodigo; }
            set { mCodigo = value; }
        }

        public tCurso()
        {
            mNombre = "";
            mCodigo = "";
        }

        public string MostrarDatos()
        {
            string texto = "Cursos actuales :\n";
            texto += "Nombre : "+ mNombre + "\n";
            texto += "Codigo : " + mCodigo + "\n";

            return texto;
        }
    }
}
