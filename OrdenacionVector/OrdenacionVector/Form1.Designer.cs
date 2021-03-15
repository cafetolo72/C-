
namespace OrdenacionVector
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
            this.bBuscar = new System.Windows.Forms.Button();
            this.bOrdenar = new System.Windows.Forms.Button();
            this.bMostrarV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bIntroducir
            // 
            this.bIntroducir.Location = new System.Drawing.Point(81, 83);
            this.bIntroducir.Name = "bIntroducir";
            this.bIntroducir.Size = new System.Drawing.Size(114, 23);
            this.bIntroducir.TabIndex = 0;
            this.bIntroducir.Text = "Introducir Vector ";
            this.bIntroducir.UseVisualStyleBackColor = true;
            this.bIntroducir.Click += new System.EventHandler(this.bIntroducir_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(81, 153);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(114, 23);
            this.bBuscar.TabIndex = 1;
            this.bBuscar.Text = "Buscar Elemento";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bOrdenar
            // 
            this.bOrdenar.Location = new System.Drawing.Point(82, 223);
            this.bOrdenar.Name = "bOrdenar";
            this.bOrdenar.Size = new System.Drawing.Size(113, 23);
            this.bOrdenar.TabIndex = 2;
            this.bOrdenar.Text = "Ordenar Vector";
            this.bOrdenar.UseVisualStyleBackColor = true;
            this.bOrdenar.Click += new System.EventHandler(this.bOrdenar_Click);
            // 
            // bMostrarV
            // 
            this.bMostrarV.Location = new System.Drawing.Point(87, 304);
            this.bMostrarV.Name = "bMostrarV";
            this.bMostrarV.Size = new System.Drawing.Size(108, 23);
            this.bMostrarV.TabIndex = 3;
            this.bMostrarV.Text = "Mostrar Vector";
            this.bMostrarV.UseVisualStyleBackColor = true;
            this.bMostrarV.Click += new System.EventHandler(this.bMostrarV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bMostrarV);
            this.Controls.Add(this.bOrdenar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bIntroducir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bIntroducir;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bOrdenar;
        private System.Windows.Forms.Button bMostrarV;
    }
}

