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

        public Form_dar_baja(ArrayList socios)
        {
            this.socios = socios;
            InitializeComponent();
        }

        private void Form_dar_baja_Load(object sender, EventArgs e)
        {
            foreach(Socio s in socios) 
            {
                lstbox_socios.Items.Add(s.toString());
            }
        }

        private void txtbox_buscar_nombre_apellido_TextChanged(object sender, EventArgs e)
        {
            lstbox_socios.Items.Clear();

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

        private void btn_aceptar_baja_Click(object sender, EventArgs e)
        {
            foreach(Socio s in socios) 
            {
                if (s.toString() == lstbox_socios.SelectedItem.ToString()) 
                {
                    socios.Remove(s);

                    MessageBox.Show("Socio dado de baja con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                }
            }

            this.Close();

        }
    }
}
