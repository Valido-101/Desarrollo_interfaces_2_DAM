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
    public partial class Form_dar_alta : Form
    {

        ArrayList socios;

        public Form_dar_alta(ArrayList socios)
        {
            this.socios = socios;
            InitializeComponent();
        }

        private void btn_aceptar_alta_Click(object sender, EventArgs e)
        {
            Socio s = (Socio)socios[socios.Count - 1];

            socios.Add(new Socio(txtbox_nombre.Text, txtbox_apellidos.Text,s.Id_socio+1,new ArrayList()));

            MessageBox.Show("Socio dado de alta con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
