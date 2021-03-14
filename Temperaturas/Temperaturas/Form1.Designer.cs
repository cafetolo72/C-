
namespace Temperaturas
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
            this.bMostrarMayor = new System.Windows.Forms.Button();
            this.bMostrarMenor = new System.Windows.Forms.Button();
            this.bMostrarMedia = new System.Windows.Forms.Button();
            this.bMostrarTemperaturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bIntroducir
            // 
            this.bIntroducir.Location = new System.Drawing.Point(109, 51);
            this.bIntroducir.Name = "bIntroducir";
            this.bIntroducir.Size = new System.Drawing.Size(162, 23);
            this.bIntroducir.TabIndex = 0;
            this.bIntroducir.Text = "Introducir Temperaturas";
            this.bIntroducir.UseVisualStyleBackColor = true;
            this.bIntroducir.Click += new System.EventHandler(this.bIntroducir_Click);
            // 
            // bMostrarMayor
            // 
            this.bMostrarMayor.Location = new System.Drawing.Point(109, 109);
            this.bMostrarMayor.Name = "bMostrarMayor";
            this.bMostrarMayor.Size = new System.Drawing.Size(162, 23);
            this.bMostrarMayor.TabIndex = 1;
            this.bMostrarMayor.Text = "Mostrar Mayor";
            this.bMostrarMayor.UseVisualStyleBackColor = true;
            this.bMostrarMayor.Click += new System.EventHandler(this.bMostrarMayor_Click);
            // 
            // bMostrarMenor
            // 
            this.bMostrarMenor.Location = new System.Drawing.Point(109, 166);
            this.bMostrarMenor.Name = "bMostrarMenor";
            this.bMostrarMenor.Size = new System.Drawing.Size(162, 23);
            this.bMostrarMenor.TabIndex = 2;
            this.bMostrarMenor.Text = "Mostrar Menor";
            this.bMostrarMenor.UseVisualStyleBackColor = true;
            this.bMostrarMenor.Click += new System.EventHandler(this.bMostrarMenor_Click);
            // 
            // bMostrarMedia
            // 
            this.bMostrarMedia.Location = new System.Drawing.Point(109, 232);
            this.bMostrarMedia.Name = "bMostrarMedia";
            this.bMostrarMedia.Size = new System.Drawing.Size(162, 23);
            this.bMostrarMedia.TabIndex = 3;
            this.bMostrarMedia.Text = "Mostrar Media";
            this.bMostrarMedia.UseVisualStyleBackColor = true;
            this.bMostrarMedia.Click += new System.EventHandler(this.bMostrarMedia_Click);
            // 
            // bMostrarTemperaturas
            // 
            this.bMostrarTemperaturas.Location = new System.Drawing.Point(109, 294);
            this.bMostrarTemperaturas.Name = "bMostrarTemperaturas";
            this.bMostrarTemperaturas.Size = new System.Drawing.Size(162, 23);
            this.bMostrarTemperaturas.TabIndex = 4;
            this.bMostrarTemperaturas.Text = "Mostrar Temperaturas";
            this.bMostrarTemperaturas.UseVisualStyleBackColor = true;
            this.bMostrarTemperaturas.Click += new System.EventHandler(this.bMostrarTemperaturas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bMostrarTemperaturas);
            this.Controls.Add(this.bMostrarMedia);
            this.Controls.Add(this.bMostrarMenor);
            this.Controls.Add(this.bMostrarMayor);
            this.Controls.Add(this.bIntroducir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bIntroducir;
        private System.Windows.Forms.Button bMostrarMayor;
        private System.Windows.Forms.Button bMostrarMenor;
        private System.Windows.Forms.Button bMostrarMedia;
        private System.Windows.Forms.Button bMostrarTemperaturas;
    }
}

