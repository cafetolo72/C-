
namespace EjerciciosPrueba5
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
            this.bIntroducirVector = new System.Windows.Forms.Button();
            this.bPasarVector = new System.Windows.Forms.Button();
            this.bMostrarVectores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bIntroducirVector
            // 
            this.bIntroducirVector.Location = new System.Drawing.Point(152, 91);
            this.bIntroducirVector.Name = "bIntroducirVector";
            this.bIntroducirVector.Size = new System.Drawing.Size(133, 23);
            this.bIntroducirVector.TabIndex = 0;
            this.bIntroducirVector.Text = "Introducir Vector ";
            this.bIntroducirVector.UseVisualStyleBackColor = true;
            this.bIntroducirVector.Click += new System.EventHandler(this.bIntroducirVector_Click);
            // 
            // bPasarVector
            // 
            this.bPasarVector.Location = new System.Drawing.Point(150, 159);
            this.bPasarVector.Name = "bPasarVector";
            this.bPasarVector.Size = new System.Drawing.Size(135, 23);
            this.bPasarVector.TabIndex = 1;
            this.bPasarVector.Text = "Pasar a otro vector";
            this.bPasarVector.UseVisualStyleBackColor = true;
            this.bPasarVector.Click += new System.EventHandler(this.bPasarVector_Click);
            // 
            // bMostrarVectores
            // 
            this.bMostrarVectores.Location = new System.Drawing.Point(152, 225);
            this.bMostrarVectores.Name = "bMostrarVectores";
            this.bMostrarVectores.Size = new System.Drawing.Size(133, 23);
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
            this.Controls.Add(this.bPasarVector);
            this.Controls.Add(this.bIntroducirVector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bIntroducirVector;
        private System.Windows.Forms.Button bPasarVector;
        private System.Windows.Forms.Button bMostrarVectores;
    }
}

