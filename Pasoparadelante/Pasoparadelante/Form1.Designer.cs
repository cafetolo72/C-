
namespace Pasoparadelante
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bLeerVector = new System.Windows.Forms.Button();
            this.bPasoValores = new System.Windows.Forms.Button();
            this.bMostrarVectores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLeerVector
            // 
            this.bLeerVector.Location = new System.Drawing.Point(82, 84);
            this.bLeerVector.Name = "bLeerVector";
            this.bLeerVector.Size = new System.Drawing.Size(177, 23);
            this.bLeerVector.TabIndex = 0;
            this.bLeerVector.Text = "Leer Vector";
            this.bLeerVector.UseVisualStyleBackColor = true;
            this.bLeerVector.Click += new System.EventHandler(this.bLeerVector_Click);
            // 
            // bPasoValores
            // 
            this.bPasoValores.Location = new System.Drawing.Point(82, 150);
            this.bPasoValores.Name = "bPasoValores";
            this.bPasoValores.Size = new System.Drawing.Size(177, 23);
            this.bPasoValores.TabIndex = 1;
            this.bPasoValores.Text = "Pasar valores a otro vector";
            this.bPasoValores.UseVisualStyleBackColor = true;
            this.bPasoValores.Click += new System.EventHandler(this.bPasoValores_Click);
            // 
            // bMostrarVectores
            // 
            this.bMostrarVectores.Location = new System.Drawing.Point(82, 221);
            this.bMostrarVectores.Name = "bMostrarVectores";
            this.bMostrarVectores.Size = new System.Drawing.Size(177, 23);
            this.bMostrarVectores.TabIndex = 2;
            this.bMostrarVectores.Text = "Mostrar Vectores";
            this.bMostrarVectores.UseVisualStyleBackColor = true;
            this.bMostrarVectores.Click += new System.EventHandler(this.bMostrarVectores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bMostrarVectores);
            this.Controls.Add(this.bPasoValores);
            this.Controls.Add(this.bLeerVector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bLeerVector;
        private System.Windows.Forms.Button bPasoValores;
        private System.Windows.Forms.Button bMostrarVectores;
    }
}

