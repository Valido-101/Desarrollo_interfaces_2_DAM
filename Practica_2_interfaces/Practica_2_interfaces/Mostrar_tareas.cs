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
    public partial class Mostrar_tareas : Form
    {
        public Mostrar_tareas()
        {
            InitializeComponent();
        }

        private void Mostrar_tareas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet1.tarea' Puede moverla o quitarla según sea necesario.
            this.tareaTableAdapter.Fill(this.miagendaDataSet.tarea);
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet1.agenda' Puede moverla o quitarla según sea necesario.
            this.agendaTableAdapter.Fill(this.miagendaDataSet.agenda);
            
            

        }

        private void btn_mostrar_tareas_Click(object sender, EventArgs e)
        {
            this.tareaTableAdapter.LLenarTablaPorAgenda(this.miagendaDataSet.tarea, Convert.ToInt32(txt_box_id_agenda.Text));
        }
    }
}
