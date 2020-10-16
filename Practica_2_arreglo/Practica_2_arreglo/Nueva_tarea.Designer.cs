namespace Practica_2_arreglo
{
    partial class Nueva_tarea
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miagendaDataSet = new Practica_2_arreglo.miagendaDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_box_id_agenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_box_lugar = new System.Windows.Forms.TextBox();
            this.txt_box_descripcion = new System.Windows.Forms.TextBox();
            this.txt_box_hora = new System.Windows.Forms.TextBox();
            this.txt_box_mes = new System.Windows.Forms.TextBox();
            this.txt_box_dia = new System.Windows.Forms.TextBox();
            this.btn_crear_tarea = new System.Windows.Forms.Button();
            this.agendaTableAdapter = new Practica_2_arreglo.miagendaDataSetTableAdapters.agendaTableAdapter();
            this.tareaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tareaTableAdapter = new Practica_2_arreglo.miagendaDataSetTableAdapters.tareaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.annioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.agendaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 150);
            this.dataGridView1.TabIndex = 33;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Agendas disponibles:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id_agenda";
            // 
            // txt_box_id_agenda
            // 
            this.txt_box_id_agenda.Location = new System.Drawing.Point(473, 146);
            this.txt_box_id_agenda.Name = "txt_box_id_agenda";
            this.txt_box_id_agenda.Size = new System.Drawing.Size(100, 20);
            this.txt_box_id_agenda.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(614, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Lugar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Día";
            // 
            // txt_box_lugar
            // 
            this.txt_box_lugar.Location = new System.Drawing.Point(669, 228);
            this.txt_box_lugar.Name = "txt_box_lugar";
            this.txt_box_lugar.Size = new System.Drawing.Size(100, 20);
            this.txt_box_lugar.TabIndex = 24;
            // 
            // txt_box_descripcion
            // 
            this.txt_box_descripcion.Location = new System.Drawing.Point(669, 189);
            this.txt_box_descripcion.Name = "txt_box_descripcion";
            this.txt_box_descripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_box_descripcion.TabIndex = 23;
            // 
            // txt_box_hora
            // 
            this.txt_box_hora.Location = new System.Drawing.Point(669, 146);
            this.txt_box_hora.Name = "txt_box_hora";
            this.txt_box_hora.Size = new System.Drawing.Size(100, 20);
            this.txt_box_hora.TabIndex = 22;
            // 
            // txt_box_mes
            // 
            this.txt_box_mes.Location = new System.Drawing.Point(473, 228);
            this.txt_box_mes.Name = "txt_box_mes";
            this.txt_box_mes.Size = new System.Drawing.Size(100, 20);
            this.txt_box_mes.TabIndex = 21;
            // 
            // txt_box_dia
            // 
            this.txt_box_dia.Location = new System.Drawing.Point(473, 190);
            this.txt_box_dia.Name = "txt_box_dia";
            this.txt_box_dia.Size = new System.Drawing.Size(100, 20);
            this.txt_box_dia.TabIndex = 20;
            // 
            // btn_crear_tarea
            // 
            this.btn_crear_tarea.Location = new System.Drawing.Point(548, 301);
            this.btn_crear_tarea.Name = "btn_crear_tarea";
            this.btn_crear_tarea.Size = new System.Drawing.Size(100, 23);
            this.btn_crear_tarea.TabIndex = 19;
            this.btn_crear_tarea.Text = "Crear Tarea";
            this.btn_crear_tarea.UseVisualStyleBackColor = true;
            this.btn_crear_tarea.Click += new System.EventHandler(this.btn_crear_tarea_Click);
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // tareaBindingSource
            // 
            this.tareaBindingSource.DataMember = "tarea";
            this.tareaBindingSource.DataSource = this.miagendaDataSet;
            // 
            // tareaTableAdapter
            // 
            this.tareaTableAdapter.ClearBeforeFill = true;
            // 
            // Nueva_tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_box_id_agenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_box_lugar);
            this.Controls.Add(this.txt_box_descripcion);
            this.Controls.Add(this.txt_box_hora);
            this.Controls.Add(this.txt_box_mes);
            this.Controls.Add(this.txt_box_dia);
            this.Controls.Add(this.btn_crear_tarea);
            this.Name = "Nueva_tarea";
            this.Text = "Nueva_tarea";
            this.Load += new System.EventHandler(this.Nueva_tarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_box_id_agenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_box_lugar;
        private System.Windows.Forms.TextBox txt_box_descripcion;
        private System.Windows.Forms.TextBox txt_box_hora;
        private System.Windows.Forms.TextBox txt_box_mes;
        private System.Windows.Forms.TextBox txt_box_dia;
        private System.Windows.Forms.Button btn_crear_tarea;
        private miagendaDataSet miagendaDataSet;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private miagendaDataSetTableAdapters.agendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.BindingSource tareaBindingSource;
        private miagendaDataSetTableAdapters.tareaTableAdapter tareaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annioDataGridViewTextBoxColumn;
    }
}