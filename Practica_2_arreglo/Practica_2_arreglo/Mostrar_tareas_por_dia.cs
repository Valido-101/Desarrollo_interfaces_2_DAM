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
    public partial class Mostrar_tareas_por_dia : Form
    {
        public Mostrar_tareas_por_dia()
        {
            InitializeComponent();
        }

        private void Mostrar_tareas_por_dia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet.tarea' Puede moverla o quitarla según sea necesario.
            this.tareaTableAdapter.Fill(this.miagendaDataSet.tarea);

        }
    }
}
