namespace Practica_2_arreglo
{
    partial class Crear_agenda
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_box_annio_agenda = new System.Windows.Forms.TextBox();
            this.txt_box_nombre_agenda = new System.Windows.Forms.TextBox();
            this.btn_crear_agenda = new System.Windows.Forms.Button();
            this.agendaDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miagendaDataSet = new Practica_2_arreglo.miagendaDataSet();
            this.agendaTableAdapter = new Practica_2_arreglo.miagendaDataSetTableAdapters.agendaTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // txt_box_annio_agenda
            // 
            this.txt_box_annio_agenda.Location = new System.Drawing.Point(569, 204);
            this.txt_box_annio_agenda.Name = "txt_box_annio_agenda";
            this.txt_box_annio_agenda.Size = new System.Drawing.Size(100, 20);
            this.txt_box_annio_agenda.TabIndex = 11;
            // 
            // txt_box_nombre_agenda
            // 
            this.txt_box_nombre_agenda.Location = new System.Drawing.Point(569, 156);
            this.txt_box_nombre_agenda.Name = "txt_box_nombre_agenda";
            this.txt_box_nombre_agenda.Size = new System.Drawing.Size(100, 20);
            this.txt_box_nombre_agenda.TabIndex = 10;
            // 
            // btn_crear_agenda
            // 
            this.btn_crear_agenda.Location = new System.Drawing.Point(569, 261);
            this.btn_crear_agenda.Name = "btn_crear_agenda";
            this.btn_crear_agenda.Size = new System.Drawing.Size(100, 23);
            this.btn_crear_agenda.TabIndex = 9;
            this.btn_crear_agenda.Text = "Crear";
            this.btn_crear_agenda.UseVisualStyleBackColor = true;
            this.btn_crear_agenda.Click += new System.EventHandler(this.btn_crear_agenda_Click);
            // 
            // agendaDataGridView
            // 
            this.agendaDataGridView.AutoGenerateColumns = false;
            this.agendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.annioDataGridViewTextBoxColumn});
            this.agendaDataGridView.DataSource = this.agendaBindingSource;
            this.agendaDataGridView.Location = new System.Drawing.Point(35, 100);
            this.agendaDataGridView.Name = "agendaDataGridView";
            this.agendaDataGridView.Size = new System.Drawing.Size(344, 290);
            this.agendaDataGridView.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // annioDataGridViewTextBoxColumn
            // 
            this.annioDataGridViewTextBoxColumn.DataPropertyName = "annio";
            this.annioDataGridViewTextBoxColumn.HeaderText = "annio";
            this.annioDataGridViewTextBoxColumn.Name = "annioDataGridViewTextBoxColumn";
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "agenda";
            this.agendaBindingSource.DataSource = this.miagendaDataSet;
            // 
            // miagendaDataSet
            // 
            this.miagendaDataSet.DataSetName = "miagendaDataSet";
            this.miagendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Agendas:";
            // 
            // Crear_agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_box_annio_agenda);
            this.Controls.Add(this.txt_box_nombre_agenda);
            this.Controls.Add(this.btn_crear_agenda);
            this.Controls.Add(this.agendaDataGridView);
            this.Name = "Crear_agenda";
            this.Text = "Crear_agenda";
            this.Load += new System.EventHandler(this.Crear_agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_box_annio_agenda;
        private System.Windows.Forms.TextBox txt_box_nombre_agenda;
        private System.Windows.Forms.Button btn_crear_agenda;
        private System.Windows.Forms.DataGridView agendaDataGridView;
        private miagendaDataSet miagendaDataSet;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private miagendaDataSetTableAdapters.agendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
    }
}