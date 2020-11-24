namespace Practica_examen_diciembre
{
    partial class Ventana_menu
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
            this.btn_add_articulos = new System.Windows.Forms.Button();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_valor_almacen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_articulos
            // 
            this.btn_add_articulos.Location = new System.Drawing.Point(157, 52);
            this.btn_add_articulos.Name = "btn_add_articulos";
            this.btn_add_articulos.Size = new System.Drawing.Size(118, 23);
            this.btn_add_articulos.TabIndex = 0;
            this.btn_add_articulos.Text = "Añadir artículos";
            this.btn_add_articulos.UseVisualStyleBackColor = true;
            // 
            // btn_comprar
            // 
            this.btn_comprar.Location = new System.Drawing.Point(157, 100);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(118, 23);
            this.btn_comprar.TabIndex = 1;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = true;
            // 
            // btn_valor_almacen
            // 
            this.btn_valor_almacen.Location = new System.Drawing.Point(157, 154);
            this.btn_valor_almacen.Name = "btn_valor_almacen";
            this.btn_valor_almacen.Size = new System.Drawing.Size(118, 23);
            this.btn_valor_almacen.TabIndex = 2;
            this.btn_valor_almacen.Text = "Ver valor del almacén";
            this.btn_valor_almacen.UseVisualStyleBackColor = true;
            this.btn_valor_almacen.Click += new System.EventHandler(this.btn_valor_almacen_Click);
            // 
            // Ventana_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 223);
            this.Controls.Add(this.btn_valor_almacen);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.btn_add_articulos);
            this.Name = "Ventana_menu";
            this.Text = "Menú";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ventana_menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_articulos;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Button btn_valor_almacen;
    }
}

