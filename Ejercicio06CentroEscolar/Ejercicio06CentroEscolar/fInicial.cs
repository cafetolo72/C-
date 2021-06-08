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
    public partial class fInicial : Form
    {
        public fInicial()
        {
            InitializeComponent();
        }

        // Creamos la lista de cursos.
        tListaCursos listaCursos = new tListaCursos();
        tListaProfesores listaProfesores = new tListaProfesores();
        tListaAlumnos listaAlumnos = new tListaAlumnos();

        private void bCursos_Click(object sender, EventArgs e)
        {
            fCursos fCur = new fCursos();
            // Aquí le pasamos la lista de cursos para poder utilizarla luego en el formulario de cursos.
            fCur.listaCursos = listaCursos;
            fCur.listaAlumnos = listaAlumnos;
            fCur.listaProfesores = listaProfesores;
            //Pasar formulario a otro
            fCur.ShowDialog();
        }

        private void bGestionAlumnos_Click(object sender, EventArgs e) 
        {
            fAlumnos fAlu = new fAlumnos();

            fAlu.listaCursos = listaCursos;
            fAlu.listaAlumnos = listaAlumnos;
            fAlu.listaProfesores = listaProfesores;

            fAlu.ShowDialog();
        }
            
        private void bGestionProfesores_Click(object sender, EventArgs e)
        {
            fProfesores fProf = new fProfesores();
            
            fProf.listaProfesores = listaProfesores;
            fProf.listaCursos = listaCursos;
            fProf.listaAlumnos = listaAlumnos;

            fProf.ShowDialog();
        }
    }
}
