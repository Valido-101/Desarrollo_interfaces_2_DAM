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
    public partial class Form_3_nombres_mas_largos : Form
    {
        //Constructor del Form_3_nombres_mas_largos vacío
        public Form_3_nombres_mas_largos()
        {
            InitializeComponent();
        }

        //Constructor del Form_3_nombres_mas_largos que recibe por parámetro
        //el arraylist del Form1
        public Form_3_nombres_mas_largos(ArrayList personas)
        {
            InitializeComponent();
            this.personas = personas;
        }

        //Referencia al arraylist del Form1
        ArrayList personas;
        //Variable donde vamos a ir guardando los caracteres del nombre más largo durante esa
        //iteración del bucle
        int nombre_mas_largo=0;
        //Variable donde vamos a guardar los caracteres del nombre más largo de la iteración
        //anterior del bucle
        int nombre_mas_largo_anterior=100;
        //ArrayList donde guardaremos el número de caracteres de los 3 nombres más largos
        ArrayList num_caracteres_nombres_mas_largos = new ArrayList();
        //Variable que se encarga de ver si hay al menos 3 nombres rellenos
        int datos_rellenos = 0;
        
        //Evento que se realizará cuando se cargue el formulario
        private void Form_3_nombres_mas_largos_Load(object sender, EventArgs e)
        {
            //Si hay 3 o más personas se hace el cálculo de los nombres más largos
            if (personas.Count >= 3) 
            {
                //Se recorre el ArrayList personas para asegurarse de que hay al menos
                //3 personas con nombre introducido para que no entre en un bucle infinito
                foreach(Persona p in personas) 
                {
                    //Si el nombre de la persona actual es distinto a cadena vacía aumenta
                    //el contador
                    if (p.getNombre() != "") 
                    {
                        datos_rellenos++;
                    }
                }

                //Si la variable datos rellenos es mayor o igual a 3 (hay al menos 3 personas
                //con el nombre relleno), se inician los cálculos para hallar los 3 nombres
                //más largos
                if (datos_rellenos >= 3) 
                {
                    //Mientras el ArrayList donde guardamos el número de caracteres de los
                    //nombres más largos no tenga 3 elementos (es decir, no haya encontrado
                    //los 3 nombres más largos), se repetirá el bucle
                    while (num_caracteres_nombres_mas_largos.Count < 3)
                    {
                        //El foreach recorre el ArrayList personas 
                        foreach (Persona p in personas)
                        {
                            //Si el nombre de la persona que está revisando en ese momento
                            //tiene más caracteres que la variable nombre_mas_largo (nombre con
                            //más caracteres de esa iteración) y a la vez tiene menos que la
                            //variable nombre_mas_largo_anterior (nombre con más caracteres
                            //de la iteración anterior) guardamos la longitud del nombre 
                            //de la persona actual en la variable nombre_mas_largo
                            if (p.getNombre().Length > nombre_mas_largo && p.getNombre().Length < nombre_mas_largo_anterior)
                            {
                                nombre_mas_largo = p.getNombre().Length;
                            }

                        }

                        //Si esa longitud de caracteres no está almacenada en el Arraylist se guarda
                        if (num_caracteres_nombres_mas_largos.Contains(nombre_mas_largo) == false)
                        {
                            num_caracteres_nombres_mas_largos.Add(nombre_mas_largo);
                        }

                        //La que ha sido la longitud mayor de esta iteración pasa a ser la longitud
                        //mayor de la iteración anterior. Así almacenaremos la longitud mayor
                        //que vaya después de la que ya se ha almacenado
                        nombre_mas_largo_anterior = nombre_mas_largo;
                        //Volvemos a poner esto a 0 para que al volver al bucle no empiece 
                        //con la última longitud de la iteración anterior, que podría dar 
                        //problemas en el bucle
                        nombre_mas_largo = 0;

                    }
                }
                //De lo contrario, se informa al usuario
                else 
                {
                    MessageBox.Show("Debe haber al menos tres personas guardadas con nombre","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            //Si no hay al menos 3 personas informa al usuario y muestra el listbox vacío
            else 
            {

                MessageBox.Show("No hay suficientes personas. Introduzca al menos 3. Actualmente hay "+personas.Count+" personas introducidas.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
            //Con este foreach recorremos el ArrayList de personas
            foreach (Persona p in personas) 
            {

                //Si la longitud del nombre de esa persona coincide con alguna de las 
                //3 mayores longitudes, se guarda el nombre en el listbox
                if (num_caracteres_nombres_mas_largos.Contains(p.getNombre().Length))
                {
                    lstbox_nombres_mas_largos.Items.Add(p.getNombre());
                }
            }
        }
        
    }
}
