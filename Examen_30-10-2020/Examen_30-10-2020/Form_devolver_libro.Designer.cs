namespace Examen_30_10_2020
{
    partial class Form_devolver_libro
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
            this.components = new System.ComponentModel.Container();
            this.datagrid_socios = new System.Windows.Forms.DataGridView();
            this.btn_devolver_libros = new System.Windows.Forms.Button();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_socios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_socios
            // 
            this.datagrid_socios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_socios.Location = new System.Drawing.Point(47, 97);
            this.datagrid_socios.Name = "datagrid_socios";
            this.datagrid_socios.Size = new System.Drawing.Size(344, 150);
            this.datagrid_socios.TabIndex = 0;
            // 
            // btn_devolver_libros
            // 
            this.btn_devolver_libros.Location = new System.Drawing.Point(520, 172);
            this.btn_devolver_libros.Name = "btn_devolver_libros";
            this.btn_devolver_libros.Size = new System.Drawing.Size(96, 23);
            this.btn_devolver_libros.TabIndex = 1;
            this.btn_devolver_libros.Text = "Devolver Libros";
            this.btn_devolver_libros.UseVisualStyleBackColor = true;
            this.btn_devolver_libros.Click += new System.EventHandler(this.btn_devolver_libros_Click);
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataSource = typeof(Examen_30_10_2020.Socio);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un socio para que devuelva sus libros:";
            // 
            // Form_devolver_libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_devolver_libros);
            this.Controls.Add(this.datagrid_socios);
            this.Name = "Form_devolver_libro";
            this.Text = "Devolución de Libro";
            this.Load += new System.EventHandler(this.Form_devolver_libro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_socios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_socios;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private System.Windows.Forms.Button btn_devolver_libros;
        private System.Windows.Forms.Label label1;
    }
}