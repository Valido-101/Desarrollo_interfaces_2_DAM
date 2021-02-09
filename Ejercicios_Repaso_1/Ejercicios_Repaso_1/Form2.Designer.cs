
namespace Ejercicios_Repaso_1
{
    partial class Form2
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
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.lstbox1 = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConmutar = new System.Windows.Forms.Button();
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtboxInput
            // 
            this.txtboxInput.Location = new System.Drawing.Point(598, 161);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.Size = new System.Drawing.Size(100, 20);
            this.txtboxInput.TabIndex = 10;
            // 
            // lstbox1
            // 
            this.lstbox1.FormattingEnabled = true;
            this.lstbox1.Location = new System.Drawing.Point(357, 141);
            this.lstbox1.Name = "lstbox1";
            this.lstbox1.Size = new System.Drawing.Size(120, 95);
            this.lstbox1.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(519, 286);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnConmutar
            // 
            this.btnConmutar.Location = new System.Drawing.Point(234, 286);
            this.btnConmutar.Name = "btnConmutar";
            this.btnConmutar.Size = new System.Drawing.Size(75, 23);
            this.btnConmutar.TabIndex = 7;
            this.btnConmutar.Text = "Conmutar";
            this.btnConmutar.UseVisualStyleBackColor = true;
            this.btnConmutar.Click += new System.EventHandler(this.btnConmutar_Click);
            // 
            // combobox1
            // 
            this.combobox1.FormattingEnabled = true;
            this.combobox1.Location = new System.Drawing.Point(102, 160);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(121, 21);
            this.combobox1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxInput);
            this.Controls.Add(this.lstbox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnConmutar);
            this.Controls.Add(this.combobox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxInput;
        private System.Windows.Forms.ListBox lstbox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConmutar;
        private System.Windows.Forms.ComboBox combobox1;
    }
}