namespace Ejercicio06CentroEscolar
{
    partial class fInicial
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
            this.bCursos = new System.Windows.Forms.Button();
            this.bGestionAlumnos = new System.Windows.Forms.Button();
            this.bGestionProfesores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCursos
            // 
            this.bCursos.Location = new System.Drawing.Point(72, 47);
            this.bCursos.Name = "bCursos";
            this.bCursos.Size = new System.Drawing.Size(136, 29);
            this.bCursos.TabIndex = 0;
            this.bCursos.Text = "Gestión de Cursos";
            this.bCursos.UseVisualStyleBackColor = true;
            this.bCursos.Click += new System.EventHandler(this.bCursos_Click);
            // 
            // bGestionAlumnos
            // 
            this.bGestionAlumnos.Location = new System.Drawing.Point(72, 109);
            this.bGestionAlumnos.Name = "bGestionAlumnos";
            this.bGestionAlumnos.Size = new System.Drawing.Size(136, 29);
            this.bGestionAlumnos.TabIndex = 1;
            this.bGestionAlumnos.Text = "Gestión Alumnos";
            this.bGestionAlumnos.UseVisualStyleBackColor = true;
            this.bGestionAlumnos.Click += new System.EventHandler(this.bGestionAlumnos_Click);
            // 
            // bGestionProfesores
            // 
            this.bGestionProfesores.Location = new System.Drawing.Point(72, 168);
            this.bGestionProfesores.Name = "bGestionProfesores";
            this.bGestionProfesores.Size = new System.Drawing.Size(136, 28);
            this.bGestionProfesores.TabIndex = 2;
            this.bGestionProfesores.Text = "Gestión Profesores";
            this.bGestionProfesores.UseVisualStyleBackColor = true;
            this.bGestionProfesores.Click += new System.EventHandler(this.bGestionProfesores_Click);
            // 
            // fInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.bGestionProfesores);
            this.Controls.Add(this.bGestionAlumnos);
            this.Controls.Add(this.bCursos);
            this.Name = "fInicial";
            this.Text = "Gestión de Instituto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCursos;
        private System.Windows.Forms.Button bGestionAlumnos;
        private System.Windows.Forms.Button bGestionProfesores;
    }
}

