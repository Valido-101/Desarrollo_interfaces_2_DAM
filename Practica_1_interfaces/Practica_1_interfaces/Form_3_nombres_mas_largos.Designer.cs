namespace Practica_1_interfaces
{
    partial class Form_3_nombres_mas_largos
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
            this.lstbox_nombres_mas_largos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstbox_nombres_mas_largos
            // 
            this.lstbox_nombres_mas_largos.FormattingEnabled = true;
            this.lstbox_nombres_mas_largos.Location = new System.Drawing.Point(-1, -1);
            this.lstbox_nombres_mas_largos.Name = "lstbox_nombres_mas_largos";
            this.lstbox_nombres_mas_largos.Size = new System.Drawing.Size(280, 147);
            this.lstbox_nombres_mas_largos.TabIndex = 0;
            // 
            // Form_3_nombres_mas_largos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 143);
            this.Controls.Add(this.lstbox_nombres_mas_largos);
            this.Name = "Form_3_nombres_mas_largos";
            this.Text = "Los 3 nombres más largos";
            this.Load += new System.EventHandler(this.Form_3_nombres_mas_largos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox_nombres_mas_largos;
    }
}