namespace Practica_1_interfaces
{
    partial class Form_consultar_por_dni
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_dni_persona_consulta = new System.Windows.Forms.TextBox();
            this.btn_iniciar_busqueda = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca el DNI de la persona que desee ver";
            // 
            // txtbox_dni_persona_consulta
            // 
            this.txtbox_dni_persona_consulta.Location = new System.Drawing.Point(88, 142);
            this.txtbox_dni_persona_consulta.Name = "txtbox_dni_persona_consulta";
            this.txtbox_dni_persona_consulta.Size = new System.Drawing.Size(225, 20);
            this.txtbox_dni_persona_consulta.TabIndex = 1;
            // 
            // btn_iniciar_busqueda
            // 
            this.btn_iniciar_busqueda.Location = new System.Drawing.Point(335, 140);
            this.btn_iniciar_busqueda.Name = "btn_iniciar_busqueda";
            this.btn_iniciar_busqueda.Size = new System.Drawing.Size(100, 23);
            this.btn_iniciar_busqueda.TabIndex = 2;
            this.btn_iniciar_busqueda.Text = "Iniciar búsqueda";
            this.btn_iniciar_busqueda.UseVisualStyleBackColor = true;
            this.btn_iniciar_busqueda.Click += new System.EventHandler(this.btn_iniciar_busqueda_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(192, 199);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 3;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Form_consultar_por_dni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 259);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_iniciar_busqueda);
            this.Controls.Add(this.txtbox_dni_persona_consulta);
            this.Controls.Add(this.label1);
            this.Name = "Form_consultar_por_dni";
            this.Text = "Consultar Por DNI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_dni_persona_consulta;
        private System.Windows.Forms.Button btn_iniciar_busqueda;
        private System.Windows.Forms.Button btn_cerrar;
    }
}