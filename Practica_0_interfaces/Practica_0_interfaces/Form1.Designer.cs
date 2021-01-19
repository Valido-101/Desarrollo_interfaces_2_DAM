namespace Practica_0_interfaces
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
            this.btn_crear_persona = new System.Windows.Forms.Button();
            this.btn_mostrar_persona = new System.Windows.Forms.Button();
            this.txtbox_dni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_nombre = new System.Windows.Forms.TextBox();
            this.txtbox_apellidos = new System.Windows.Forms.TextBox();
            this.txtbox_fecha_nacimiento = new System.Windows.Forms.TextBox();
            this.txtbox_peso = new System.Windows.Forms.TextBox();
            this.txtbox_altura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btn_crear_persona
            // 
            this.btn_crear_persona.Location = new System.Drawing.Point(184, 196);
            this.btn_crear_persona.Name = "btn_crear_persona";
            this.btn_crear_persona.Size = new System.Drawing.Size(119, 23);
            this.btn_crear_persona.TabIndex = 0;
            this.btn_crear_persona.Text = "Crear Persona";
            this.btn_crear_persona.UseVisualStyleBackColor = true;
            this.btn_crear_persona.Click += new System.EventHandler(this.btn_crear_persona_Click);
            // 
            // btn_mostrar_persona
            // 
            this.btn_mostrar_persona.Location = new System.Drawing.Point(554, 196);
            this.btn_mostrar_persona.Name = "btn_mostrar_persona";
            this.btn_mostrar_persona.Size = new System.Drawing.Size(130, 23);
            this.btn_mostrar_persona.TabIndex = 1;
            this.btn_mostrar_persona.Text = "Mostrar Persona";
            this.btn_mostrar_persona.UseVisualStyleBackColor = true;
            this.btn_mostrar_persona.Click += new System.EventHandler(this.btn_mostrar_persona_Click);
            // 
            // txtbox_dni
            // 
            this.txtbox_dni.Location = new System.Drawing.Point(164, 72);
            this.txtbox_dni.Name = "txtbox_dni";
            this.txtbox_dni.Size = new System.Drawing.Size(100, 20);
            this.txtbox_dni.TabIndex = 2;
            this.txtbox_dni.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI";
            this.label1.Visible = false;
            // 
            // txtbox_nombre
            // 
            this.txtbox_nombre.Location = new System.Drawing.Point(416, 71);
            this.txtbox_nombre.Name = "txtbox_nombre";
            this.txtbox_nombre.Size = new System.Drawing.Size(100, 20);
            this.txtbox_nombre.TabIndex = 4;
            this.txtbox_nombre.Visible = false;
            // 
            // txtbox_apellidos
            // 
            this.txtbox_apellidos.Location = new System.Drawing.Point(742, 72);
            this.txtbox_apellidos.Name = "txtbox_apellidos";
            this.txtbox_apellidos.Size = new System.Drawing.Size(100, 20);
            this.txtbox_apellidos.TabIndex = 5;
            this.txtbox_apellidos.Visible = false;
            // 
            // txtbox_fecha_nacimiento
            // 
            this.txtbox_fecha_nacimiento.Location = new System.Drawing.Point(164, 138);
            this.txtbox_fecha_nacimiento.Name = "txtbox_fecha_nacimiento";
            this.txtbox_fecha_nacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtbox_fecha_nacimiento.TabIndex = 6;
            this.txtbox_fecha_nacimiento.Visible = false;
            // 
            // txtbox_peso
            // 
            this.txtbox_peso.Location = new System.Drawing.Point(416, 137);
            this.txtbox_peso.Name = "txtbox_peso";
            this.txtbox_peso.Size = new System.Drawing.Size(100, 20);
            this.txtbox_peso.TabIndex = 7;
            this.txtbox_peso.Visible = false;
            // 
            // txtbox_altura
            // 
            this.txtbox_altura.Location = new System.Drawing.Point(742, 137);
            this.txtbox_altura.Name = "txtbox_altura";
            this.txtbox_altura.Size = new System.Drawing.Size(100, 20);
            this.txtbox_altura.TabIndex = 8;
            this.txtbox_altura.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apellidos";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de nacimieto";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Peso";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Altura";
            this.label6.Visible = false;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(403, 236);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_enviar.TabIndex = 14;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Visible = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Usuario\\Documents\\HelpNDoc\\Output\\chm\\Proyecto Ayuda 1.chm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 308);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_altura);
            this.Controls.Add(this.txtbox_peso);
            this.Controls.Add(this.txtbox_fecha_nacimiento);
            this.Controls.Add(this.txtbox_apellidos);
            this.Controls.Add(this.txtbox_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_dni);
            this.Controls.Add(this.btn_mostrar_persona);
            this.Controls.Add(this.btn_crear_persona);
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crear_persona;
        private System.Windows.Forms.Button btn_mostrar_persona;
        private System.Windows.Forms.TextBox txtbox_dni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_nombre;
        private System.Windows.Forms.TextBox txtbox_apellidos;
        private System.Windows.Forms.TextBox txtbox_fecha_nacimiento;
        private System.Windows.Forms.TextBox txtbox_peso;
        private System.Windows.Forms.TextBox txtbox_altura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

