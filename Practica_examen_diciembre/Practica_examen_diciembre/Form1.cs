using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_examen_diciembre
{
    public partial class Ventana_menu : Form
    {
        Almacen almacen_seleccionado;
        Seleccionar_almacen seleccionar_Almacen;

        public Ventana_menu(Almacen almacen_seleccionado, Seleccionar_almacen seleccionar_Almacen)
        {
            InitializeComponent();
            this.almacen_seleccionado = almacen_seleccionado;
            this.seleccionar_Almacen = seleccionar_Almacen;
        }

        private void btn_valor_almacen_Click(object sender, EventArgs e)
        {

        }

        private void Ventana_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            seleccionar_Almacen.Show();
        }
    }
}
