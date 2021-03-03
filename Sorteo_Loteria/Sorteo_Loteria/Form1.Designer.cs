
namespace Sorteo_Loteria
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
            this.bIntroducirN = new System.Windows.Forms.Button();
            this.bComenzarS = new System.Windows.Forms.Button();
            this.bMostrarR = new System.Windows.Forms.Button();
            this.bComparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bIntroducirN
            // 
            this.bIntroducirN.Location = new System.Drawing.Point(141, 55);
            this.bIntroducirN.Name = "bIntroducirN";
            this.bIntroducirN.Size = new System.Drawing.Size(125, 23);
            this.bIntroducirN.TabIndex = 0;
            this.bIntroducirN.Text = "Introducir Números";
            this.bIntroducirN.UseVisualStyleBackColor = true;
            this.bIntroducirN.Click += new System.EventHandler(this.bIntroducirN_Click);
            // 
            // bComenzarS
            // 
            this.bComenzarS.Location = new System.Drawing.Point(141, 116);
            this.bComenzarS.Name = "bComenzarS";
            this.bComenzarS.Size = new System.Drawing.Size(125, 23);
            this.bComenzarS.TabIndex = 1;
            this.bComenzarS.Text = "Comenzar Sorteo";
            this.bComenzarS.UseVisualStyleBackColor = true;
            // 
            // bMostrarR
            // 
            this.bMostrarR.Location = new System.Drawing.Point(141, 168);
            this.bMostrarR.Name = "bMostrarR";
            this.bMostrarR.Size = new System.Drawing.Size(125, 23);
            this.bMostrarR.TabIndex = 2;
            this.bMostrarR.Text = "Mostrar Números";
            this.bMostrarR.UseVisualStyleBackColor = true;
            // 
            // bComparar
            // 
            this.bComparar.Location = new System.Drawing.Point(141, 232);
            this.bComparar.Name = "bComparar";
            this.bComparar.Size = new System.Drawing.Size(125, 23);
            this.bComparar.TabIndex = 3;
            this.bComparar.Text = "Comparar Resultado";
            this.bComparar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bComparar);
            this.Controls.Add(this.bMostrarR);
            this.Controls.Add(this.bComenzarS);
            this.Controls.Add(this.bIntroducirN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bIntroducirN;
        private System.Windows.Forms.Button bComenzarS;
        private System.Windows.Forms.Button bMostrarR;
        private System.Windows.Forms.Button bComparar;
    }
}

