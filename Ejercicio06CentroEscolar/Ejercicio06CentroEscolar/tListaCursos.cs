using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Microsoft.VisualBasic;

namespace Ejercicio06CentroEscolar
{
    public class tListaCursos
    {
        private ArrayList listaCursos;

        public tListaCursos()
        {
            listaCursos = new ArrayList();
        }

        public void AnyadirCurso(string nombre, string codigo)
        {
            tCurso curso = new tCurso();

            curso.Nombre = nombre;
            curso.Codigo = codigo;

            listaCursos.Add(curso);
        }

        public string MostrarListaCursos()
        {
            string texto = "Lista de cursos :";

            foreach(tCurso curso  in listaCursos)
                texto += curso.MostrarDatos();
            
            return texto;
        }

        public int BuscarCurso(string codigo)
        {
            int pos = -1;
            tCurso curso;
            bool encontrado = false;
            int i = 0;
            while(i< listaCursos.Count && !encontrado)
            {
                curso = (tCurso)listaCursos[i];
                if (curso.Codigo == codigo)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }
            return pos;
        }

        public void EliminarCurso()
        {
            int pos;
            string codigo = Interaction.InputBox("Introduce código del curso a eliminar :", "Gestión de Cursos");
            pos = BuscarCurso(codigo);
            if (pos != -1)
                listaCursos.RemoveAt(pos);
        }

        public bool EncontrarCurso(string codigo)
        {
           bool encontrado = false;
           foreach(tCurso cur in listaCursos) 
            {
                if (codigo == cur.Codigo)
                {
                    encontrado = true;
                    break;
                }
           }
            return encontrado;
        }

        public bool EncontrarCursoNombre(string nombre)
        {
            bool encontrado = false;

            foreach(tCurso cur in listaCursos)
            {
                if(nombre == cur.Nombre)
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
        }
    }
}
