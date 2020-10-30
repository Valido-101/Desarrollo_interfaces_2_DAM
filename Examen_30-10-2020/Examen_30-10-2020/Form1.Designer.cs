namespace Examen_30_10_2020
{
    partial class form_inicio
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
            this.btn_alta_usuario = new System.Windows.Forms.Button();
            this.btn_baja_usuario = new System.Windows.Forms.Button();
            this.btn_sacar_libro = new System.Windows.Forms.Button();
            this.btn_devolver_libro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_alta_usuario
            // 
            this.btn_alta_usuario.Location = new System.Drawing.Point(126, 92);
            this.btn_alta_usuario.Name = "btn_alta_usuario";
            this.btn_alta_usuario.Size = new System.Drawing.Size(86, 23);
            this.btn_alta_usuario.TabIndex = 0;
            this.btn_alta_usuario.Text = "Darse de Alta";
            this.btn_alta_usuario.UseVisualStyleBackColor = true;
            this.btn_alta_usuario.Click += new System.EventHandler(this.btn_alta_usuario_Click);
            // 
            // btn_baja_usuario
            // 
            this.btn_baja_usuario.Location = new System.Drawing.Point(326, 92);
            this.btn_baja_usuario.Name = "btn_baja_usuario";
            this.btn_baja_usuario.Size = new System.Drawing.Size(86, 23);
            this.btn_baja_usuario.TabIndex = 1;
            this.btn_baja_usuario.Text = "Darse de Baja";
            this.btn_baja_usuario.UseVisualStyleBackColor = true;
            this.btn_baja_usuario.Click += new System.EventHandler(this.btn_baja_usuario_Click);
            // 
            // btn_sacar_libro
            // 
            this.btn_sacar_libro.Location = new System.Drawing.Point(126, 157);
            this.btn_sacar_libro.Name = "btn_sacar_libro";
            this.btn_sacar_libro.Size = new System.Drawing.Size(86, 23);
            this.btn_sacar_libro.TabIndex = 2;
            this.btn_sacar_libro.Text = "Sacar Libro";
            this.btn_sacar_libro.UseVisualStyleBackColor = true;
            this.btn_sacar_libro.Click += new System.EventHandler(this.btn_sacar_libro_Click);
            // 
            // btn_devolver_libro
            // 
            this.btn_devolver_libro.Location = new System.Drawing.Point(326, 157);
            this.btn_devolver_libro.Name = "btn_devolver_libro";
            this.btn_devolver_libro.Size = new System.Drawing.Size(86, 23);
            this.btn_devolver_libro.TabIndex = 3;
            this.btn_devolver_libro.Text = "Devolver Libro";
            this.btn_devolver_libro.UseVisualStyleBackColor = true;
            // 
            // form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 299);
            this.Controls.Add(this.btn_devolver_libro);
            this.Controls.Add(this.btn_sacar_libro);
            this.Controls.Add(this.btn_baja_usuario);
            this.Controls.Add(this.btn_alta_usuario);
            this.Name = "form_inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_alta_usuario;
        private System.Windows.Forms.Button btn_baja_usuario;
        private System.Windows.Forms.Button btn_sacar_libro;
        private System.Windows.Forms.Button btn_devolver_libro;
    }
}

