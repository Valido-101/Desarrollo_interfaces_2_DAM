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
    public partial class Form_mostrar_persona_con_dato_vacio : Form
    {
        //Constructor vacío para Form_mostrar_persona_con_dato_vacio
        public Form_mostrar_persona_con_dato_vacio()
        {
            InitializeComponent();
        }

        //Referencia al ArrayList de personas del Form1
        ArrayList personas;
        //ArrayList donde guardaremos las personas con algún dato vacío
        ArrayList personas_con_dato_vacio = new ArrayList();

        //Constructor que recibe como parámetro el ArrayList del Form1
        public Form_mostrar_persona_con_dato_vacio(ArrayList personas)
        {
            InitializeComponent();
            this.personas = personas;
        }

        //Evento que se realiza al cargar el formulario
        private void Form_mostrar_persona_con_dato_vacio_Load(object sender, EventArgs e)
        {

            //Si no se ha insertado ninguna persona se informa al usuario
            if (personas.Count == 0) 
            {
                MessageBox.Show("No se ha insertado ninguna persona.");
            }
            else 
            {
                //Si no, se recorre el ArrayList de personas 
                foreach (Persona p in personas)
                {
                    //Si alguna tiene algún atributo como cadena vacía (los de tipo string)
                    //o 0 (los de tipo numérico), se guarda el nombre en el nuevo arraylist
                    if (p.getNombre() == "" || p.getApellidos() == "" || p.getDni() == "" || p.getFechaNacimiento() == "" || p.getPeso() == 0 || p.getAltura() == 0)
                    {
                        personas_con_dato_vacio.Add("DNI: "+p.getDni());
                    }
                }

                //Si al finalizar el bucle no se encuentra ninguna persona con algún dato
                //vacío se informa al usuario
                if (personas_con_dato_vacio.Count == 0)
                {
                    MessageBox.Show("No hay ninguna persona con algún dato vacío.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Si no se añadenn los nombres de la persona con algún dato vacío
                    //al listbox y se muestra
                    foreach (string s in personas_con_dato_vacio)
                    {
                        lstbox_personas_dato_vacio.Items.Add(s);
                    }
                }
            }

        }
    }

}
