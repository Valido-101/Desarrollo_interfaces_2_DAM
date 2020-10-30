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

namespace Examen_30_10_2020
{
    public partial class Form_dar_baja : Form
    {
        ArrayList socios;

        //Constructor que recibe por parámetros el arraylist de socios
        public Form_dar_baja(ArrayList socios)
        {
            this.socios = socios;
            InitializeComponent();
        }

        //Cuando se carga el formulario, se llena el listbox con todos los objetos del ArrayList
        private void Form_dar_baja_Load(object sender, EventArgs e)
        {
            foreach(Socio s in socios) 
            {
                lstbox_socios.Items.Add(s.toString());
            }
        }

        //A medida que se va escribiendo en el textbox, se rellena el listbox con los socios
        //cuyo nombre o apellidos contengan lo que se está escribiendo
        private void txtbox_buscar_nombre_apellido_TextChanged(object sender, EventArgs e)
        {
            //Borra el listbox para que no se vayan acumulando los items
            lstbox_socios.Items.Clear();

            //Se recorre el ArrayList y se añade al listbox el toString del objeto cuyo nombre o
            //apellidos contenga lo que se ha escrito hasta ese momento
            foreach(Socio s in socios) 
            {
                if (s.Nombre.Contains(txtbox_buscar_nombre_apellido.Text)) 
                {
                    lstbox_socios.Items.Add(s.toString());
                }
                else
                {
                    if (s.Apellidos.Contains(txtbox_buscar_nombre_apellido.Text)) 
                    {
                        lstbox_socios.Items.Add(s.toString());
                    }
                }
            }
        }

        //Cuando se hace click en el botón, se borra el objeto seleccionado en el
        //listbox del ArrayList. Si no hay ningún objeto seleccionado se informa al usuario.
        private void btn_aceptar_baja_Click(object sender, EventArgs e)
        {
            //Si el atributo SelectedItem es null (no se ha seleccionado ningún elemento del listbox),
            //se informa al usuario
            if (lstbox_socios.SelectedItem != null) 
            {
                foreach (Socio s in socios)
                {
                    //La condición que debe cumplirse para que se borre el objeto es que el toString
                    //del objeto actual del foreach coincida con lo que se ha seleccionado en el
                    //listbox (que a fin de cuentas es un toString de un objeto tipo Socio)
                    if (s.toString() == lstbox_socios.SelectedItem.ToString())
                    {
                        //Si tiene algún libro no se puede dar de baja
                        if (s.Libros.Count == 0) 
                        {
                            socios.Remove(s);

                            MessageBox.Show("Socio dado de baja con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            break;
                        }
                        else 
                        {
                            MessageBox.Show("No se puede dar de baja, tiene libros por devolver", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            break;
                        }
                    }
                }

                this.Close();

            }
            else 
            {
                MessageBox.Show("No ha seleccionado ningún socio, haga click sobre algún socio de la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
