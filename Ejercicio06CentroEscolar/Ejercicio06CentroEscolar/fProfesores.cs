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
    public partial class fProfesores : Form
    {
        public fProfesores()
        {
            InitializeComponent();
        }
        public tListaCursos listaCursos;
        public tListaAlumnos listaAlumnos;
        public tListaProfesores listaProfesores;

        public void IntroducirProfesor()
        {
            tProfesor prof = new tProfesor();
            string dni, telefono, codigo , nom, cod;
            DialogResult tutor , seguir;

            string nombre = Interaction.InputBox("Introduce nombre de profesor : ", "Gestión de Profesores");
            do
            {
                dni = Interaction.InputBox("Introduce DNI : ","Gestión de Profesores");
                if (dni.Length != 9)
                    MessageBox.Show("Debe componerse de 9 caracteres ","Gestión de Profesores");
                if (listaAlumnos.ValidaDNI(dni) || listaProfesores.ValidaDNI(dni))
                    MessageBox.Show("El DNI ya existe");
            } while (dni.Length != 9 || listaAlumnos.ValidaDNI(dni) || listaProfesores.ValidaDNI(dni));

            do
            {
                telefono = Interaction.InputBox("Introduce telefono : ", "Gestión de Profesores");
                if (telefono.Length != 9)
                    MessageBox.Show("El teléfono debe ser de 9 números", "Gestión de Profesores");
                if (listaAlumnos.ValidaTelefono(telefono) || listaProfesores.ValidaTelefono(telefono))
                    MessageBox.Show("El teléfono ya existe");
            } while (telefono.Length != 9 || listaAlumnos.ValidaTelefono(telefono) || listaProfesores.ValidaTelefono(telefono));
            do
            {
                tutor = MessageBox.Show("¿Eres tutor?", "Gestión de Profesores", MessageBoxButtons.YesNo);
                if (tutor == DialogResult.Yes)
                {
                    codigo = Interaction.InputBox("Introduce código de curso : ","Gestión de Profesores");
                    if (!listaCursos.EncontrarCurso(codigo) || listaProfesores.EncontrarCodigoProfe(codigo))
                    {
                        if (listaCursos.EncontrarCurso(codigo) && listaProfesores.EncontrarCodigoProfe(codigo))
                        {
                            seguir= MessageBox.Show("No puede ser tutor de este curso. ¿Quieres crear otro curso?","Gestión de Profesores",MessageBoxButtons.YesNo);
                        }
                        else
                            seguir = MessageBox.Show("No existe el curso y debería estar creado.\n ¿Quieres crearlo ahora?", "Gestión de Profesores", MessageBoxButtons.YesNo);
                           
                        if (seguir == DialogResult.Yes)
                        
                        {
                            MessageBox.Show("Entrando en Gestión de Cursos","Gestión de Cursos");
                            do
                            {
                                nom = Interaction.InputBox("Introduce nombre del curso : ", "Gestión de Cursos");
                                if (listaCursos.EncontrarCursoNombre(nom))
                                    MessageBox.Show("El curso " + nom + "ya está en uso", "Gestión de Cursos");
                            } while (listaCursos.EncontrarCursoNombre(nom));
                            do
                            {
                                cod = Interaction.InputBox("Introduce codigo del curso : ", "Gestión de Cursos");
                                if (listaCursos.EncontrarCurso(cod))
                                    MessageBox.Show("El código del curso ya está en uso","Gestión de Cursos");
                            } while (listaCursos.EncontrarCurso(cod));
                            listaCursos.AnyadirCurso(nom, cod);
                        }
                        else
                            return;
                    }
                }
                else
                    codigo = "No es tutor"; break;
            } while (!listaCursos.EncontrarCurso(codigo));

            listaProfesores.AnyadirProfesor(nombre, dni, telefono, codigo);
        }

        private void bIntroducirProfesor_Click(object sender, EventArgs e)
        {
            IntroducirProfesor();
        }

        private void bEliminarProfesor_Click(object sender, EventArgs e)
        {
            listaProfesores.EliminarProfesor();
        }

        private void bMostrarListaProfesores_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listaProfesores.MostrarListaProfesores(),"Gestión de Profesores");
        }

        private void bOrdenarProfesoresAlfabetico_Click(object sender, EventArgs e)
        {
            listaProfesores.OrdenarProfesoresAlfabetico();
        }

        private void bMostrarDatosProfesores_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre de profesor : ","Gestión de Profesores");
           MessageBox.Show(listaProfesores.MostrarProfesores(nombre), "Gestión de Profesores ");
        }

        private void bAñadirAsignaturaProfesor_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre para añadir asignatura :","Gestión de Profesores");
            string asignatura = Interaction.InputBox("Introduce asignatura para añadir :","Gestión de Profesores");
            bool encontrado = listaProfesores.AnyadirAsignatura(nombre, asignatura);
            if (encontrado)
                MessageBox.Show("Se ha introducido con éxito", "Gestión de Profesores");
            else
                MessageBox.Show("No se ha encontrado el profesor , " + nombre, "Gestión de Profesores");
        }

        private void bEliminarAsignaturasaProfesor_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre para eliminar asignatura :", "Gestión de Profesores");
            bool encontrado =  listaProfesores.EliminarAsignatura(nombre);
            if (encontrado)
                MessageBox.Show("Se ha eliminado las asignaturas del profesor , " + nombre, "Gestión de Profesores");
            else
                MessageBox.Show("No se ha encontrado el profesor , " + nombre, "Gestión de Profesores");
        }
       
        private void bMostrarProfesoresAsignatura_Click(object sender, EventArgs e)
        {
            string asignatura = Interaction.InputBox("Introduce asignatura : ", "Gestión de Profesores");
            MessageBox.Show(listaProfesores.MostrarProfesoresAsignatura(asignatura), "Gestión de Profesores");
        }
    }
}
