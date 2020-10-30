namespace Examen_30_10_2020
{
    partial class Form_dar_alta
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
            this.txtbox_nombre = new System.Windows.Forms.TextBox();
            this.txtbox_apellidos = new System.Windows.Forms.TextBox();
            this.btn_aceptar_alta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbox_nombre
            // 
            this.txtbox_nombre.Location = new System.Drawing.Point(108, 28);
            this.txtbox_nombre.Name = "txtbox_nombre";
            this.txtbox_nombre.Size = new System.Drawing.Size(100, 20);
            this.txtbox_nombre.TabIndex = 0;
            // 
            // txtbox_apellidos
            // 
            this.txtbox_apellidos.Location = new System.Drawing.Point(108, 79);
            this.txtbox_apellidos.Name = "txtbox_apellidos";
            this.txtbox_apellidos.Size = new System.Drawing.Size(100, 20);
            this.txtbox_apellidos.TabIndex = 1;
            // 
            // btn_aceptar_alta
            // 
            this.btn_aceptar_alta.Location = new System.Drawing.Point(273, 51);
            this.btn_aceptar_alta.Name = "btn_aceptar_alta";
            this.btn_aceptar_alta.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar_alta.TabIndex = 2;
            this.btn_aceptar_alta.Text = "Dar de Alta";
            this.btn_aceptar_alta.UseVisualStyleBackColor = true;
            this.btn_aceptar_alta.Click += new System.EventHandler(this.btn_aceptar_alta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellidos:";
            // 
            // Form_dar_alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 143);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_aceptar_alta);
            this.Controls.Add(this.txtbox_apellidos);
            this.Controls.Add(this.txtbox_nombre);
            this.Name = "Form_dar_alta";
            this.Text = "Darse de Alta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_nombre;
        private System.Windows.Forms.TextBox txtbox_apellidos;
        private System.Windows.Forms.Button btn_aceptar_alta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}