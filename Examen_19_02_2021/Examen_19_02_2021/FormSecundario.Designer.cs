
namespace Examen_19_02_2021
{
    partial class FormSecundario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecundario));
            this.comboboxClientes = new System.Windows.Forms.ComboBox();
            this.lstboxPatines = new System.Windows.Forms.ListBox();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboboxClientes
            // 
            this.comboboxClientes.FormattingEnabled = true;
            this.comboboxClientes.Location = new System.Drawing.Point(139, 162);
            this.comboboxClientes.Name = "comboboxClientes";
            this.comboboxClientes.Size = new System.Drawing.Size(121, 21);
            this.comboboxClientes.TabIndex = 0;
            this.comboboxClientes.SelectedIndexChanged += new System.EventHandler(this.comboboxClientes_SelectedIndexChanged);
            // 
            // lstboxPatines
            // 
            this.lstboxPatines.FormattingEnabled = true;
            this.lstboxPatines.Location = new System.Drawing.Point(441, 129);
            this.lstboxPatines.Name = "lstboxPatines";
            this.lstboxPatines.Size = new System.Drawing.Size(120, 95);
            this.lstboxPatines.TabIndex = 1;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(324, 296);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 2;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // FormSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.lstboxPatines);
            this.Controls.Add(this.comboboxClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSecundario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Secundaria";
            this.Load += new System.EventHandler(this.FormSecundario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboboxClientes;
        private System.Windows.Forms.ListBox lstboxPatines;
        private System.Windows.Forms.Button btnDevolver;
    }
}