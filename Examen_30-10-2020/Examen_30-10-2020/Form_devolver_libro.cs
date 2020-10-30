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
    public partial class Form_devolver_libro : Form
    {

        ArrayList socios;
        ArrayList libros;

        public Form_devolver_libro(ArrayList socios, ArrayList libros)
        {
            this.socios = socios;
            this.libros = libros;
            InitializeComponent();            
        }

        private void Form_devolver_libro_Load(object sender, EventArgs e)
        {
            ArrayList socios_con_libros = new ArrayList();

            foreach (Socio s in socios) 
            {
                if (s.Libros.Count != 0) 
                {
                    socios_con_libros.Add(s);
                }
            }

            if (socios_con_libros.Count != 0) 
            {
                datagrid_socios.Columns.Add("Nombre", "Nombre");
                datagrid_socios.Columns.Add("Apellidos", "Apellidos");
                datagrid_socios.Columns.Add("Id_Socio", "Id_socio");

                datagrid_socios.Rows.Add(socios_con_libros.Count);

                for (int fila = 0; fila < socios_con_libros.Count; fila++)
                {
                    Socio s = (Socio)socios_con_libros[fila];
                    datagrid_socios.Rows[fila].Cells[0].Value = s.Nombre;
                    datagrid_socios.Rows[fila].Cells[1].Value = s.Apellidos;
                    datagrid_socios.Rows[fila].Cells[2].Value = s.Id_socio;
                }
            }
            else 
            {
                MessageBox.Show("No hay usuarios con libros por devolver");
                this.Close();
            }
        }

        private void btn_devolver_libros_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection fila = datagrid_socios.SelectedRows;

            int id_socio = (int)fila[0].Cells[2].Value;

            foreach(Socio s in socios) 
            {
                if (s.Id_socio == id_socio)
                {
                    foreach(Libro l in s.Libros) 
                    {
                        libros.Add(l);
                        s.Libros.Remove(l);

                        break;
                    }

                    MessageBox.Show("Libros devueltos con éxito");

                    break;
                }
            }

            this.Close();
        }
    }
}
