﻿
namespace Proyect_Didactic_Learning
{
    partial class Sociales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sociales));
            this.Lblpregsociales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lblpregsociales
            // 
            this.Lblpregsociales.AutoSize = true;
            this.Lblpregsociales.BackColor = System.Drawing.SystemColors.Window;
            this.Lblpregsociales.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblpregsociales.Location = new System.Drawing.Point(190, 40);
            this.Lblpregsociales.Name = "Lblpregsociales";
            this.Lblpregsociales.Size = new System.Drawing.Size(189, 21);
            this.Lblpregsociales.TabIndex = 1;
            this.Lblpregsociales.Text = "PREGUNTA DE SOCIALES";
            // 
            // Sociales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.Lblpregsociales);
            this.Name = "Sociales";
            this.Text = "Sociales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblpregsociales;
    }
}