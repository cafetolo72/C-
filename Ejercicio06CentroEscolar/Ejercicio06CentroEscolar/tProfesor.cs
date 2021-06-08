using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio06CentroEscolar
{
    public class tProfesor
    {
        private string mNombre;
        private string mDNI;
        private string mCodigo;
        private string mTelefono;
        private ArrayList mListaAsiganturas;

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

        public string Codigo
        {
            get { return mCodigo; }
            set { mCodigo = value; }
        }

        public string Telefono
        {
            get { return mTelefono; }
            set { mTelefono = value; }
        }

        public tProfesor()
        {
            mNombre = "";
            mDNI = "";
            mCodigo = "";
            mTelefono = "";
            mListaAsiganturas = new ArrayList();
        }

        public ArrayList ListaAsignatura
        {
            get { return mListaAsiganturas; }
        }
        
        public void AñadirAsignatura(string asignatura)
        {
            mListaAsiganturas.Add(asignatura);
        }

        public string MostrarAsignaturas()
        {
            string texto;
            int i;
            if (mListaAsiganturas.Count >0)
            {
                texto = "Las asignaturas son : ";
                for (i = 0; i < mListaAsiganturas.Count; i++)
                    texto += mListaAsiganturas[i] + ", ";
                texto += "\n";
            }
            else
                texto = "No tiene asignaturas";
            return texto;
        }

        public void EliminarAsignatura()
        {
            mListaAsiganturas.Clear();
        }

        public string MostrarDatos()
        {
            string texto = "Datos : \n";
            texto += "Nombre : " + mNombre + "\n";
            texto += "DNI : " + mDNI + "\n";
            texto += "Teléfono : " + mTelefono + "\n";
            texto += "Codigo curso : " + mCodigo + "\n";
            texto += MostrarAsignaturas() +"\n";

            return texto;
        }
    }
}
