
namespace Examen_enero
{
    partial class DevolverVideojuegos
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
            this.lstbox_clientesConVideojuegos = new System.Windows.Forms.ListBox();
            this.btn_devolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbox_clientesConVideojuegos
            // 
            this.lstbox_clientesConVideojuegos.FormattingEnabled = true;
            this.lstbox_clientesConVideojuegos.Location = new System.Drawing.Point(164, 99);
            this.lstbox_clientesConVideojuegos.Name = "lstbox_clientesConVideojuegos";
            this.lstbox_clientesConVideojuegos.Size = new System.Drawing.Size(261, 95);
            this.lstbox_clientesConVideojuegos.TabIndex = 0;
            // 
            // btn_devolver
            // 
            this.btn_devolver.Location = new System.Drawing.Point(491, 139);
            this.btn_devolver.Name = "btn_devolver";
            this.btn_devolver.Size = new System.Drawing.Size(75, 23);
            this.btn_devolver.TabIndex = 1;
            this.btn_devolver.Text = "Devolver";
            this.btn_devolver.UseVisualStyleBackColor = true;
            this.btn_devolver.Click += new System.EventHandler(this.btn_devolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clientes con Videojuegos";
            // 
            // DevolverVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_devolver);
            this.Controls.Add(this.lstbox_clientesConVideojuegos);
            this.Name = "DevolverVideojuegos";
            this.Text = "DevolverVideojuegos";
            this.Load += new System.EventHandler(this.DevolverVideojuegos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox_clientesConVideojuegos;
        private System.Windows.Forms.Button btn_devolver;
        private System.Windows.Forms.Label label1;
    }
}