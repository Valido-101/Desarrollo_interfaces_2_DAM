using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_0_interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        string dni;
        string nombre;
        string apellidos;
        string fecha_nac;
        int peso;
        double altura;
        

        //Persona p1 = new Persona();

        ArrayList personas = new ArrayList();

        private void btn_crear_persona_Click(object sender, EventArgs e)
        {
            btn_crear_persona.Visible = false;
            btn_mostrar_persona.Visible = false;
            btn_enviar.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            txtbox_dni.Visible = true;
            txtbox_nombre.Visible = true;
            txtbox_apellidos.Visible = true;
            txtbox_fecha_nacimiento.Visible = true;
            txtbox_peso.Visible = true;
            txtbox_altura.Visible = true;
            
        }

        private void btn_mostrar_persona_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(p1.toString());
            foreach (Persona p in personas)
            {
                MessageBox.Show(p.toString());
            }
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {

            /*
            p1.setDni(txtbox_dni.Text);
            p1.setNombre(txtbox_nombre.Text);
            p1.setApellidos(txtbox_apellidos.Text);
            p1.setFechaNacimiento(txtbox_fecha_nacimiento.Text);
            if (txtbox_peso.Text == "") 
            {
                p1.setPeso(0);
            }
            else
            {
                p1.setPeso(Convert.ToInt32(txtbox_peso.Text));
            }
            if (txtbox_altura.Text == "")
            {
                p1.setAltura(0);
            }
            else
            {
                p1.setAltura(Convert.ToDouble(txtbox_altura.Text));
            }
            p1.setAltura(Convert.ToDouble(txtbox_altura.Text));
            */
            
            dni = txtbox_dni.Text;
            nombre = txtbox_nombre.Text;
            apellidos = txtbox_apellidos.Text;
            fecha_nac = txtbox_fecha_nacimiento.Text;
            if (txtbox_peso.Text == "")
            {
                peso=0;
            }
            else
            {
                peso=Convert.ToInt32(txtbox_peso.Text);
            }
            if (txtbox_altura.Text == "")
            {
                altura = 0;
            }
            else
            {
                altura = Convert.ToDouble(txtbox_altura.Text);
            }
            
            personas.Add(new Persona(dni,nombre,apellidos,fecha_nac,peso,altura));
            btn_enviar.Visible = false;
            btn_mostrar_persona.Visible = true;
            btn_crear_persona.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            txtbox_dni.Visible = false;
            txtbox_nombre.Visible = false;
            txtbox_apellidos.Visible = false;
            txtbox_fecha_nacimiento.Visible = false;
            txtbox_peso.Visible = false;
            txtbox_altura.Visible = false;
            txtbox_dni.Clear();
            txtbox_nombre.Clear();
            txtbox_apellidos.Clear();
            txtbox_fecha_nacimiento.Clear();
            txtbox_peso.Clear();
            txtbox_altura.Clear();

        }
    }
}
