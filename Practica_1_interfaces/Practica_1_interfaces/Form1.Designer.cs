namespace Practica_1_interfaces
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
            this.btn_insertar_persona = new System.Windows.Forms.Button();
            this.btn_mostrar_personas = new System.Windows.Forms.Button();
            this.btn_consultar_por_dni = new System.Windows.Forms.Button();
            this.btn_mostrar_3_nombres_mas_largos = new System.Windows.Forms.Button();
            this.btn_mostrar_personas_con_algun_dato_vacio = new System.Windows.Forms.Button();
            this.btn_salir_aplicacion = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btn_insertar_persona
            // 
            this.btn_insertar_persona.Location = new System.Drawing.Point(72, 76);
            this.btn_insertar_persona.Name = "btn_insertar_persona";
            this.btn_insertar_persona.Size = new System.Drawing.Size(188, 23);
            this.btn_insertar_persona.TabIndex = 0;
            this.btn_insertar_persona.Text = "Insertar Persona";
            this.btn_insertar_persona.UseVisualStyleBackColor = true;
            this.btn_insertar_persona.Click += new System.EventHandler(this.btn_insertar_persona_Click);
            // 
            // btn_mostrar_personas
            // 
            this.btn_mostrar_personas.Location = new System.Drawing.Point(72, 134);
            this.btn_mostrar_personas.Name = "btn_mostrar_personas";
            this.btn_mostrar_personas.Size = new System.Drawing.Size(188, 23);
            this.btn_mostrar_personas.TabIndex = 1;
            this.btn_mostrar_personas.Text = "Mostrar Listado de Personas";
            this.btn_mostrar_personas.UseVisualStyleBackColor = true;
            this.btn_mostrar_personas.Click += new System.EventHandler(this.btn_mostrar_personas_Click);
            // 
            // btn_consultar_por_dni
            // 
            this.btn_consultar_por_dni.Location = new System.Drawing.Point(72, 197);
            this.btn_consultar_por_dni.Name = "btn_consultar_por_dni";
            this.btn_consultar_por_dni.Size = new System.Drawing.Size(188, 23);
            this.btn_consultar_por_dni.TabIndex = 2;
            this.btn_consultar_por_dni.Text = "Consultar Persona por DNI";
            this.btn_consultar_por_dni.UseVisualStyleBackColor = true;
            this.btn_consultar_por_dni.Click += new System.EventHandler(this.btn_consultar_por_dni_Click);
            // 
            // btn_mostrar_3_nombres_mas_largos
            // 
            this.btn_mostrar_3_nombres_mas_largos.Location = new System.Drawing.Point(541, 76);
            this.btn_mostrar_3_nombres_mas_largos.Name = "btn_mostrar_3_nombres_mas_largos";
            this.btn_mostrar_3_nombres_mas_largos.Size = new System.Drawing.Size(188, 23);
            this.btn_mostrar_3_nombres_mas_largos.TabIndex = 3;
            this.btn_mostrar_3_nombres_mas_largos.Text = "Mostrar 3 nombres más largos";
            this.btn_mostrar_3_nombres_mas_largos.UseVisualStyleBackColor = true;
            this.btn_mostrar_3_nombres_mas_largos.Click += new System.EventHandler(this.btn_mostrar_3_nombres_mas_largos_Click);
            // 
            // btn_mostrar_personas_con_algun_dato_vacio
            // 
            this.btn_mostrar_personas_con_algun_dato_vacio.Location = new System.Drawing.Point(541, 134);
            this.btn_mostrar_personas_con_algun_dato_vacio.Name = "btn_mostrar_personas_con_algun_dato_vacio";
            this.btn_mostrar_personas_con_algun_dato_vacio.Size = new System.Drawing.Size(188, 23);
            this.btn_mostrar_personas_con_algun_dato_vacio.TabIndex = 4;
            this.btn_mostrar_personas_con_algun_dato_vacio.Text = "Mostrar Personas con datos vacíos";
            this.btn_mostrar_personas_con_algun_dato_vacio.UseVisualStyleBackColor = true;
            this.btn_mostrar_personas_con_algun_dato_vacio.Click += new System.EventHandler(this.btn_mostrar_personas_con_algun_dato_vacio_Click);
            // 
            // btn_salir_aplicacion
            // 
            this.btn_salir_aplicacion.Location = new System.Drawing.Point(541, 197);
            this.btn_salir_aplicacion.Name = "btn_salir_aplicacion";
            this.btn_salir_aplicacion.Size = new System.Drawing.Size(188, 23);
            this.btn_salir_aplicacion.TabIndex = 5;
            this.btn_salir_aplicacion.Text = "Salir";
            this.btn_salir_aplicacion.UseVisualStyleBackColor = true;
            this.btn_salir_aplicacion.Click += new System.EventHandler(this.btn_salir_aplicacion_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Usuario\\source\\repos\\Practica_1_interfaces\\Practica_1_interfaces\\bin\\Deb" +
    "ug\\Manual de Ayuda de Usuario.chm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salir_aplicacion);
            this.Controls.Add(this.btn_mostrar_personas_con_algun_dato_vacio);
            this.Controls.Add(this.btn_mostrar_3_nombres_mas_largos);
            this.Controls.Add(this.btn_consultar_por_dni);
            this.Controls.Add(this.btn_mostrar_personas);
            this.Controls.Add(this.btn_insertar_persona);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Programa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_insertar_persona;
        private System.Windows.Forms.Button btn_mostrar_personas;
        private System.Windows.Forms.Button btn_consultar_por_dni;
        private System.Windows.Forms.Button btn_mostrar_3_nombres_mas_largos;
        private System.Windows.Forms.Button btn_mostrar_personas_con_algun_dato_vacio;
        private System.Windows.Forms.Button btn_salir_aplicacion;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

