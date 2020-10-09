using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList agendas = new ArrayList();
        ArrayList tareas = new ArrayList();

        //Recuperar fila y celda que quiera al hacer click en una celda:
        //DataGridView.Rows[e.RowIndex].Cells[0(por ejemplo)];
        //Ejecutar consulta sobre tabla:
        //agendaTableAdapter.(nombre de la consulta)+parámetro;

        private void btn_salir_Click(object sender, EventArgs e)
        {
            var salir = MessageBox.Show("¿Desea salir del programa?", "Salir", MessageBoxButtons.YesNo);

            //Si ha pulsado Sí se cierra el programa, de lo contrario no se cerrará
            if (salir == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_crear_agenda_Click(object sender, EventArgs e)
        {

            Crear_agenda form_crear_agenda = new Crear_agenda();

            form_crear_agenda.Show();

        }

        private void btn_nueva_tarea_Click(object sender, EventArgs e)
        {
            Nueva_tarea form_nueva_tarea = new Nueva_tarea();

            form_nueva_tarea.Show();

        }

        private void btn_mostrar_tareas_Click(object sender, EventArgs e)
        {
            Mostrar_tareas form_mostrar_tareas = new Mostrar_tareas();

            form_mostrar_tareas.Show();
        }

        private void btn_mostrar_tareas_por_dia_Click(object sender, EventArgs e)
        {
            Mostrar_tareas_por_dia form_mostrar_Tareas_Por_Dia = new Mostrar_tareas_por_dia();

            form_mostrar_Tareas_Por_Dia.Show();
        }

        private void btn_modificar_tarea_Click(object sender, EventArgs e)
        {
            Modificar_tarea form_modificar_Tarea = new Modificar_tarea();

            form_modificar_Tarea.Show();
        }
    }
}
