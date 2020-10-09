namespace Practica_2_interfaces
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
            this.agendaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miagendaDataSet = new Practica_2_interfaces.miagendaDataSet();
            this.btn_crear_agenda = new System.Windows.Forms.Button();
            this.txt_box_nombre_agenda = new System.Windows.Forms.TextBox();
            this.txt_box_annio_agenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.agendaTableAdapter = new Practica_2_interfaces.miagendaDataSetTableAdapters.agendaTableAdapter();
            this.tableAdapterManager = new Practica_2_interfaces.miagendaDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miagendaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // agendaDataGridView
            // 
            this.agendaDataGridView.AutoGenerateColumns = false;
            this.agendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.agendaDataGridView.DataSource = this.agendaBindingSource;
            this.agendaDataGridView.Location = new System.Drawing.Point(185, 64);
            this.agendaDataGridView.Name = "agendaDataGridView";
            this.agendaDataGridView.Size = new System.Drawing.Size(344, 290);
            this.agendaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "año";
            this.dataGridViewTextBoxColumn3.HeaderText = "año";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            // btn_crear_agenda
            // 
            this.btn_crear_agenda.Location = new System.Drawing.Point(657, 20);
            this.btn_crear_agenda.Name = "btn_crear_agenda";
            this.btn_crear_agenda.Size = new System.Drawing.Size(75, 23);
            this.btn_crear_agenda.TabIndex = 2;
            this.btn_crear_agenda.Text = "Crear";
            this.btn_crear_agenda.UseVisualStyleBackColor = true;
            this.btn_crear_agenda.Click += new System.EventHandler(this.btn_crear_agenda_Click);
            // 
            // txt_box_nombre_agenda
            // 
            this.txt_box_nombre_agenda.Location = new System.Drawing.Point(80, 23);
            this.txt_box_nombre_agenda.Name = "txt_box_nombre_agenda";
            this.txt_box_nombre_agenda.Size = new System.Drawing.Size(100, 20);
            this.txt_box_nombre_agenda.TabIndex = 3;
            // 
            // txt_box_annio_agenda
            // 
            this.txt_box_annio_agenda.Location = new System.Drawing.Point(416, 22);
            this.txt_box_annio_agenda.Name = "txt_box_annio_agenda";
            this.txt_box_annio_agenda.Size = new System.Drawing.Size(100, 20);
            this.txt_box_annio_agenda.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Año";
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendaTableAdapter = this.agendaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tareaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Practica_2_interfaces.miagendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Crear_agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private miagendaDataSet miagendaDataSet;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private miagendaDataSetTableAdapters.agendaTableAdapter agendaTableAdapter;
        private miagendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView agendaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btn_crear_agenda;
        private System.Windows.Forms.TextBox txt_box_nombre_agenda;
        private System.Windows.Forms.TextBox txt_box_annio_agenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}