﻿
namespace Proyect_Didactic_Learning
{
    partial class Ciencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ciencia));
            this.Lblpregciencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lblpregciencia
            // 
            this.Lblpregciencia.AutoSize = true;
            this.Lblpregciencia.BackColor = System.Drawing.SystemColors.Window;
            this.Lblpregciencia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblpregciencia.Location = new System.Drawing.Point(190, 40);
            this.Lblpregciencia.Name = "Lblpregciencia";
            this.Lblpregciencia.Size = new System.Drawing.Size(178, 21);
            this.Lblpregciencia.TabIndex = 1;
            this.Lblpregciencia.Text = "PREGUNTA DE CIENCIA";
            // 
            // Ciencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.Lblpregciencia);
            this.Name = "Ciencia";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblpregciencia;
    }
}

