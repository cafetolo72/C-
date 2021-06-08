using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;

namespace Ejercicio06CentroEscolar
{
    public partial class fCursos : Form
    {
        public fCursos()
        {
            InitializeComponent();
        }

        public tListaCursos listaCursos;
        public tListaAlumnos listaAlumnos;
        public tListaProfesores listaProfesores;


        public void IntroducirCurso()
        {
            tCurso curso = new tCurso();
            string codigo;
            string nombre;
            do
            {
                nombre = Interaction.InputBox("Introduce nombre del curso : ", "Gestión de Cursos");
                if (listaCursos.EncontrarCursoNombre(nombre))
                    MessageBox.Show("El nombre del curso no está disponible", "Gestión de Cursos");
            } while (listaCursos.EncontrarCursoNombre(nombre));
            
            do
            {
                codigo = Interaction.InputBox("Introduce codigo del curso : ", "Gestión de Cursos");
                if (listaCursos.EncontrarCurso(codigo))
                    MessageBox.Show("El código del curso ya está usándose","Gestión de Cursos");
            } while (listaCursos.EncontrarCurso(codigo));



            listaCursos.AnyadirCurso(nombre, codigo);
        }


        private void bAñadirCurso_Click(object sender, EventArgs e)
        {
            IntroducirCurso();
        }

        private void bEliminarCurso_Click(object sender, EventArgs e)
        {
            listaCursos.EliminarCurso();
        }

        private void bMostrarTodosCursos_Click(object sender, EventArgs e)
        {
           MessageBox.Show(listaCursos.MostrarListaCursos(),"Gestión de Cursos");
        }

        private void bMostrarTodosAlumnosCurso_Click(object sender, EventArgs e)
        {
            string codigo = Interaction.InputBox("Introduce código del curso para ver los alumnos pertenecientes : ", "Gestión de Cursos");
            bool encontrado = listaCursos.EncontrarCurso(codigo);
            if (encontrado && !listaAlumnos.ListaVcia())
                MessageBox.Show("No hay alumnos en el curso", "Gestión de Cursos");
            else
            {
                if (encontrado)
                    MessageBox.Show(listaAlumnos.MostrarPorCurso(codigo), "Gestión de Cursos");
                else
                    MessageBox.Show("No existe el curso ", "Gestión de Cursos");
            }
        }
    }
}
