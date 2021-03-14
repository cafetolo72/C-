
namespace MayorMenorVector
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
            this.bMostrarMenor = new System.Windows.Forms.Button();
            this.bMostrarMayor = new System.Windows.Forms.Button();
            this.bMostrarVector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLeerVector
            // 
            this.bLeerVector.Location = new System.Drawing.Point(113, 70);
            this.bLeerVector.Name = "bLeerVector";
            this.bLeerVector.Size = new System.Drawing.Size(123, 23);
            this.bLeerVector.TabIndex = 0;
            this.bLeerVector.Text = "Leer Vector ";
            this.bLeerVector.UseVisualStyleBackColor = true;
            this.bLeerVector.Click += new System.EventHandler(this.bLeerVector_Click);
            // 
            // bMostrarMenor
            // 
            this.bMostrarMenor.Location = new System.Drawing.Point(113, 140);
            this.bMostrarMenor.Name = "bMostrarMenor";
            this.bMostrarMenor.Size = new System.Drawing.Size(123, 23);
            this.bMostrarMenor.TabIndex = 1;
            this.bMostrarMenor.Text = "Mostrar Menor";
            this.bMostrarMenor.UseVisualStyleBackColor = true;
            this.bMostrarMenor.Click += new System.EventHandler(this.bMostrarMenor_Click);
            // 
            // bMostrarMayor
            // 
            this.bMostrarMayor.Location = new System.Drawing.Point(115, 208);
            this.bMostrarMayor.Name = "bMostrarMayor";
            this.bMostrarMayor.Size = new System.Drawing.Size(121, 23);
            this.bMostrarMayor.TabIndex = 2;
            this.bMostrarMayor.Text = "Mostrar Mayor";
            this.bMostrarMayor.UseVisualStyleBackColor = true;
            this.bMostrarMayor.Click += new System.EventHandler(this.bMostrarMayor_Click);
            // 
            // bMostrarVector
            // 
            this.bMostrarVector.Location = new System.Drawing.Point(110, 279);
            this.bMostrarVector.Name = "bMostrarVector";
            this.bMostrarVector.Size = new System.Drawing.Size(126, 23);
            this.bMostrarVector.TabIndex = 3;
            this.bMostrarVector.Text = "Mostrar Vector";
            this.bMostrarVector.UseVisualStyleBackColor = true;
            this.bMostrarVector.Click += new System.EventHandler(this.bMostrarVector_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bMostrarVector);
            this.Controls.Add(this.bMostrarMayor);
            this.Controls.Add(this.bMostrarMenor);
            this.Controls.Add(this.bLeerVector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bLeerVector;
        private System.Windows.Forms.Button bMostrarMenor;
        private System.Windows.Forms.Button bMostrarMayor;
        private System.Windows.Forms.Button bMostrarVector;
    }
}

