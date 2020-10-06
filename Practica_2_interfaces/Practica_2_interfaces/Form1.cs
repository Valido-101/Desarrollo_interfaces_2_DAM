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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        }
    }
}
