
namespace Ejerciciosprueba3
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
            this.bMostrarVector = new System.Windows.Forms.Button();
            this.bMostrarMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLeerVector
            // 
            this.bLeerVector.Location = new System.Drawing.Point(106, 67);
            this.bLeerVector.Name = "bLeerVector";
            this.bLeerVector.Size = new System.Drawing.Size(140, 23);
            this.bLeerVector.TabIndex = 0;
            this.bLeerVector.Text = "Introducir números";
            this.bLeerVector.UseVisualStyleBackColor = true;
            this.bLeerVector.Click += new System.EventHandler(this.bLeerVector_Click);
            // 
            // bMostrarVector
            // 
            this.bMostrarVector.Location = new System.Drawing.Point(109, 131);
            this.bMostrarVector.Name = "bMostrarVector";
            this.bMostrarVector.Size = new System.Drawing.Size(137, 23);
            this.bMostrarVector.TabIndex = 1;
            this.bMostrarVector.Text = "Mostrar vector ";
            this.bMostrarVector.UseVisualStyleBackColor = true;
            this.bMostrarVector.Click += new System.EventHandler(this.bMostrarVector_Click);
            // 
            // bMostrarMedia
            // 
            this.bMostrarMedia.Location = new System.Drawing.Point(109, 201);
            this.bMostrarMedia.Name = "bMostrarMedia";
            this.bMostrarMedia.Size = new System.Drawing.Size(137, 23);
            this.bMostrarMedia.TabIndex = 2;
            this.bMostrarMedia.Text = "Mostrar Media";
            this.bMostrarMedia.UseVisualStyleBackColor = true;
            this.bMostrarMedia.Click += new System.EventHandler(this.bMostrarMedia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bMostrarMedia);
            this.Controls.Add(this.bMostrarVector);
            this.Controls.Add(this.bLeerVector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bLeerVector;
        private System.Windows.Forms.Button bMostrarVector;
        private System.Windows.Forms.Button bMostrarMedia;
    }
}

