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

namespace Ejercicio06CentroEscolar
{
    public partial class fAlumnos : Form
    {
        public fAlumnos()
        {
            InitializeComponent();
        }
        public tListaCursos listaCursos;
        public tListaAlumnos listaAlumnos;
        public tListaProfesores listaProfesores;

        public void IntroducirAlumno()
        {
            tAlumno alu = new tAlumno();
            string codigo , dni , telefono, nom, cod;
            DialogResult seguir;

            string nombre = Interaction.InputBox("Introduce nombre de alumno : ", "Gestión de Alumnos ");
            do
            {
                dni = Interaction.InputBox("Introduce DNI de alumno : ", "Gestión de Alumnos");
                if (dni.Length != 9)
                    MessageBox.Show("Debe componerse de 9 caracteres ","Gestión de Alumnos");
                if (listaAlumnos.ValidaDNI(dni) || listaProfesores.ValidaDNI(dni))
                    MessageBox.Show("El DNI ya existe");
            } while (dni.Length !=9 || listaAlumnos.ValidaDNI(dni) || listaProfesores.ValidaDNI(dni));

            do
            {
               codigo = Interaction.InputBox("Introduce código del curso : ", "Gestión de Alumnos");
                if (!listaCursos.EncontrarCurso(codigo))
                {
                    seguir = MessageBox.Show("No existe el curso y tiene que estar creado.\n ¿Quieres crear el curso ahora?", "Gestión de Alumnos",MessageBoxButtons.YesNo);
                    if (seguir == DialogResult.Yes)
                    {
                        MessageBox.Show("Entrando en Gestión de Cursos", "Gestión de Cursos");
                        do
                        {
                           
                            nom = Interaction.InputBox("Introduce nombre del curso : ", "Gestión de Cursos");
                            if (listaCursos.EncontrarCursoNombre(nom))
                                MessageBox.Show("El nombre del curso ya se está utilizando", "Gestión de Cursos");
                        } while (listaCursos.EncontrarCursoNombre(nom));

                        do
                        {
                            cod = Interaction.InputBox("Introduce código del curso : ", "Gestión de cursos");
                            if (listaCursos.EncontrarCurso(cod))
                                MessageBox.Show("El código del curso ya está en uso", "Gestión de cursos");
                        } while (listaCursos.EncontrarCurso(cod));
                        listaCursos.AnyadirCurso(nom, cod);
                        MessageBox.Show("Saliendo de Gestión de Cursos", "Gestión de Cursos");
                    }
                    else
                        return;
                }
            } while (!listaCursos.EncontrarCurso(codigo));

            do
            {
                telefono = Interaction.InputBox("Introduce número de telefono : ", "Gestión de Alumnos");
                if (telefono.Length != 9)
                    MessageBox.Show("El telefono debe componerse de 9 números", "Gestión de Alumnos");
                if (listaAlumnos.ValidaTelefono(telefono) || listaProfesores.ValidaTelefono(telefono))
                    MessageBox.Show("El teléfono ya existe");
            } while (telefono.Length != 9 || listaAlumnos.ValidaTelefono(telefono) || listaProfesores.ValidaTelefono(telefono));

            listaAlumnos.AnyadirAlumno(nombre, dni, codigo, telefono);
        }

        public void AñadirNota()
        {
            double nota;
            string nombre = Interaction.InputBox("Introduce el nombre del alumno : ", "Gestión de Alumnos");
            do
            {
                nota = double.Parse(Interaction.InputBox("Introduce la nota : ", "Gestión de Alumnos"));
                if (nota < 0 || nota > 10)
                    MessageBox.Show("La nota introducida debe estar comprendida entre 0 y 10","Gestión de Alumnos");
            } while (nota < 0 || nota > 10);

            bool encontrado = listaAlumnos.AnyadirNota(nombre, nota);
            if (encontrado)
                MessageBox.Show("Se ha introducido la nota con éxito ", "Gestión de Alumnos");
            else
                MessageBox.Show("No se ha encontrado el alumno", "Gestión de Alumnos");
        }

        private void bAñadirAlumno_Click(object sender, EventArgs e)
        {
            IntroducirAlumno();
        }

        private void bOrdenarAlumnosAlfabetico_Click(object sender, EventArgs e)
        {
            listaAlumnos.OrdenarAlumnosNombre();
        }

        private void bMostrarListaAlumnos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaAlumnos.MostrarListaAlumnos(),"Gestión de Alumnos");
        }

        private void bEliminarAlumno_Click(object sender, EventArgs e)
        {
            listaAlumnos.EliminarAlumno();
        }

        private void bMostrarDatosAlumnoNombre_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce nombre del alumno :","Gestión de Alumnos");
            MessageBox.Show(listaAlumnos.MostrarAlumno(nombre),"Gestión de Alumnos");
        }

        private void bAñadirNotasAlumno_Click(object sender, EventArgs e)
        {
            AñadirNota();
        }

        private void bEliminarNotasAlumno_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre del alumno", "Gestión de Alumnos");
            bool encontrado = listaAlumnos.EliminarNotaAlumno(nombre);
            if (encontrado)
                MessageBox.Show("Se ha eliminado las notas del alumno, " + nombre,"Gestión de Alumnos");
            else
                MessageBox.Show("No se ha encontrado el alumno, " + nombre,"Gestión de Alumnos");
        }

        private void bMostrarAlumnosNotaMayor5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaAlumnos.NotaMediaMayor5(),"Gestión de Alumnos");
        }

        private void bMostrarAlumnoNotaMenor5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaAlumnos.NotaMediaMenor5(),"Gestión de Alumnos");
        }

        private void bMostrarAlumnosPorCurso_Click(object sender, EventArgs e)
        {
            string codigo = Interaction.InputBox("Introduce código del curso para ver los alumnos pertenecientes : ", "Gestión de Alumnos");
            if (listaCursos.EncontrarCurso(codigo) && !listaAlumnos.ListaVcia())
                MessageBox.Show("No hay alumnos en el curso ", "Gestión de Alumnos");
            else
            {
                if (listaCursos.EncontrarCurso(codigo))
                    MessageBox.Show(listaAlumnos.MostrarPorCurso(codigo), "Gestión de Alumnos");
                else
                    MessageBox.Show("No existe el curso \n", "Gestión de Alumnos ");
            }
        }
    }
}
