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
    public partial class Form_insertar_persona : Form
    {
        //Cosntructor vacío de este formulario
        public Form_insertar_persona()
        {
            InitializeComponent();
        }

        //Nueva referencia para poder trabajar con el arraylist del form1
        ArrayList personas;
        //Variables donde guardamos los datos para crear cada persona
        string nombre;
        string dni;
        string apellidos;
        string fecha_nac;
        int peso;
        double altura;
        //Booleano que nos servirá para saber si el dni introducido ya existe
        bool repetido;

        //Construtor que mete por parámetro el arraylist del form1
        public Form_insertar_persona(ArrayList personas)
        {
            this.personas = personas;
            InitializeComponent();
        }

        //Evento que se realiza al hacer click sobre el botón
        private void btn_guardar_datos_persona_Click(object sender, EventArgs e)
        {
            //Inicializamos el booleano "repetido" con valor false
            repetido = false;
            //Guardamos el valor de los txt_box en las variables para crear la persona
            nombre = txtbox_nombre.Text;
            dni = txtbox_dni.Text;
            apellidos = txtbox_apellidos.Text;
            fecha_nac = txtbox_fecha_nac.Text;
            //Controlamos que si no se rellenan los campos de peso y altura se rellenen con
            //0, puesto que al ser numéricos no se pueden rellenar con cadena vacía
            if (txtbox_peso.Text == "")
            {
                peso = 0;
            }
            else 
            {
                peso = Convert.ToInt32(txtbox_peso.Text);
            }
            if (txtbox_altura.Text == "") 
            {
                altura = 0;
            }
            else 
            {
                altura = Convert.ToDouble(txtbox_altura.Text);
            }

            //Recorremos el arraylist personas para comprobar si ya existe ese dni
            foreach(Persona p in personas) 
            {
                //Si coincide con alguno, repetido se vuelve true
                if (p.getDni() == dni) 
                {
                    repetido = true;
                }
            }

            //Si repetido es false (no existe ese dni), se añade la persona con normalidad
            //informando al usuario de que todo ha sido correcto y se cierra.
            if (repetido == false) 
            {
                personas.Add(new Persona(dni, nombre, apellidos, fecha_nac, peso, altura));
                MessageBox.Show("Datos introducidos correctamente.");
                Close();
            }
            //De lo contrario, se informa al usuario de que ya existe el dni y se coloca
            //el foco sobre el textBox donde se guarda el dni, para que no tenga ni que
            //mover el ratón
            else 
            {
                MessageBox.Show("El dni introducido pertenece a otra persona. Asegúrese de que no está repetido.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbox_dni.Focus();
            }

        }

    }
}
