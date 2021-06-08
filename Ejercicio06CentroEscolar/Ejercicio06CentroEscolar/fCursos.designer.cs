namespace Ejercicio06CentroEscolar
{
    partial class fCursos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAñadirCurso = new System.Windows.Forms.Button();
            this.bEliminarCurso = new System.Windows.Forms.Button();
            this.bMostrarTodosCursos = new System.Windows.Forms.Button();
            this.bMostrarTodosAlumnosCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAñadirCurso
            // 
            this.bAñadirCurso.Location = new System.Drawing.Point(62, 29);
            this.bAñadirCurso.Name = "bAñadirCurso";
            this.bAñadirCurso.Size = new System.Drawing.Size(163, 23);
            this.bAñadirCurso.TabIndex = 0;
            this.bAñadirCurso.Text = "Añadir Curso";
            this.bAñadirCurso.UseVisualStyleBackColor = true;
            this.bAñadirCurso.Click += new System.EventHandler(this.bAñadirCurso_Click);
            // 
            // bEliminarCurso
            // 
            this.bEliminarCurso.Location = new System.Drawing.Point(62, 83);
            this.bEliminarCurso.Name = "bEliminarCurso";
            this.bEliminarCurso.Size = new System.Drawing.Size(163, 23);
            this.bEliminarCurso.TabIndex = 1;
            this.bEliminarCurso.Text = "Eliminar Curso";
            this.bEliminarCurso.UseVisualStyleBackColor = true;
            this.bEliminarCurso.Click += new System.EventHandler(this.bEliminarCurso_Click);
            // 
            // bMostrarTodosCursos
            // 
            this.bMostrarTodosCursos.Location = new System.Drawing.Point(62, 140);
            this.bMostrarTodosCursos.Name = "bMostrarTodosCursos";
            this.bMostrarTodosCursos.Size = new System.Drawing.Size(163, 23);
            this.bMostrarTodosCursos.TabIndex = 2;
            this.bMostrarTodosCursos.Text = "Mostrar todos los cursos";
            this.bMostrarTodosCursos.UseVisualStyleBackColor = true;
            this.bMostrarTodosCursos.Click += new System.EventHandler(this.bMostrarTodosCursos_Click);
            // 
            // bMostrarTodosAlumnosCurso
            // 
            this.bMostrarTodosAlumnosCurso.Location = new System.Drawing.Point(62, 191);
            this.bMostrarTodosAlumnosCurso.Name = "bMostrarTodosAlumnosCurso";
            this.bMostrarTodosAlumnosCurso.Size = new System.Drawing.Size(163, 46);
            this.bMostrarTodosAlumnosCurso.TabIndex = 3;
            this.bMostrarTodosAlumnosCurso.Text = "Mostrar todos los alumnos pertenecientes a un curso";
            this.bMostrarTodosAlumnosCurso.UseVisualStyleBackColor = true;
            this.bMostrarTodosAlumnosCurso.Click += new System.EventHandler(this.bMostrarTodosAlumnosCurso_Click);
            // 
            // fCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.bMostrarTodosAlumnosCurso);
            this.Controls.Add(this.bMostrarTodosCursos);
            this.Controls.Add(this.bEliminarCurso);
            this.Controls.Add(this.bAñadirCurso);
            this.Name = "fCursos";
            this.Text = "fCursos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAñadirCurso;
        private System.Windows.Forms.Button bEliminarCurso;
        private System.Windows.Forms.Button bMostrarTodosCursos;
        private System.Windows.Forms.Button bMostrarTodosAlumnosCurso;
    }
}