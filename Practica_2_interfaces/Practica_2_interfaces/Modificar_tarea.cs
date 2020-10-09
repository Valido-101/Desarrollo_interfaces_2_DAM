using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_interfaces
{
    public partial class Modificar_tarea : Form
    {
        public Modificar_tarea()
        {
            InitializeComponent();
        }

        int id_agenda=0;
        int dia = 0;
        int mes = 0;

        private void Modificar_tarea_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet.tarea' Puede moverla o quitarla según sea necesario.
            //this.tareaTableAdapter.Fill(this.miagendaDataSet.tarea);

        }

        private void btn_buscar_tareas_Click(object sender, EventArgs e)
        {
            this.tareaTableAdapter.LLenarTablaPorAgenda(this.miagendaDataSet.tarea,Convert.ToInt32(txt_box_id_agenda.Text));

            label1.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            txt_box_hora.Visible = true;
            txt_box_descripcion.Visible = true;
            txt_box_lugar.Visible = true;
            btn_modificar.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Recuperar fila y celda que quiera al hacer click en una celda:
            txt_box_hora.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            txt_box_descripcion.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            txt_box_lugar.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            id_agenda= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            dia= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            mes= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            this.tareaTableAdapter.Modificar_tarea(Convert.ToInt32(txt_box_hora.Text),txt_box_descripcion.Text, txt_box_lugar.Text, id_agenda, dia, mes);
            MessageBox.Show("Tarea modificada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
