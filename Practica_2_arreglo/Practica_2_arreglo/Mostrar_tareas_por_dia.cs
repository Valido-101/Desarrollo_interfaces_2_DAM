﻿using System;
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
    public partial class Mostrar_tareas_por_dia : Form
    {
        public Mostrar_tareas_por_dia()
        {
            InitializeComponent();
        }

        private void Mostrar_tareas_por_dia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet.tarea' Puede moverla o quitarla según sea necesario.
            //this.tareaTableAdapter.Fill(this.miagendaDataSet.tarea);

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.tareaTableAdapter.setTareasAgendaDiaConcreto(this.miagendaDataSet.tarea, Convert.ToInt32(txt_box_id_agenda.Text), Convert.ToInt32(txt_box_dia.Text), Convert.ToInt32(txt_box_mes.Text));

            if (Convert.ToInt32(this.tareaTableAdapter.numTareasDiaConcreto(Convert.ToInt32(txt_box_id_agenda.Text), Convert.ToInt32(txt_box_dia.Text), Convert.ToInt32(txt_box_mes.Text))) == 0)
            {
                MessageBox.Show("No hay ninguna tarea para ese día", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
