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

namespace Practica_1_interfaces
{
    public partial class Form_mostrar_personas : Form
    {
        //Constructor vacío de Form_mostrar_personas
        public Form_mostrar_personas()
        {
            InitializeComponent();
        }

        //Referencia para el arraylist de personas del Form1
        ArrayList personas;

        //Constructor del Form_mostrar_personas que tiene como parámetro el arraylist del
        //Form1
        public Form_mostrar_personas(ArrayList personas)
        {
            InitializeComponent();
            this.personas = personas;
        }

        //Evento que se realiza al cargar el formulario y que muestra los datos de cada
        //objeto persona en el arraylist e indica cuántas hay.
        private void Form_mostrar_personas_Load(object sender, EventArgs e)
        {
            foreach (Persona p in personas)
            {
                lstbox_mostrar_personas.Items.Add(p.toString());
            }            

            label1.Text="Hay " + personas.Count + " personas";
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
