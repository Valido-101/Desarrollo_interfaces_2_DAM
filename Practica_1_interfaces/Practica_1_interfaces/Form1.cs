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
using System.IO;

namespace Practica_1_interfaces
{
    //Formulario principal del ejercicio que muestra los seis botones
    public partial class Form1 : Form
    {
        
        //Constructor que inicializa el formulario
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 5; i++)
            {
                personas.Add(new Persona("dni" + i, "Nombre" + i, "Apellidos" + i, "fecha de nacimiento" + i, i, i));
            }

        }

        //Arraylist de personas donde guardaremos cada una de las personas creadas
        ArrayList personas = new ArrayList();

        //Botón que cierra la aplicación
        private void btn_salir_aplicacion_Click(object sender, EventArgs e)
        {
            //En esta variable almacenamos lo que pulse el usuario (Sí/No)
            var salir = MessageBox.Show("¿Desea salir del programa?", "Salir", MessageBoxButtons.YesNo);

            //Si ha pulsado Sí se cierra el programa, de lo contrario no se cerrará
            if (salir == DialogResult.Yes) 
            {
                Close();
            }
           
        }

        

        //Este botón sirve para crear un objeto persona y añadirlo al Arraylist
        private void btn_insertar_persona_Click(object sender, EventArgs e)
        {
            //Con esto instanciamos el formulario nuevo y le pasamos como parámetro
            //el Arraylist para poder operar con él
            Form_insertar_persona form_nueva_persona = new Form_insertar_persona(personas);
            //Con esto mostramos el formulario después de crearlo
            form_nueva_persona.Show();

        }

        //Este botón sirve para mostrar las personas que se han creado hasta el momento
        private void btn_mostrar_personas_Click(object sender, EventArgs e)
        {
            //Con esto instanciamos el formulario nuevo y le pasamos como parámetro
            //el Arraylist para poder operar con él
            Form_mostrar_personas form_muestra_personas = new Form_mostrar_personas(personas);
            //Con esto mostramos el formulario después de crearlo
            form_muestra_personas.Show();
        }

        //Este botón sirve para que muestre una persona cuyo dni coincida con el que 
        //se introduzca
        private void btn_consultar_por_dni_Click(object sender, EventArgs e)
        {
            //Con esto instanciamos el formulario nuevo y le pasamos como parámetro
            //el Arraylist para poder operar con él
            Form_consultar_por_dni form_consulta = new Form_consultar_por_dni(personas);
            //Con esto mostramos el formulario después de crearlo
            form_consulta.Show();
        }

        //Este botón muestra los 3 nombres del arraylist de personas más largos
        private void btn_mostrar_3_nombres_mas_largos_Click(object sender, EventArgs e)
        {
            //Con esto instanciamos el formulario nuevo y le pasamos como parámetro
            //el Arraylist para poder operar con él
            Form_3_nombres_mas_largos form_3_nombres = new Form_3_nombres_mas_largos(personas);
            //Con esto mostramos el formulario después de crearlo
            form_3_nombres.Show();
        }

        //Este botón muestra todos los datos de la/las personas con algún dato vacío
        private void btn_mostrar_personas_con_algun_dato_vacio_Click(object sender, EventArgs e)
        {
            //Con esto instanciamos el formulario nuevo y le pasamos como parámetro
            //el Arraylist para poder operar con él
            Form_mostrar_persona_con_dato_vacio form_dato_vacio = new Form_mostrar_persona_con_dato_vacio(personas);
            //Con esto mostramos el formulario después de crearlo
            form_dato_vacio.Show();
        }
    }
}
