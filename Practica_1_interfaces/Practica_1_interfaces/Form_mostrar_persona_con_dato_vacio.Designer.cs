namespace Practica_1_interfaces
{
    partial class Form_mostrar_persona_con_dato_vacio
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
            this.lstbox_personas_dato_vacio = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstbox_personas_dato_vacio
            // 
            this.lstbox_personas_dato_vacio.FormattingEnabled = true;
            this.lstbox_personas_dato_vacio.Location = new System.Drawing.Point(0, 2);
            this.lstbox_personas_dato_vacio.Name = "lstbox_personas_dato_vacio";
            this.lstbox_personas_dato_vacio.Size = new System.Drawing.Size(690, 316);
            this.lstbox_personas_dato_vacio.TabIndex = 0;
            // 
            // Form_mostrar_persona_con_dato_vacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 320);
            this.Controls.Add(this.lstbox_personas_dato_vacio);
            this.Name = "Form_mostrar_persona_con_dato_vacio";
            this.Text = "Mostrar persona con algún dato vacío";
            this.Load += new System.EventHandler(this.Form_mostrar_persona_con_dato_vacio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox_personas_dato_vacio;
    }
}