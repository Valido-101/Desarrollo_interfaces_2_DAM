using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prueba_wpf
{
    /// <summary>
    /// Lógica de interacción para Consultar_por_dni.xaml
    /// </summary>
    public partial class Consultar_por_dni : Window
    {
        //Referencia para el ArrayList de personas del Form1
        ArrayList personas;

        //Variable que nos servirá para saber si la persona se ha encontrado o no
        bool encontrado;

        //Constructor vacío del Form_consultar_por_dni
        public Consultar_por_dni()
        {
            InitializeComponent();
        }

        //Constructor del Form_consultar_por_dni que recibe como parámetro el arraylist
        //del Form1
        public Consultar_por_dni(ArrayList personas)
        {
            InitializeComponent();
            this.personas = personas;
        }

        //Evento que se realizará cuando se haga click en el botón Iniciar Búsqueda
        private void btn_iniciar_busqueda_Click(object sender, EventArgs e)
        {
            //Ponemos el valor inicial como false
            encontrado = false;

            //Si no hay ninguna persona creada, se avisa al usuario
            if (personas.Count == 0)
            {
                MessageBox.Show("No se ha insertado ninguna persona.", "Información");
            }
            //Si no es así, se recorre el ArrayList de personas y se muestra la que tenga
            //un dni que coincida con el introducido, modificando el booleano a true
            else
            {
                foreach (Persona p in personas)
                {
                    if (p.getDni() == txt_box_dni.Text)
                    {
                        MessageBox.Show(p.toString());
                        encontrado = true;
                    }
                }

                //Si el booleano es false (no se ha encontrado dicho dni), se muestra un aviso
                //por pantalla
                if (encontrado == false)
                {
                    MessageBox.Show("No se ha encontrado ninguna persona con el dni introducido.", "Información");
                }

            }
        }

        //Botón que cierra el programa cuando se le da click
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
