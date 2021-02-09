
namespace Ejercicios_Repaso_1
{
    partial class FormPrincipal
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
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.btnConmutar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstbox1 = new System.Windows.Forms.ListBox();
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.btnNuevoForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combobox1
            // 
            this.combobox1.FormattingEnabled = true;
            this.combobox1.Location = new System.Drawing.Point(77, 119);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(121, 21);
            this.combobox1.TabIndex = 0;
            // 
            // btnConmutar
            // 
            this.btnConmutar.Location = new System.Drawing.Point(209, 245);
            this.btnConmutar.Name = "btnConmutar";
            this.btnConmutar.Size = new System.Drawing.Size(75, 23);
            this.btnConmutar.TabIndex = 1;
            this.btnConmutar.Text = "Conmutar";
            this.btnConmutar.UseVisualStyleBackColor = true;
            this.btnConmutar.Click += new System.EventHandler(this.btnConmutar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(494, 245);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstbox1
            // 
            this.lstbox1.FormattingEnabled = true;
            this.lstbox1.Location = new System.Drawing.Point(332, 100);
            this.lstbox1.Name = "lstbox1";
            this.lstbox1.Size = new System.Drawing.Size(120, 95);
            this.lstbox1.TabIndex = 3;
            // 
            // txtboxInput
            // 
            this.txtboxInput.Location = new System.Drawing.Point(573, 120);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.Size = new System.Drawing.Size(100, 20);
            this.txtboxInput.TabIndex = 4;
            // 
            // btnNuevoForm
            // 
            this.btnNuevoForm.Location = new System.Drawing.Point(341, 245);
            this.btnNuevoForm.Name = "btnNuevoForm";
            this.btnNuevoForm.Size = new System.Drawing.Size(100, 23);
            this.btnNuevoForm.TabIndex = 5;
            this.btnNuevoForm.Text = "Nuevo Formulario";
            this.btnNuevoForm.UseVisualStyleBackColor = true;
            this.btnNuevoForm.Click += new System.EventHandler(this.btnNuevoForm_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.btnNuevoForm);
            this.Controls.Add(this.txtboxInput);
            this.Controls.Add(this.lstbox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnConmutar);
            this.Controls.Add(this.combobox1);
            this.Name = "FormPrincipal";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox1;
        private System.Windows.Forms.Button btnConmutar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstbox1;
        private System.Windows.Forms.TextBox txtboxInput;
        private System.Windows.Forms.Button btnNuevoForm;
    }
}

