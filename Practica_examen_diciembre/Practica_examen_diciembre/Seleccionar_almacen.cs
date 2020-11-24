using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_examen_diciembre
{
    public partial class Seleccionar_almacen : Form
    {

        ArrayList almacenes = new ArrayList();

        public Seleccionar_almacen()
        {
            InitializeComponent();
            almacenes.Add(new Almacen("Al1", "Huesca"));
            almacenes.Add(new Almacen("Al2", "Toledo"));
        }

        private void Seleccionar_almacen_Load(object sender, EventArgs e)
        {
            lstbox_almacenes.DataSource = almacenes;
        }

        private void lstbox_almacenes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Ventana_menu ventana_menu = new Ventana_menu((Almacen)lstbox_almacenes.SelectedItem,this);
            ventana_menu.Show();
            this.Hide();
        }
    }
}
