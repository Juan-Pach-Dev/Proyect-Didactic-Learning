
namespace Proyect_Didactic_Learning.Materias
{
    partial class Quimica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quimica));
            this.Lblpregquimica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lblpregquimica
            // 
            this.Lblpregquimica.AutoSize = true;
            this.Lblpregquimica.BackColor = System.Drawing.SystemColors.Window;
            this.Lblpregquimica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblpregquimica.Location = new System.Drawing.Point(190, 40);
            this.Lblpregquimica.Name = "Lblpregquimica";
            this.Lblpregquimica.Size = new System.Drawing.Size(186, 21);
            this.Lblpregquimica.TabIndex = 0;
            this.Lblpregquimica.Text = "PREGUNTA DE QUIMICA";
            // 
            // Quimica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.Lblpregquimica);
            this.Name = "Quimica";
            this.Text = "Quimica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblpregquimica;
    }
}