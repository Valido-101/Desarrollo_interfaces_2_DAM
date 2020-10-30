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
    public partial class Form_sacar_libro : Form
    {

        ArrayList libros;
        ArrayList socios;

        public Form_sacar_libro(ArrayList libros, ArrayList socios)
        {
            this.libros = libros;
            this.socios = socios;
            InitializeComponent();
        }

        private void Form_sacar_libro_Load(object sender, EventArgs e)
        {
            foreach (Socio s in socios)
            {
                lstbox_socios.Items.Add(s.toString());
            }

            foreach (Libro l in libros)
            {
                lstbox_libros.Items.Add(l.toStringTitulo());
            }
        }

        private void txtbox_buscar_libro_TextChanged(object sender, EventArgs e)
        {
            lstbox_libros.Items.Clear();

            //Se recorre el ArrayList y se añade al listbox el toString del objeto cuyo nombre o
            //apellidos contenga lo que se ha escrito hasta ese momento
            foreach (Libro l in libros)
            {
                if (l.Titulo.Contains(txtbox_buscar_libro.Text))
                {
                    lstbox_libros.Items.Add(l.toStringTitulo());
                }
            }
        }

        private void txtbox_buscar_socio_TextChanged(object sender, EventArgs e)
        {
            lstbox_socios.Items.Clear();

            //Se recorre el ArrayList y se añade al listbox el toString del objeto cuyo nombre o
            //apellidos contenga lo que se ha escrito hasta ese momento
            foreach (Socio s in socios)
            {
                if (s.Nombre.Contains(txtbox_buscar_socio.Text))
                {
                    lstbox_socios.Items.Add(s.toString());
                }
                else
                {
                    if (s.Apellidos.Contains(txtbox_buscar_socio.Text))
                    {
                        lstbox_socios.Items.Add(s.toString());
                    }
                }
            }
        }

        private void btn_prestar_libro_Click(object sender, EventArgs e)
        {
            if (lstbox_socios.SelectedItem != null && lstbox_libros.SelectedItem != null)
            {
                foreach (Libro l in libros)
                {
                    //La condición que debe cumplirse para que se borre el objeto es que el toString
                    //del objeto actual del foreach coincida con lo que se ha seleccionado en el
                    //listbox (que a fin de cuentas es un toString de un objeto tipo Socio)
                    if (l.toString() == lstbox_libros.SelectedItem.ToString())
                    {
                        foreach (Socio s in socios)
                        {
                            //La condición que debe cumplirse para que se borre el objeto es que el toString
                            //del objeto actual del foreach coincida con lo que se ha seleccionado en el
                            //listbox (que a fin de cuentas es un toString de un objeto tipo Socio)
                            if (s.toString() == lstbox_socios.SelectedItem.ToString())
                            {
                                s.Libros.Add(l);
                                libros.Remove(l);

                                MessageBox.Show("Libro "+l.Titulo+" prestado con éxito a "+s.Nombre+" "+s.Apellidos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                break;
                            }
                        }

                        break;
                    }
                }

                this.Close();

            }
            else
            {
                MessageBox.Show("Faltan datos, haga click sobre algún socio y algún libro de las listas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
