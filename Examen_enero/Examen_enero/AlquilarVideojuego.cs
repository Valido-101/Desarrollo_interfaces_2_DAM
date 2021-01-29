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
    public partial class AlquilarVideojuego : Form
    {
        ArrayList videojuegos;
        ArrayList clientes;

        public AlquilarVideojuego(ArrayList videojuegos, ArrayList clientes)
        {
            InitializeComponent();

            this.videojuegos = videojuegos;
            this.clientes = clientes;
        }

        private void btn_alquilar_Click(object sender, EventArgs e)
        {
            try 
            {
                //Comprobamos que ambos ListBox tengan un elemento marcado
                if(lstbox_videojuegos.SelectedItem==null || lstbox_clientes.SelectedItem == null) 
                {
                    //Si alguno de los dos no tiene un elemento marcado, lanzamos una excepción
                    throw new Exception("Debe seleccionar un cliente y un videojuego para poder alquilar");
                }

                //Obtenemos el videojuego marcado en el ListBox de videojuegos y el cliente al que se lo queremos alquilar
                Videojuego videojuego_a_alquilar = (Videojuego) lstbox_videojuegos.SelectedItem;
                Cliente cliente_alquiler = (Cliente)lstbox_clientes.SelectedItem;

                //Eliminamos el videojuego de la lista de videojuegos disponibles
                videojuegos.Remove(videojuego_a_alquilar);

                //Añadimos el videojuego al cliente seleccionado
                cliente_alquiler.Videojuegos.Add(videojuego_a_alquilar);

                //Actualizamos el contenido del ListBox de videojuegos e informamos al usuario
                actualizarContenidoVideojuegos();

                MessageBox.Show("Videojuego alquilado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
                //Si salta la excepción, se informa al usuario
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Este método vuelve a asignar el DataSource del ListBox videojuegos, una vez que se ha actualizado
        private void actualizarContenidoVideojuegos() 
        {
            lstbox_videojuegos.DataSource = null;
            lstbox_videojuegos.DataSource = videojuegos;
        }

        //Método que se ejecuta al cargarse el formulario. Establece los DataSource y quita el foco de los elementos para que no haya
        //ninguno seleccionado al abrir la ventana
        private void AlquilarVideojuego_Load(object sender, EventArgs e)
        {
            lstbox_videojuegos.DataSource = videojuegos;
            lstbox_clientes.DataSource = clientes;
            lstbox_videojuegos.SelectedItem = null;
            lstbox_clientes.SelectedItem = null;
        }
    }
}
