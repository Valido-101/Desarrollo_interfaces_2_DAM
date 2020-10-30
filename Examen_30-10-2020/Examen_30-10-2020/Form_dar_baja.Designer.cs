namespace Examen_30_10_2020
{
    partial class Form_dar_baja
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
            this.lstbox_socios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_buscar_nombre_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_aceptar_baja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbox_socios
            // 
            this.lstbox_socios.FormattingEnabled = true;
            this.lstbox_socios.Location = new System.Drawing.Point(12, 35);
            this.lstbox_socios.Name = "lstbox_socios";
            this.lstbox_socios.Size = new System.Drawing.Size(219, 277);
            this.lstbox_socios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Socios:";
            // 
            // txtbox_buscar_nombre_apellido
            // 
            this.txtbox_buscar_nombre_apellido.Location = new System.Drawing.Point(350, 147);
            this.txtbox_buscar_nombre_apellido.Name = "txtbox_buscar_nombre_apellido";
            this.txtbox_buscar_nombre_apellido.Size = new System.Drawing.Size(100, 20);
            this.txtbox_buscar_nombre_apellido.TabIndex = 2;
            this.txtbox_buscar_nombre_apellido.TextChanged += new System.EventHandler(this.txtbox_buscar_nombre_apellido_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre/Apellidos:";
            // 
            // btn_aceptar_baja
            // 
            this.btn_aceptar_baja.Location = new System.Drawing.Point(483, 145);
            this.btn_aceptar_baja.Name = "btn_aceptar_baja";
            this.btn_aceptar_baja.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar_baja.TabIndex = 4;
            this.btn_aceptar_baja.Text = "Dar de Baja";
            this.btn_aceptar_baja.UseVisualStyleBackColor = true;
            this.btn_aceptar_baja.Click += new System.EventHandler(this.btn_aceptar_baja_Click);
            // 
            // Form_dar_baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 320);
            this.Controls.Add(this.btn_aceptar_baja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_buscar_nombre_apellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbox_socios);
            this.Name = "Form_dar_baja";
            this.Text = "Darse de Baja";
            this.Load += new System.EventHandler(this.Form_dar_baja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox_socios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_buscar_nombre_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_aceptar_baja;
    }
}