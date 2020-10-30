namespace Examen_30_10_2020
{
    partial class Form_sacar_libro
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
            this.lstbox_libros = new System.Windows.Forms.ListBox();
            this.lstbox_socios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_prestar_libro = new System.Windows.Forms.Button();
            this.txtbox_buscar_libro = new System.Windows.Forms.TextBox();
            this.txtbox_buscar_socio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbox_libros
            // 
            this.lstbox_libros.FormattingEnabled = true;
            this.lstbox_libros.Location = new System.Drawing.Point(23, 91);
            this.lstbox_libros.Name = "lstbox_libros";
            this.lstbox_libros.Size = new System.Drawing.Size(279, 290);
            this.lstbox_libros.TabIndex = 0;
            // 
            // lstbox_socios
            // 
            this.lstbox_socios.FormattingEnabled = true;
            this.lstbox_socios.Location = new System.Drawing.Point(346, 91);
            this.lstbox_socios.Name = "lstbox_socios";
            this.lstbox_socios.Size = new System.Drawing.Size(282, 290);
            this.lstbox_socios.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Título de libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Socios:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Por favor, seleccione un libro y un socio para realizar el préstamo";
            // 
            // btn_prestar_libro
            // 
            this.btn_prestar_libro.Location = new System.Drawing.Point(719, 358);
            this.btn_prestar_libro.Name = "btn_prestar_libro";
            this.btn_prestar_libro.Size = new System.Drawing.Size(100, 23);
            this.btn_prestar_libro.TabIndex = 5;
            this.btn_prestar_libro.Text = "Prestar Libro";
            this.btn_prestar_libro.UseVisualStyleBackColor = true;
            this.btn_prestar_libro.Click += new System.EventHandler(this.btn_prestar_libro_Click);
            // 
            // txtbox_buscar_libro
            // 
            this.txtbox_buscar_libro.Location = new System.Drawing.Point(719, 141);
            this.txtbox_buscar_libro.Name = "txtbox_buscar_libro";
            this.txtbox_buscar_libro.Size = new System.Drawing.Size(100, 20);
            this.txtbox_buscar_libro.TabIndex = 6;
            this.txtbox_buscar_libro.TextChanged += new System.EventHandler(this.txtbox_buscar_libro_TextChanged);
            // 
            // txtbox_buscar_socio
            // 
            this.txtbox_buscar_socio.Location = new System.Drawing.Point(719, 198);
            this.txtbox_buscar_socio.Name = "txtbox_buscar_socio";
            this.txtbox_buscar_socio.Size = new System.Drawing.Size(100, 20);
            this.txtbox_buscar_socio.TabIndex = 7;
            this.txtbox_buscar_socio.TextChanged += new System.EventHandler(this.txtbox_buscar_socio_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Utilice estos cuadros de texto para buscar un libro o socio concreto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Libro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Socio:";
            // 
            // Form_sacar_libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_buscar_socio);
            this.Controls.Add(this.txtbox_buscar_libro);
            this.Controls.Add(this.btn_prestar_libro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbox_socios);
            this.Controls.Add(this.lstbox_libros);
            this.Name = "Form_sacar_libro";
            this.Text = "Prestar Libro";
            this.Load += new System.EventHandler(this.Form_sacar_libro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox_libros;
        private System.Windows.Forms.ListBox lstbox_socios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_prestar_libro;
        private System.Windows.Forms.TextBox txtbox_buscar_libro;
        private System.Windows.Forms.TextBox txtbox_buscar_socio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}