
namespace Ejercicio06CentroEscolar
{
    partial class fProfesores
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
            this.gProfesores = new System.Windows.Forms.GroupBox();
            this.bMostrarDatosProfesores = new System.Windows.Forms.Button();
            this.bOrdenarProfesoresAlfabetico = new System.Windows.Forms.Button();
            this.bMostrarListaProfesores = new System.Windows.Forms.Button();
            this.bEliminarProfesor = new System.Windows.Forms.Button();
            this.bIntroducirProfesor = new System.Windows.Forms.Button();
            this.gAsignaturas = new System.Windows.Forms.GroupBox();
            this.bMostrarProfesoresAsignatura = new System.Windows.Forms.Button();
            this.bEliminarAsignaturasaProfesor = new System.Windows.Forms.Button();
            this.bAñadirAsignaturaProfesor = new System.Windows.Forms.Button();
            this.gProfesores.SuspendLayout();
            this.gAsignaturas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gProfesores
            // 
            this.gProfesores.Controls.Add(this.bMostrarDatosProfesores);
            this.gProfesores.Controls.Add(this.bOrdenarProfesoresAlfabetico);
            this.gProfesores.Controls.Add(this.bMostrarListaProfesores);
            this.gProfesores.Controls.Add(this.bEliminarProfesor);
            this.gProfesores.Controls.Add(this.bIntroducirProfesor);
            this.gProfesores.Location = new System.Drawing.Point(52, 44);
            this.gProfesores.Name = "gProfesores";
            this.gProfesores.Size = new System.Drawing.Size(675, 130);
            this.gProfesores.TabIndex = 0;
            this.gProfesores.TabStop = false;
            this.gProfesores.Text = "Profesores";
            // 
            // bMostrarDatosProfesores
            // 
            this.bMostrarDatosProfesores.Location = new System.Drawing.Point(394, 96);
            this.bMostrarDatosProfesores.Name = "bMostrarDatosProfesores";
            this.bMostrarDatosProfesores.Size = new System.Drawing.Size(175, 23);
            this.bMostrarDatosProfesores.TabIndex = 4;
            this.bMostrarDatosProfesores.Text = "Mostrar Datos Profesores";
            this.bMostrarDatosProfesores.UseVisualStyleBackColor = true;
            this.bMostrarDatosProfesores.Click += new System.EventHandler(this.bMostrarDatosProfesores_Click);
            // 
            // bOrdenarProfesoresAlfabetico
            // 
            this.bOrdenarProfesoresAlfabetico.Location = new System.Drawing.Point(93, 96);
            this.bOrdenarProfesoresAlfabetico.Name = "bOrdenarProfesoresAlfabetico";
            this.bOrdenarProfesoresAlfabetico.Size = new System.Drawing.Size(231, 23);
            this.bOrdenarProfesoresAlfabetico.TabIndex = 3;
            this.bOrdenarProfesoresAlfabetico.Text = "Ordenar Profesores por Orden Alfabético";
            this.bOrdenarProfesoresAlfabetico.UseVisualStyleBackColor = true;
            this.bOrdenarProfesoresAlfabetico.Click += new System.EventHandler(this.bOrdenarProfesoresAlfabetico_Click);
            // 
            // bMostrarListaProfesores
            // 
            this.bMostrarListaProfesores.Location = new System.Drawing.Point(460, 28);
            this.bMostrarListaProfesores.Name = "bMostrarListaProfesores";
            this.bMostrarListaProfesores.Size = new System.Drawing.Size(142, 23);
            this.bMostrarListaProfesores.TabIndex = 2;
            this.bMostrarListaProfesores.Text = "Mostrar Lista Profesores";
            this.bMostrarListaProfesores.UseVisualStyleBackColor = true;
            this.bMostrarListaProfesores.Click += new System.EventHandler(this.bMostrarListaProfesores_Click);
            // 
            // bEliminarProfesor
            // 
            this.bEliminarProfesor.Location = new System.Drawing.Point(235, 28);
            this.bEliminarProfesor.Name = "bEliminarProfesor";
            this.bEliminarProfesor.Size = new System.Drawing.Size(126, 23);
            this.bEliminarProfesor.TabIndex = 1;
            this.bEliminarProfesor.Text = "Eliminar Profesor";
            this.bEliminarProfesor.UseVisualStyleBackColor = true;
            this.bEliminarProfesor.Click += new System.EventHandler(this.bEliminarProfesor_Click);
            // 
            // bIntroducirProfesor
            // 
            this.bIntroducirProfesor.Location = new System.Drawing.Point(23, 31);
            this.bIntroducirProfesor.Name = "bIntroducirProfesor";
            this.bIntroducirProfesor.Size = new System.Drawing.Size(132, 23);
            this.bIntroducirProfesor.TabIndex = 0;
            this.bIntroducirProfesor.Text = "Introducir Profesores";
            this.bIntroducirProfesor.UseVisualStyleBackColor = true;
            this.bIntroducirProfesor.Click += new System.EventHandler(this.bIntroducirProfesor_Click);
            // 
            // gAsignaturas
            // 
            this.gAsignaturas.Controls.Add(this.bMostrarProfesoresAsignatura);
            this.gAsignaturas.Controls.Add(this.bEliminarAsignaturasaProfesor);
            this.gAsignaturas.Controls.Add(this.bAñadirAsignaturaProfesor);
            this.gAsignaturas.Location = new System.Drawing.Point(52, 237);
            this.gAsignaturas.Name = "gAsignaturas";
            this.gAsignaturas.Size = new System.Drawing.Size(675, 114);
            this.gAsignaturas.TabIndex = 1;
            this.gAsignaturas.TabStop = false;
            this.gAsignaturas.Text = "Asignaturas";
            // 
            // bMostrarProfesoresAsignatura
            // 
            this.bMostrarProfesoresAsignatura.Location = new System.Drawing.Point(167, 73);
            this.bMostrarProfesoresAsignatura.Name = "bMostrarProfesoresAsignatura";
            this.bMostrarProfesoresAsignatura.Size = new System.Drawing.Size(330, 23);
            this.bMostrarProfesoresAsignatura.TabIndex = 2;
            this.bMostrarProfesoresAsignatura.Text = "Mostrar Profesores que imparten una asigntura";
            this.bMostrarProfesoresAsignatura.UseVisualStyleBackColor = true;
            this.bMostrarProfesoresAsignatura.Click += new System.EventHandler(this.bMostrarProfesoresAsignatura_Click);
            // 
            // bEliminarAsignaturasaProfesor
            // 
            this.bEliminarAsignaturasaProfesor.Location = new System.Drawing.Point(370, 28);
            this.bEliminarAsignaturasaProfesor.Name = "bEliminarAsignaturasaProfesor";
            this.bEliminarAsignaturasaProfesor.Size = new System.Drawing.Size(246, 23);
            this.bEliminarAsignaturasaProfesor.TabIndex = 1;
            this.bEliminarAsignaturasaProfesor.Text = "Eliminar las asignaturas de un profesor";
            this.bEliminarAsignaturasaProfesor.UseVisualStyleBackColor = true;
            this.bEliminarAsignaturasaProfesor.Click += new System.EventHandler(this.bEliminarAsignaturasaProfesor_Click);
            // 
            // bAñadirAsignaturaProfesor
            // 
            this.bAñadirAsignaturaProfesor.Location = new System.Drawing.Point(50, 28);
            this.bAñadirAsignaturaProfesor.Name = "bAñadirAsignaturaProfesor";
            this.bAñadirAsignaturaProfesor.Size = new System.Drawing.Size(188, 23);
            this.bAñadirAsignaturaProfesor.TabIndex = 0;
            this.bAñadirAsignaturaProfesor.Text = "Añadir Asignatura Profesor";
            this.bAñadirAsignaturaProfesor.UseVisualStyleBackColor = true;
            this.bAñadirAsignaturaProfesor.Click += new System.EventHandler(this.bAñadirAsignaturaProfesor_Click);
            // 
            // fProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gAsignaturas);
            this.Controls.Add(this.gProfesores);
            this.Name = "fProfesores";
            this.Text = "fProfesores";
            this.gProfesores.ResumeLayout(false);
            this.gAsignaturas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gProfesores;
        private System.Windows.Forms.Button bMostrarDatosProfesores;
        private System.Windows.Forms.Button bOrdenarProfesoresAlfabetico;
        private System.Windows.Forms.Button bMostrarListaProfesores;
        private System.Windows.Forms.Button bEliminarProfesor;
        private System.Windows.Forms.Button bIntroducirProfesor;
        private System.Windows.Forms.GroupBox gAsignaturas;
        private System.Windows.Forms.Button bMostrarProfesoresAsignatura;
        private System.Windows.Forms.Button bEliminarAsignaturasaProfesor;
        private System.Windows.Forms.Button bAñadirAsignaturaProfesor;
    }
}