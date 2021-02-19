
namespace Examen_19_02_2021
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstboxClientes = new System.Windows.Forms.ListBox();
            this.lstboxPatines = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiguienteForm = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstboxClientes
            // 
            this.lstboxClientes.FormattingEnabled = true;
            this.lstboxClientes.Location = new System.Drawing.Point(86, 61);
            this.lstboxClientes.Name = "lstboxClientes";
            this.lstboxClientes.Size = new System.Drawing.Size(268, 199);
            this.lstboxClientes.TabIndex = 0;
            // 
            // lstboxPatines
            // 
            this.lstboxPatines.FormattingEnabled = true;
            this.lstboxPatines.Location = new System.Drawing.Point(409, 61);
            this.lstboxPatines.Name = "lstboxPatines";
            this.lstboxPatines.Size = new System.Drawing.Size(275, 199);
            this.lstboxPatines.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de patines";
            // 
            // btnSiguienteForm
            // 
            this.btnSiguienteForm.Location = new System.Drawing.Point(329, 316);
            this.btnSiguienteForm.Name = "btnSiguienteForm";
            this.btnSiguienteForm.Size = new System.Drawing.Size(110, 23);
            this.btnSiguienteForm.TabIndex = 4;
            this.btnSiguienteForm.Text = "Devolver Patines";
            this.btnSiguienteForm.UseVisualStyleBackColor = true;
            this.btnSiguienteForm.Click += new System.EventHandler(this.btnSiguienteForm_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(159, 316);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(110, 23);
            this.btnInforme.TabIndex = 5;
            this.btnInforme.Text = "Mostrar informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Location = new System.Drawing.Point(490, 316);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(114, 23);
            this.btnAlquilar.TabIndex = 6;
            this.btnAlquilar.Text = "Alquilar Patín";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.btnAlquilar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnSiguienteForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstboxPatines);
            this.Controls.Add(this.lstboxClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxClientes;
        private System.Windows.Forms.ListBox lstboxPatines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiguienteForm;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnAlquilar;
    }
}

