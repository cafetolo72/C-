
namespace Ejercicio06CentroEscolar
{
    partial class fAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gAlumnos = new System.Windows.Forms.GroupBox();
            this.bMostrarAlumnosPorCurso = new System.Windows.Forms.Button();
            this.bMostrarDatosAlumnoNombre = new System.Windows.Forms.Button();
            this.bOrdenarAlumnosAlfabetico = new System.Windows.Forms.Button();
            this.bMostrarListaAlumnos = new System.Windows.Forms.Button();
            this.bEliminarAlumno = new System.Windows.Forms.Button();
            this.bAñadirAlumno = new System.Windows.Forms.Button();
            this.gNotas = new System.Windows.Forms.GroupBox();
            this.bMostrarAlumnoNotaMenor5 = new System.Windows.Forms.Button();
            this.bEliminarNotasAlumno = new System.Windows.Forms.Button();
            this.bMostrarAlumnosNotaMayor5 = new System.Windows.Forms.Button();
            this.bAñadirNotasAlumno = new System.Windows.Forms.Button();
            this.gAlumnos.SuspendLayout();
            this.gNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gAlumnos
            // 
            this.gAlumnos.Controls.Add(this.bMostrarAlumnosPorCurso);
            this.gAlumnos.Controls.Add(this.bMostrarDatosAlumnoNombre);
            this.gAlumnos.Controls.Add(this.bOrdenarAlumnosAlfabetico);
            this.gAlumnos.Controls.Add(this.bMostrarListaAlumnos);
            this.gAlumnos.Controls.Add(this.bEliminarAlumno);
            this.gAlumnos.Controls.Add(this.bAñadirAlumno);
            this.gAlumnos.Location = new System.Drawing.Point(58, 48);
            this.gAlumnos.Name = "gAlumnos";
            this.gAlumnos.Size = new System.Drawing.Size(699, 172);
            this.gAlumnos.TabIndex = 0;
            this.gAlumnos.TabStop = false;
            this.gAlumnos.Text = "Alumnos";
            // 
            // bMostrarAlumnosPorCurso
            // 
            this.bMostrarAlumnosPorCurso.Location = new System.Drawing.Point(324, 128);
            this.bMostrarAlumnosPorCurso.Name = "bMostrarAlumnosPorCurso";
            this.bMostrarAlumnosPorCurso.Size = new System.Drawing.Size(254, 23);
            this.bMostrarAlumnosPorCurso.TabIndex = 5;
            this.bMostrarAlumnosPorCurso.Text = "Mostrar Alumnos pertenecientes a un curso";
            this.bMostrarAlumnosPorCurso.UseVisualStyleBackColor = true;
            this.bMostrarAlumnosPorCurso.Click += new System.EventHandler(this.bMostrarAlumnosPorCurso_Click);
            // 
            // bMostrarDatosAlumnoNombre
            // 
            this.bMostrarDatosAlumnoNombre.Location = new System.Drawing.Point(324, 84);
            this.bMostrarDatosAlumnoNombre.Name = "bMostrarDatosAlumnoNombre";
            this.bMostrarDatosAlumnoNombre.Size = new System.Drawing.Size(216, 23);
            this.bMostrarDatosAlumnoNombre.TabIndex = 4;
            this.bMostrarDatosAlumnoNombre.Text = "Mostrar Datos Alumno(por nombre)";
            this.bMostrarDatosAlumnoNombre.UseVisualStyleBackColor = true;
            this.bMostrarDatosAlumnoNombre.Click += new System.EventHandler(this.bMostrarDatosAlumnoNombre_Click);
            // 
            // bOrdenarAlumnosAlfabetico
            // 
            this.bOrdenarAlumnosAlfabetico.Location = new System.Drawing.Point(324, 35);
            this.bOrdenarAlumnosAlfabetico.Name = "bOrdenarAlumnosAlfabetico";
            this.bOrdenarAlumnosAlfabetico.Size = new System.Drawing.Size(215, 23);
            this.bOrdenarAlumnosAlfabetico.TabIndex = 3;
            this.bOrdenarAlumnosAlfabetico.Text = "Ordenar Alumnos por Orden Alfabético";
            this.bOrdenarAlumnosAlfabetico.UseVisualStyleBackColor = true;
            this.bOrdenarAlumnosAlfabetico.Click += new System.EventHandler(this.bOrdenarAlumnosAlfabetico_Click);
            // 
            // bMostrarListaAlumnos
            // 
            this.bMostrarListaAlumnos.Location = new System.Drawing.Point(53, 84);
            this.bMostrarListaAlumnos.Name = "bMostrarListaAlumnos";
            this.bMostrarListaAlumnos.Size = new System.Drawing.Size(153, 23);
            this.bMostrarListaAlumnos.TabIndex = 2;
            this.bMostrarListaAlumnos.Text = "Mostrar Lista Alumnos";
            this.bMostrarListaAlumnos.UseVisualStyleBackColor = true;
            this.bMostrarListaAlumnos.Click += new System.EventHandler(this.bMostrarListaAlumnos_Click);
            // 
            // bEliminarAlumno
            // 
            this.bEliminarAlumno.Location = new System.Drawing.Point(52, 128);
            this.bEliminarAlumno.Name = "bEliminarAlumno";
            this.bEliminarAlumno.Size = new System.Drawing.Size(129, 23);
            this.bEliminarAlumno.TabIndex = 1;
            this.bEliminarAlumno.Text = "Eliminar Alumno";
            this.bEliminarAlumno.UseVisualStyleBackColor = true;
            this.bEliminarAlumno.Click += new System.EventHandler(this.bEliminarAlumno_Click);
            // 
            // bAñadirAlumno
            // 
            this.bAñadirAlumno.Location = new System.Drawing.Point(53, 35);
            this.bAñadirAlumno.Name = "bAñadirAlumno";
            this.bAñadirAlumno.Size = new System.Drawing.Size(128, 23);
            this.bAñadirAlumno.TabIndex = 0;
            this.bAñadirAlumno.Text = "Introducir Alumno";
            this.bAñadirAlumno.UseVisualStyleBackColor = true;
            this.bAñadirAlumno.Click += new System.EventHandler(this.bAñadirAlumno_Click);
            // 
            // gNotas
            // 
            this.gNotas.Controls.Add(this.bMostrarAlumnoNotaMenor5);
            this.gNotas.Controls.Add(this.bEliminarNotasAlumno);
            this.gNotas.Controls.Add(this.bMostrarAlumnosNotaMayor5);
            this.gNotas.Controls.Add(this.bAñadirNotasAlumno);
            this.gNotas.Location = new System.Drawing.Point(58, 249);
            this.gNotas.Name = "gNotas";
            this.gNotas.Size = new System.Drawing.Size(699, 127);
            this.gNotas.TabIndex = 1;
            this.gNotas.TabStop = false;
            this.gNotas.Text = "Notas";
            // 
            // bMostrarAlumnoNotaMenor5
            // 
            this.bMostrarAlumnoNotaMenor5.Location = new System.Drawing.Point(324, 80);
            this.bMostrarAlumnoNotaMenor5.Name = "bMostrarAlumnoNotaMenor5";
            this.bMostrarAlumnoNotaMenor5.Size = new System.Drawing.Size(275, 23);
            this.bMostrarAlumnoNotaMenor5.TabIndex = 3;
            this.bMostrarAlumnoNotaMenor5.Text = "Mostrar alumnos con nota media menor a 5";
            this.bMostrarAlumnoNotaMenor5.UseVisualStyleBackColor = true;
            this.bMostrarAlumnoNotaMenor5.Click += new System.EventHandler(this.bMostrarAlumnoNotaMenor5_Click);
            // 
            // bEliminarNotasAlumno
            // 
            this.bEliminarNotasAlumno.Location = new System.Drawing.Point(53, 80);
            this.bEliminarNotasAlumno.Name = "bEliminarNotasAlumno";
            this.bEliminarNotasAlumno.Size = new System.Drawing.Size(178, 23);
            this.bEliminarNotasAlumno.TabIndex = 2;
            this.bEliminarNotasAlumno.Text = "Eliminar  las notas de un alumno";
            this.bEliminarNotasAlumno.UseVisualStyleBackColor = true;
            this.bEliminarNotasAlumno.Click += new System.EventHandler(this.bEliminarNotasAlumno_Click);
            // 
            // bMostrarAlumnosNotaMayor5
            // 
            this.bMostrarAlumnosNotaMayor5.Location = new System.Drawing.Point(324, 28);
            this.bMostrarAlumnosNotaMayor5.Name = "bMostrarAlumnosNotaMayor5";
            this.bMostrarAlumnosNotaMayor5.Size = new System.Drawing.Size(275, 23);
            this.bMostrarAlumnosNotaMayor5.TabIndex = 1;
            this.bMostrarAlumnosNotaMayor5.Text = "Mostrar Alumnos con nota media mayor o igual a 5";
            this.bMostrarAlumnosNotaMayor5.UseVisualStyleBackColor = true;
            this.bMostrarAlumnosNotaMayor5.Click += new System.EventHandler(this.bMostrarAlumnosNotaMayor5_Click);
            // 
            // bAñadirNotasAlumno
            // 
            this.bAñadirNotasAlumno.Location = new System.Drawing.Point(52, 28);
            this.bAñadirNotasAlumno.Name = "bAñadirNotasAlumno";
            this.bAñadirNotasAlumno.Size = new System.Drawing.Size(179, 23);
            this.bAñadirNotasAlumno.TabIndex = 0;
            this.bAñadirNotasAlumno.Text = "Añadir Notas a Alumno";
            this.bAñadirNotasAlumno.UseVisualStyleBackColor = true;
            this.bAñadirNotasAlumno.Click += new System.EventHandler(this.bAñadirNotasAlumno_Click);
            // 
            // fAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gNotas);
            this.Controls.Add(this.gAlumnos);
            this.Name = "fAlumnos";
            this.Text = "fAlumnos";
            this.gAlumnos.ResumeLayout(false);
            this.gNotas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gAlumnos;
        private System.Windows.Forms.Button bMostrarAlumnosPorCurso;
        private System.Windows.Forms.Button bMostrarDatosAlumnoNombre;
        private System.Windows.Forms.Button bOrdenarAlumnosAlfabetico;
        private System.Windows.Forms.Button bMostrarListaAlumnos;
        private System.Windows.Forms.Button bEliminarAlumno;
        private System.Windows.Forms.Button bAñadirAlumno;
        private System.Windows.Forms.GroupBox gNotas;
        private System.Windows.Forms.Button bMostrarAlumnoNotaMenor5;
        private System.Windows.Forms.Button bEliminarNotasAlumno;
        private System.Windows.Forms.Button bMostrarAlumnosNotaMayor5;
        private System.Windows.Forms.Button bAñadirNotasAlumno;
    }
}