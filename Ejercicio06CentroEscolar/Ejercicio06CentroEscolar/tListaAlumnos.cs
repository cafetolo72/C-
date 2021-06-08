using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.VisualBasic;

namespace Ejercicio06CentroEscolar
{
    public class tListaAlumnos
    {
        private ArrayList listaAlumno;

        public tListaAlumnos()
        {
            listaAlumno = new ArrayList();
        }

        public void AnyadirAlumno(string nombre, string dni, string codigo , string telefono)
        {
            tAlumno alu = new tAlumno();

            alu.Nombre = nombre;
            alu.DNI = dni;
            alu.Codigo = codigo;
            alu.Telefono = telefono;

            listaAlumno.Add(alu);
        }

        public string MostrarListaAlumnos()
        {
            string texto = "Los alumnos son : \n";
            foreach (tAlumno alu in listaAlumno)
                texto += alu.MostrarDatos();
            
            return texto;
        }

        public void OrdenarAlumnosNombre()
        {
            tAlumno alu_i, alu_j;
            for (int i = 0; i < listaAlumno.Count - 1; i++)
                for (int j = i+1; j < listaAlumno.Count; j++)
                {
                    alu_i = (tAlumno)listaAlumno[i];
                    alu_j = (tAlumno)listaAlumno[j];
                    if (string.Compare(alu_j.Nombre, alu_i.Nombre) < 0)
                    {
                        listaAlumno[i] = alu_j;
                        listaAlumno[j] = alu_i;
                    }
                }
        }

        public bool ListaVcia()
        {
            bool encontrado = true;
            if (listaAlumno.Count ==0)
                encontrado = false;
            return encontrado;
        }

        public int BuscarAlumno(string nombre)
        {
            int pos = -1;
            tAlumno alu;
            bool encontrado = false;
            int i = 0;
            while (i<listaAlumno.Count && !encontrado)
            {
                alu = (tAlumno)listaAlumno[i];
                if (alu.Nombre == nombre)
                {
                    pos = i;
                    encontrado = true;
                }else
                    i++;
            }
            return pos;
        }

        public string MostrarAlumno(string nombre)
        {
            string texto = "";
            foreach (tAlumno alu in listaAlumno)
            {
                if (alu.Nombre == nombre)
                {
                    texto = alu.MostrarDatos();
                    break;
                }
                else
                    texto = "No se encuentra el alumno en la lista \n";
            }
            return texto;
        }

        public void EliminarAlumno()
        {
            int pos;
            string nombre = Interaction.InputBox("Introduce el nombre del alumno a eliminar : ", "Gestión de Alumnos");
            pos = BuscarAlumno(nombre);
            if (pos != -1)
                listaAlumno.RemoveAt(pos);
        }

        public bool AnyadirNota(string nombre, double nota)
        {
            tAlumno alu;
            int pos;
            bool encontrado = false;
            pos = BuscarAlumno(nombre);
            if(pos >= 0)
            {
                alu = (tAlumno)listaAlumno[pos];
                alu.AnyadirNota(nota);
                encontrado = true;
            }
            return encontrado;
        }

        public bool EliminarNotaAlumno(string nombre)
        {
            tAlumno alu;
            int pos;
            bool encontrado = false;
            pos = BuscarAlumno(nombre);
            if (pos >= 0)
            {
                alu = (tAlumno)listaAlumno[pos];
                alu.EliminarNota();
                encontrado = true;
            }
            return encontrado;
        }

        public string NotaMediaMayor5()
        {
            string texto = "Alumnos con media mayor de 5 : \n";
            foreach(tAlumno alumno in listaAlumno)
            {
                if (alumno.NotaMedia() >= 5)
                    texto += alumno.MostrarDatos();
            }
            return texto;
        }

        public string NotaMediaMenor5()
        {
            string texto = "Alumnos con media menor de 5 : \n";
            foreach (tAlumno alumno in listaAlumno)
            {
                if (alumno.NotaMedia() < 5)
                    texto += alumno.MostrarDatos();
            }
            return texto;
        }

        public string MostrarPorCurso(string codigo)
        {
            string texto = "";
            foreach(tAlumno alu in listaAlumno)
            {
                if (codigo == alu.Codigo)
                    texto += alu.MostrarDatos();
            }
           
            return texto;
        }
        public bool ValidaDNI(string dni)
        {
            bool encontrado = false;
            foreach(tAlumno alu in listaAlumno)
            {
                if(alu.DNI == dni)
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

            foreach(tAlumno alu in listaAlumno)
            {
                if(telefono == alu.Telefono)
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
        }
    }
}
