
namespace Examen_enero
{
    partial class AlquilarVideojuego
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
            this.lstbox_videojuegos = new System.Windows.Forms.ListBox();
            this.lstbox_clientes = new System.Windows.Forms.ListBox();
            this.btn_alquilar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbox_videojuegos
            // 
            this.lstbox_videojuegos.FormattingEnabled = true;
            this.lstbox_videojuegos.Location = new System.Drawing.Point(69, 104);
            this.lstbox_videojuegos.Name = "lstbox_videojuegos";
            this.lstbox_videojuegos.Size = new System.Drawing.Size(240, 225);
            this.lstbox_videojuegos.TabIndex = 0;
            // 
            // lstbox_clientes
            // 
            this.lstbox_clientes.FormattingEnabled = true;
            this.lstbox_clientes.Location = new System.Drawing.Point(364, 104);
            this.lstbox_clientes.Name = "lstbox_clientes";
            this.lstbox_clientes.Size = new System.Drawing.Size(232, 225);
            this.lstbox_clientes.TabIndex = 1;
            // 
            // btn_alquilar
            // 
            this.btn_alquilar.Location = new System.Drawing.Point(646, 205);
            this.btn_alquilar.Name = "btn_alquilar";
            this.btn_alquilar.Size = new System.Drawing.Size(75, 23);
            this.btn_alquilar.TabIndex = 2;
            this.btn_alquilar.Text = "Alquilar";
            this.btn_alquilar.UseVisualStyleBackColor = true;
            this.btn_alquilar.Click += new System.EventHandler(this.btn_alquilar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Videojuegos Disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clientes";
            // 
            // AlquilarVideojuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Examen_enero.Properties.Resources._584596105a243;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_alquilar);
            this.Controls.Add(this.lstbox_clientes);
            this.Controls.Add(this.lstbox_videojuegos);
            this.Name = "AlquilarVideojuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquilar Videojuego";
            this.Load += new System.EventHandler(this.AlquilarVideojuego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox_videojuegos;
        private System.Windows.Forms.ListBox lstbox_clientes;
        private System.Windows.Forms.Button btn_alquilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}