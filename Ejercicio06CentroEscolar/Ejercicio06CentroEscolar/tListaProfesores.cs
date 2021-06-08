using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.VisualBasic;

namespace Ejercicio06CentroEscolar
{
    public class tListaProfesores
    {
        private ArrayList listaProfesores;

        public tListaProfesores()
        {
            listaProfesores = new ArrayList();
        }

        public void AnyadirProfesor(string nombre, string dni, string telefono, string codigo)
        {
            tProfesor prof = new tProfesor();

            prof.Nombre = nombre;
            prof.DNI = dni;
            prof.Telefono = telefono;
            prof.Codigo = codigo;

            listaProfesores.Add(prof);
        }

        public string MostrarListaProfesores()
        {
            string texto = "Los profesores son : \n";
            foreach (tProfesor prof in listaProfesores)
                texto += prof.MostrarDatos();
            return texto;
        }

        public void OrdenarProfesoresAlfabetico()
        {
            tProfesor prof_i, prof_j;
            for (int i = 0; i < listaProfesores.Count - 1; i++)
                for (int j = i+1; j < listaProfesores.Count; j++)
                {
                    prof_i = (tProfesor)listaProfesores[i];
                    prof_j = (tProfesor)listaProfesores[j];
                    if (string.Compare(prof_j.Nombre, prof_i.Nombre) < 0)
                    {
                        listaProfesores[i] = prof_j;
                        listaProfesores[j] = prof_i;
                    }
                }
        }

        public int BuscarProfesor(string nombre)
        {
            int pos = -1;
            tProfesor prof;
            bool encontrado = false;
            int i = 0;
            while (i < listaProfesores.Count && !encontrado)
            {
                prof = (tProfesor)listaProfesores[i];
                if (prof.Nombre == nombre)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }
            return pos;
        }

        public string MostrarProfesores(string nombre)
        {
            string texto = "";
            foreach (tProfesor prof in listaProfesores)
            {
                if (prof.Nombre == nombre)
                {
                    texto = prof.MostrarDatos();
                    break;
                }
                else
                    texto = "No se encuentra el profesor en la lista\n";
            }
            return texto;
        }

        public void EliminarProfesor()
        {
            int pos;
            string nombre = Interaction.InputBox("Introduce el nombre del profesor a eliminar : ","Gestión de Profesores");
            pos = BuscarProfesor(nombre);
            if (pos != -1)
                listaProfesores.RemoveAt(pos);
        }

        public bool AnyadirAsignatura(string nombre, string asignatura)
        {
            tProfesor prof;
            int pos;
            bool encontrado = false;
            pos = BuscarProfesor(nombre);
            if (pos >= 0)
            {
                prof = (tProfesor)listaProfesores[pos];
                prof.AñadirAsignatura(asignatura);
                encontrado = true;
            }
            return encontrado;
        }

        public bool EliminarAsignatura(string nombre)
        {
            tProfesor prof;
            int pos;
            bool encontrado = false;
            pos = BuscarProfesor(nombre);
            if (pos >= 0)
            {
                prof = (tProfesor)listaProfesores[pos];
                prof.EliminarAsignatura();
                encontrado = true;
            }
            return encontrado;
        }

        public string MostrarProfesoresAsignatura(string asignatura)
        {
            tProfesor prof;
            string texto = "Profesores que imparte la asignatura : " + asignatura + "\n";

            for (int i = 0; i < listaProfesores.Count; i++)
            {
                prof = (tProfesor)listaProfesores[i];
                for (int j = 0; j < prof.ListaAsignatura.Count; j++)
                {

                    if (string.Compare(asignatura, (string)prof.ListaAsignatura[i]) == 0)
                        texto += prof.MostrarDatos();
                }
            }
            return texto;
        }
                

        public bool EncontrarCodigoProfe(string codigo)
        {
            bool encontrado = false;
            foreach (tProfesor prof in listaProfesores)
            {
                if (codigo == prof.Codigo)
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
        }

        public bool ValidaDNI(string dni)
        {
            bool encontrado = false;
            foreach(tProfesor prof in listaProfesores)
            {
                if(dni == prof.DNI)
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
        }

        public bool ValidaTelefono(string telefono)
        {
            bool encontrado = false;
            foreach(tProfesor prof in listaProfesores)
            {
                if(telefono == prof.Telefono)
                {
                    encontrado = true;
                    break;
                }
            }

            return encontrado;
        }
    }
}

