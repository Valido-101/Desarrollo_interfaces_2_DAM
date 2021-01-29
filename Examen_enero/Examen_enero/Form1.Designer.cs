
namespace Examen_enero
{
    partial class Form_inicio
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
            this.btn_altaCliente = new System.Windows.Forms.Button();
            this.btn_alquilarVideojuego = new System.Windows.Forms.Button();
            this.btn_devolverVideojuegos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_altaCliente
            // 
            this.btn_altaCliente.Location = new System.Drawing.Point(185, 91);
            this.btn_altaCliente.Name = "btn_altaCliente";
            this.btn_altaCliente.Size = new System.Drawing.Size(122, 23);
            this.btn_altaCliente.TabIndex = 0;
            this.btn_altaCliente.Text = "Alta Cliente";
            this.btn_altaCliente.UseVisualStyleBackColor = true;
            // 
            // btn_alquilarVideojuego
            // 
            this.btn_alquilarVideojuego.Location = new System.Drawing.Point(185, 159);
            this.btn_alquilarVideojuego.Name = "btn_alquilarVideojuego";
            this.btn_alquilarVideojuego.Size = new System.Drawing.Size(122, 23);
            this.btn_alquilarVideojuego.TabIndex = 1;
            this.btn_alquilarVideojuego.Text = "Alquilar Videojuego";
            this.btn_alquilarVideojuego.UseVisualStyleBackColor = true;
            // 
            // btn_devolverVideojuegos
            // 
            this.btn_devolverVideojuegos.Location = new System.Drawing.Point(185, 227);
            this.btn_devolverVideojuegos.Name = "btn_devolverVideojuegos";
            this.btn_devolverVideojuegos.Size = new System.Drawing.Size(122, 23);
            this.btn_devolverVideojuegos.TabIndex = 2;
            this.btn_devolverVideojuegos.Text = "Devolver Videojuegos";
            this.btn_devolverVideojuegos.UseVisualStyleBackColor = true;
            // 
            // Form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_devolverVideojuegos);
            this.Controls.Add(this.btn_alquilarVideojuego);
            this.Controls.Add(this.btn_altaCliente);
            this.Name = "Form_inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_altaCliente;
        private System.Windows.Forms.Button btn_alquilarVideojuego;
        private System.Windows.Forms.Button btn_devolverVideojuegos;
    }
}

