namespace Practica_2_arreglo
{
    partial class Mostrar_tareas
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_box_id_agenda = new System.Windows.Forms.TextBox();
            this.btn_mostrar_tareas = new System.Windows.Forms.Button();
            this.miagendaDataSet = new Practica_2_arreglo.miagendaDataSet();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaTableAdapter = new Practica_2_arreglo.miagendaDataSetTableAdapters.agendaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tareaTableAdapter = new Practica_2_arreglo.miagendaDataSetTableAdapters.tareaTableAdapter();
            this.idagendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idagendaDataGridViewTextBoxColumn,
            this.diaDataGridViewTextBoxColumn,
            this.mesDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.lugarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tareaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.annioDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.agendaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(43, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(344, 150);
            this.dataGridView2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tareas de la agenda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Agendas disponibles:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Id de la agenda:";
            // 
            // txt_box_id_agenda
            // 
            this.txt_box_id_agenda.Location = new System.Drawing.Point(533, 116);
            this.txt_box_id_agenda.Name = "txt_box_id_agenda";
            this.txt_box_id_agenda.Size = new System.Drawing.Size(100, 20);
            this.txt_box_id_agenda.TabIndex = 10;
            // 
            // btn_mostrar_tareas
            // 
            this.btn_mostrar_tareas.Location = new System.Drawing.Point(674, 114);
            this.btn_mostrar_tareas.Name = "btn_mostrar_tareas";
            this.btn_mostrar_tareas.Size = new System.Drawing.Size(87, 23);
            this.btn_mostrar_tareas.TabIndex = 9;
            this.btn_mostrar_tareas.Text = "Mostrar Tareas";
            this.btn_mostrar_tareas.UseVisualStyleBackColor = true;
            // 
            // miagendaDataSet
            // 
            this.miagendaDataSet.DataSetName = "miagendaDataSet";
            this.miagendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "agenda";
            this.agendaBindingSource.DataSource = this.miagendaDataSet;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
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
            // tareaBindingSource
            // 
            this.tareaBindingSource.DataMember = "tarea";
            this.tareaBindingSource.DataSource = this.miagendaDataSet;
            // 
            // tareaTableAdapter
            // 
            this.tareaTableAdapter.ClearBeforeFill = true;
            // 
            // idagendaDataGridViewTextBoxColumn
            // 
            this.idagendaDataGridViewTextBoxColumn.DataPropertyName = "id_agenda";
            this.idagendaDataGridViewTextBoxColumn.HeaderText = "id_agenda";
            this.idagendaDataGridViewTextBoxColumn.Name = "idagendaDataGridViewTextBoxColumn";
            // 
            // diaDataGridViewTextBoxColumn
            // 
            this.diaDataGridViewTextBoxColumn.DataPropertyName = "dia";
            this.diaDataGridViewTextBoxColumn.HeaderText = "dia";
            this.diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            // 
            // mesDataGridViewTextBoxColumn
            // 
            this.mesDataGridViewTextBoxColumn.DataPropertyName = "mes";
            this.mesDataGridViewTextBoxColumn.HeaderText = "mes";
            this.mesDataGridViewTextBoxColumn.Name = "mesDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // lugarDataGridViewTextBoxColumn
            // 
            this.lugarDataGridViewTextBoxColumn.DataPropertyName = "lugar";
            this.lugarDataGridViewTextBoxColumn.HeaderText = "lugar";
            this.lugarDataGridViewTextBoxColumn.Name = "lugarDataGridViewTextBoxColumn";
            // 
            // Mostrar_tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_box_id_agenda);
            this.Controls.Add(this.btn_mostrar_tareas);
            this.Name = "Mostrar_tareas";
            this.Text = "Mostrar_tareas";
            this.Load += new System.EventHandler(this.Mostrar_tareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_box_id_agenda;
        private System.Windows.Forms.Button btn_mostrar_tareas;
        private miagendaDataSet miagendaDataSet;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private miagendaDataSetTableAdapters.agendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tareaBindingSource;
        private miagendaDataSetTableAdapters.tareaTableAdapter tareaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idagendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn;
    }
}