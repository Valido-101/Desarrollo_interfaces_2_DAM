using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_enero
{
    public partial class DevolverVideojuegos : Form
    {
        ArrayList clientes;
        ArrayList videojuegos;
        ArrayList clientes_con_videojuegos = new ArrayList();

        public DevolverVideojuegos(ArrayList clientes, ArrayList videojuegos)
        {
            InitializeComponent();

            this.clientes = clientes;
            this.videojuegos = videojuegos;
            obtenerClientesConVideojuegos();
        }


        //Método que sirve para extraer los clientes con videojuegos de la lista de clientes original
        private void obtenerClientesConVideojuegos() 
        {
            clientes_con_videojuegos.Clear();

            //Recorremos la lista de clientes
            foreach(Cliente c in clientes) 
            {
                //Si el cliente tiene videojuegos, lo almacenamos en la nueva lista
                if (c.Videojuegos.Count != 0) 
                {
                    clientes_con_videojuegos.Add(c);
                }
            }
        }

        private void DevolverVideojuegos_Load(object sender, EventArgs e)
        {
            lstbox_clientesConVideojuegos.DataSource = clientes_con_videojuegos;
            lstbox_clientesConVideojuegos.SelectedItem = null;
        }

        private void btn_devolver_Click(object sender, EventArgs e)
        {
            try 
            {
                //Comprobamos que el ListBox tenga algún elemento seleccionado
                if (lstbox_clientesConVideojuegos.SelectedItem == null) 
                {
                    //Si no se ha seleccionado un elemento, salta una excepción
                    throw new Exception("No ha seleccionado ningún cliente");
                }

                //Obtenemos el cliente seleccionado
                Cliente c = (Cliente) lstbox_clientesConVideojuegos.SelectedItem;

                //Obtenemos la lista de videojuegos del cliente, la eliminamos del cliente y se la pasamos a la lista de videojuegos disponibles
                ArrayList videojuegos_devueltos = c.Videojuegos;

                c.Videojuegos.Clear();

                foreach(Videojuego v in videojuegos_devueltos) 
                {
                    videojuegos.Add(v);
                }

                //Se actualiza el contenido del ListBox y se informa al usuario
                obtenerClientesConVideojuegos();

                actualizarContenidoClientesConVideojuegos();

                MessageBox.Show("Devolución realizada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Si salta la excepción, se informa al usuario
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void actualizarContenidoClientesConVideojuegos()
        {
            lstbox_clientesConVideojuegos.DataSource = null;
            lstbox_clientesConVideojuegos.DataSource = clientes_con_videojuegos;
        }
    }
}
