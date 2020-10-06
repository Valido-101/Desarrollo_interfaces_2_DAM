namespace Practica_1_interfaces
{
    partial class Form_insertar_persona
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
            this.btn_guardar_datos_persona = new System.Windows.Forms.Button();
            this.txtbox_dni = new System.Windows.Forms.TextBox();
            this.txtbox_nombre = new System.Windows.Forms.TextBox();
            this.txtbox_apellidos = new System.Windows.Forms.TextBox();
            this.txtbox_fecha_nac = new System.Windows.Forms.TextBox();
            this.txtbox_peso = new System.Windows.Forms.TextBox();
            this.txtbox_altura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_guardar_datos_persona
            // 
            this.btn_guardar_datos_persona.Location = new System.Drawing.Point(332, 257);
            this.btn_guardar_datos_persona.Name = "btn_guardar_datos_persona";
            this.btn_guardar_datos_persona.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar_datos_persona.TabIndex = 0;
            this.btn_guardar_datos_persona.Text = "Insertar";
            this.btn_guardar_datos_persona.UseVisualStyleBackColor = true;
            this.btn_guardar_datos_persona.Click += new System.EventHandler(this.btn_guardar_datos_persona_Click);
            // 
            // txtbox_dni
            // 
            this.txtbox_dni.Location = new System.Drawing.Point(132, 67);
            this.txtbox_dni.Name = "txtbox_dni";
            this.txtbox_dni.Size = new System.Drawing.Size(100, 20);
            this.txtbox_dni.TabIndex = 1;
            // 
            // txtbox_nombre
            // 
            this.txtbox_nombre.Location = new System.Drawing.Point(405, 67);
            this.txtbox_nombre.Name = "txtbox_nombre";
            this.txtbox_nombre.Size = new System.Drawing.Size(100, 20);
            this.txtbox_nombre.TabIndex = 2;
            // 
            // txtbox_apellidos
            // 
            this.txtbox_apellidos.Location = new System.Drawing.Point(638, 67);
            this.txtbox_apellidos.Name = "txtbox_apellidos";
            this.txtbox_apellidos.Size = new System.Drawing.Size(100, 20);
            this.txtbox_apellidos.TabIndex = 3;
            // 
            // txtbox_fecha_nac
            // 
            this.txtbox_fecha_nac.Location = new System.Drawing.Point(132, 184);
            this.txtbox_fecha_nac.Name = "txtbox_fecha_nac";
            this.txtbox_fecha_nac.Size = new System.Drawing.Size(100, 20);
            this.txtbox_fecha_nac.TabIndex = 4;
            // 
            // txtbox_peso
            // 
            this.txtbox_peso.Location = new System.Drawing.Point(405, 184);
            this.txtbox_peso.Name = "txtbox_peso";
            this.txtbox_peso.Size = new System.Drawing.Size(100, 20);
            this.txtbox_peso.TabIndex = 5;
            // 
            // txtbox_altura
            // 
            this.txtbox_altura.Location = new System.Drawing.Point(638, 184);
            this.txtbox_altura.Name = "txtbox_altura";
            this.txtbox_altura.Size = new System.Drawing.Size(100, 20);
            this.txtbox_altura.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Peso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Altura";
            // 
            // Form_insertar_persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_altura);
            this.Controls.Add(this.txtbox_peso);
            this.Controls.Add(this.txtbox_fecha_nac);
            this.Controls.Add(this.txtbox_apellidos);
            this.Controls.Add(this.txtbox_nombre);
            this.Controls.Add(this.txtbox_dni);
            this.Controls.Add(this.btn_guardar_datos_persona);
            this.Name = "Form_insertar_persona";
            this.Text = "Insertar Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar_datos_persona;
        private System.Windows.Forms.TextBox txtbox_dni;
        private System.Windows.Forms.TextBox txtbox_nombre;
        private System.Windows.Forms.TextBox txtbox_apellidos;
        private System.Windows.Forms.TextBox txtbox_fecha_nac;
        private System.Windows.Forms.TextBox txtbox_peso;
        private System.Windows.Forms.TextBox txtbox_altura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}