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
    public partial class Crear_agenda : Form
    {
        public Crear_agenda()
        {
            InitializeComponent();
        }

        private void agendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.miagendaDataSet);

        }

        private void Crear_agenda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'miagendaDataSet.agenda' Puede moverla o quitarla según sea necesario.
            this.agendaTableAdapter.Fill(this.miagendaDataSet.agenda);

        }

        private void btn_crear_agenda_Click(object sender, EventArgs e)
        {
            this.agendaTableAdapter.Crear_agenda(Convert.ToInt32(this.agendaTableAdapter.getIdAutomatico()),txt_box_nombre_agenda.Text,Convert.ToInt32(txt_box_annio_agenda.Text));
            this.agendaTableAdapter.Fill(this.miagendaDataSet.agenda);
            MessageBox.Show("Agenda creada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
