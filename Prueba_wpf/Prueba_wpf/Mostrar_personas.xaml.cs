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
    /// Lógica de interacción para Mostrar_personas.xaml
    /// </summary>
    public partial class Mostrar_personas : Window
    {
        public Mostrar_personas()
        {
            InitializeComponent();
        }

        //Referencia para el arraylist de personas del Form1
        ArrayList personas;

        //Constructor del Form_mostrar_personas que tiene como parámetro el arraylist del
        //Form1
        public Mostrar_personas(ArrayList personas)
        {
            InitializeComponent();
            this.personas = personas;
        }

        //Evento que se realiza al cargar el formulario y que muestra los datos de cada
        //objeto persona en el arraylist e indica cuántas hay.
        private void Mostrar_personas_Loaded(object sender, EventArgs e)
        {
            foreach (Persona p in personas)
            {
                lst_box_mostrar_personas.Items.Add(p.toString());
            }

            label_personas.Content = "Hay " + personas.Count + " personas";
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
