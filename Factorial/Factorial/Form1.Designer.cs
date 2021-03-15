
namespace Factorial
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
            this.bNumero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tNum = new System.Windows.Forms.TextBox();
            this.bMostrarFactorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduce un número:";
            // 
            // tNum
            // 
            this.tNum.Location = new System.Drawing.Point(180, 121);
            this.tNum.Name = "tNum";
            this.tNum.Size = new System.Drawing.Size(100, 20);
            this.tNum.TabIndex = 2;
            // 
            // bMostrarFactorial
            // 
            this.bMostrarFactorial.Location = new System.Drawing.Point(186, 231);
            this.bMostrarFactorial.Name = "bMostrarFactorial";
            this.bMostrarFactorial.Size = new System.Drawing.Size(94, 23);
            this.bMostrarFactorial.TabIndex = 3;
            this.bMostrarFactorial.Text = "Mostrar Factorial";
            this.bMostrarFactorial.UseVisualStyleBackColor = true;
            this.bMostrarFactorial.Click += new System.EventHandler(this.bMostrarFactorial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bMostrarFactorial);
            this.Controls.Add(this.tNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNum;
        private System.Windows.Forms.Button bMostrarFactorial;
    }
}

