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
    public partial class AltaCliente : Form
    {
        ArrayList clientes;

        public AltaCliente(ArrayList clientes)
        {
            InitializeComponent();

            this.clientes = clientes;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Rescatamos los campos de los TextBox
            string dni, nombre, apellidos;

            dni = txtbox_dni.Text;
            nombre = txtbox_nombre.Text;
            apellidos = txtbox_apellidos.Text;

            //Recorremos la lista de clientes para comprobar si el dni introducido existe
            try
            {
                foreach (Cliente c in clientes)
                {
                    //Si existe, lanzamos una excepción
                    if (c.Dni.Equals(dni)) 
                    {
                        throw new Exception();
                    }
                }

                //Si termina de recorrer la lista y no salta la excepción, el dni no existe y se procede a almacenar el nuevo cliente
                clientes.Add(new Cliente(nombre, apellidos, dni));

                //Se informa al usuario de que el proceso ha finalizado con éxito
                MessageBox.Show("Cliente introducido con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Se borra el contenido de los TextBox
                txtbox_dni.ResetText();
                txtbox_nombre.ResetText();
                txtbox_apellidos.ResetText();
            }
            //Si salta la excepción, mostraremos un MessageBox informando al usuario
            catch (Exception)
            {
                MessageBox.Show("El dni introducido pertenece a otro cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
