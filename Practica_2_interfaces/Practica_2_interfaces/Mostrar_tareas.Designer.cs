namespace Practica_2_interfaces
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
            this.btn_mostrar_tareas = new System.Windows.Forms.Button();
            this.txt_box_id_agenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tareaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.miagendaDataSet = new Practica_2_interfaces.miagendaDataSet();
            this.agendaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.miagendaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tareaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tareaTableAdapter = new Practica_2_interfaces.miagendaDataSetTableAdapters.tareaTableAdapter();
            this.tareaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agendaTableAdapter = new Practica_2_interfaces.miagendaDataSetTableAdapters.agendaTableAdapter();
            this.miagendaDataSet1 = new Practica_2_interfaces.miagendaDataSet1();
            this.agendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agendaTableAdapter1 = new Practica_2_interfaces.miagendaDataSet1TableAdapters.agendaTableAdapter();
            this.tareaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tareaTableAdapter1 = new Practica_2_interfaces.miagendaDataSet1TableAdapters.tareaTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.agendaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tareaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.idagendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mostrar_tareas
            // 
            this.btn_mostrar_tareas.Location = new System.Drawing.Point(668, 80);
            this.btn_mostrar_tareas.Name = "btn_mostrar_tareas";
            this.btn_mostrar_tareas.Size = new System.Drawing.Size(87, 23);
            this.btn_mostrar_tareas.TabIndex = 0;
            this.btn_mostrar_tareas.Text = "Mostrar Tareas";
            this.btn_mostrar_tareas.UseVisualStyleBackColor = true;
            this.btn_mostrar_tareas.Click += new System.EventHandler(this.btn_mostrar_tareas_Click);
            // 
            // txt_box_id_agenda
            // 
            this.txt_box_id_agenda.Location = new System.Drawing.Point(527, 82);
            this.txt_box_id_agenda.Name = "txt_box_id_agenda";
            this.txt_box_id_agenda.Size = new System.Drawing.Size(100, 20);
            this.txt_box_id_agenda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id de la agenda:";
            // 
            // tareaBindingSource3
            // 
            this.tareaBindingSource3.DataMember = "tarea";
            this.tareaBindingSource3.DataSource = this.miagendaDataSet;
            // 
            // miagendaDataSet
            // 
            this.miagendaDataSet.DataSetName = "miagendaDataSet";
            this.miagendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaBindingSource2
            // 
            this.agendaBindingSource2.DataMember = "agenda";
            this.agendaBindingSource2.DataSource = this.miagendaDataSetBindingSource;
            // 
            // miagendaDataSetBindingSource
            // 
            this.miagendaDataSetBindingSource.DataSource = this.miagendaDataSet;
            this.miagendaDataSetBindingSource.Position = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agendas disponibles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tareas de la agenda:";
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "agenda";
            this.agendaBindingSource.DataSource = this.miagendaDataSet;
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
            // tareaBindingSource1
            // 
            this.tareaBindingSource1.DataMember = "tarea";
            this.tareaBindingSource1.DataSource = this.miagendaDataSet;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // miagendaDataSet1
            // 
            this.miagendaDataSet1.DataSetName = "miagendaDataSet1";
            this.miagendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaBindingSource1
            // 
            this.agendaBindingSource1.DataMember = "agenda";
            this.agendaBindingSource1.DataSource = this.miagendaDataSet1;
            // 
            // agendaTableAdapter1
            // 
            this.agendaTableAdapter1.ClearBeforeFill = true;
            // 
            // tareaBindingSource2
            // 
            this.tareaBindingSource2.DataMember = "tarea";
            this.tareaBindingSource2.DataSource = this.miagendaDataSet1;
            // 
            // tareaTableAdapter1
            // 
            this.tareaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.agendaBindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(37, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(344, 150);
            this.dataGridView2.TabIndex = 7;
            // 
            // agendaBindingSource3
            // 
            this.agendaBindingSource3.DataMember = "agenda";
            this.agendaBindingSource3.DataSource = this.miagendaDataSet;
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
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "año";
            this.añoDataGridViewTextBoxColumn.HeaderText = "año";
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
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
            this.descripciónDataGridViewTextBoxColumn,
            this.lugarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tareaBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(114, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // tareaBindingSource4
            // 
            this.tareaBindingSource4.DataMember = "tarea";
            this.tareaBindingSource4.DataSource = this.miagendaDataSet;
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
            // descripciónDataGridViewTextBoxColumn
            // 
            this.descripciónDataGridViewTextBoxColumn.DataPropertyName = "descripción";
            this.descripciónDataGridViewTextBoxColumn.HeaderText = "descripción";
            this.descripciónDataGridViewTextBoxColumn.Name = "descripciónDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareaBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mostrar_tareas;
        private System.Windows.Forms.TextBox txt_box_id_agenda;
        private System.Windows.Forms.Label label1;
        private miagendaDataSet miagendaDataSet;
        private System.Windows.Forms.BindingSource tareaBindingSource;
        private miagendaDataSetTableAdapters.tareaTableAdapter tareaTableAdapter;
        private System.Windows.Forms.BindingSource tareaBindingSource1;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private miagendaDataSetTableAdapters.agendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private miagendaDataSet1 miagendaDataSet1;
        private System.Windows.Forms.BindingSource agendaBindingSource1;
        private miagendaDataSet1TableAdapters.agendaTableAdapter agendaTableAdapter1;
        private System.Windows.Forms.BindingSource tareaBindingSource2;
        private miagendaDataSet1TableAdapters.tareaTableAdapter tareaTableAdapter1;
        private System.Windows.Forms.BindingSource tareaBindingSource3;
        private System.Windows.Forms.BindingSource agendaBindingSource2;
        private System.Windows.Forms.BindingSource miagendaDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource agendaBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idagendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tareaBindingSource4;
    }
}