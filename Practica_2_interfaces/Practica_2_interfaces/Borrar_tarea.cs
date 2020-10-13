﻿using System;
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
    public partial class Borrar_tarea : Form
    { 
        public Borrar_tarea()
        {
            InitializeComponent();
        }

        private void Borrar_tarea_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet.tarea' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet.agenda' Puede moverla o quitarla según sea necesario.
            this.agendaTableAdapter.Fill(this.miagendaDataSet.agenda);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var borrar = MessageBox.Show("¿Desea borrar la tarea?", "Confirmación", MessageBoxButtons.YesNo);

            //Si ha pulsado Sí se cierra el programa, de lo contrario no se cerrará
            if (borrar == DialogResult.Yes)
            { 

                this.tareaTableAdapter.Eliminar_tarea(Convert.ToInt32(txt_box_buscar_id_agenda.Text), Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[1].Value), Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[2].Value), Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[3].Value));
                Close();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.tareaTableAdapter.LLenarTablaPorAgenda(this.miagendaDataSet.tarea,Convert.ToInt32(txt_box_buscar_id_agenda.Text));
        }
    }
}
