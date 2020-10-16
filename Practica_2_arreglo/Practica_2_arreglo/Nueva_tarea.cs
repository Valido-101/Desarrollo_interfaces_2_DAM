using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_arreglo
{
    public partial class Nueva_tarea : Form
    {
        public Nueva_tarea()
        {
            InitializeComponent();
        }

        private void Nueva_tarea_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet.tarea' Puede moverla o quitarla según sea necesario.
            this.tareaTableAdapter.Fill(this.miagendaDataSet.tarea);
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet.agenda' Puede moverla o quitarla según sea necesario.
            this.agendaTableAdapter.Fill(this.miagendaDataSet.agenda);

        }

        private void btn_crear_tarea_Click(object sender, EventArgs e)
        {
            this.tareaTableAdapter.crearTarea(Convert.ToInt32(txt_box_id_agenda.Text), Convert.ToInt32(txt_box_dia.Text), Convert.ToInt32(txt_box_mes.Text), Convert.ToInt32(txt_box_hora.Text), txt_box_descripcion.Text, txt_box_lugar.Text);
            MessageBox.Show("Tarea creada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_box_dia.Clear();
            txt_box_mes.Clear();
            txt_box_hora.Clear();
            txt_box_descripcion.Clear();
            txt_box_lugar.Clear();
        }
    }
}
