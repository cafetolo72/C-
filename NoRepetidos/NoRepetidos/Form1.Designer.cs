
namespace NoRepetidos
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
            this.bIntroducir = new System.Windows.Forms.Button();
            this.bMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bIntroducir
            // 
            this.bIntroducir.Location = new System.Drawing.Point(121, 92);
            this.bIntroducir.Name = "bIntroducir";
            this.bIntroducir.Size = new System.Drawing.Size(109, 23);
            this.bIntroducir.TabIndex = 0;
            this.bIntroducir.Text = "Introducir Vector";
            this.bIntroducir.UseVisualStyleBackColor = true;
            this.bIntroducir.Click += new System.EventHandler(this.bIntroducir_Click);
            // 
            // bMostrar
            // 
            this.bMostrar.Location = new System.Drawing.Point(114, 196);
            this.bMostrar.Name = "bMostrar";
            this.bMostrar.Size = new System.Drawing.Size(116, 23);
            this.bMostrar.TabIndex = 1;
            this.bMostrar.Text = "Mostrar Vector";
            this.bMostrar.UseVisualStyleBackColor = true;
            this.bMostrar.Click += new System.EventHandler(this.bMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bMostrar);
            this.Controls.Add(this.bIntroducir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bIntroducir;
        private System.Windows.Forms.Button bMostrar;
    }
}

