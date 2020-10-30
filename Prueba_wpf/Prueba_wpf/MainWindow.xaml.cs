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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prueba_wpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            personas.Add(new Persona("dsdc","svs","vscvs","dsfsdf",1,1));
            personas.Add(new Persona("dasdada", "svasds", "vscvsasdas", "", 1, 1));
        }

        //Arraylist de personas donde guardaremos cada una de las personas creadas
        ArrayList personas = new ArrayList();


        private void btn_insertar_persona_Click(object sender, RoutedEventArgs e)
        {
            //Con esto instanciamos el formulario nuevo y le pasamos como parámetro
            //el Arraylist para poder operar con él
            Insertar_persona ventana_nueva_persona = new Insertar_persona(personas);
            //Con esto mostramos el formulario después de crearlo
            ventana_nueva_persona.Show();
        }

        private void btn_mostrar_personas_Click(object sender, RoutedEventArgs e)
        {
            //Con esto instanciamos el formulario nuevo y le pasamos como parámetro
            //el Arraylist para poder operar con él
            Mostrar_personas form_muestra_personas = new Mostrar_personas(personas);
            //Con esto mostramos el formulario después de crearlo
            form_muestra_personas.Show();
        }

        private void btn_consultar_persona_dni_Click(object sender, RoutedEventArgs e)
        {
            //Con esto instanciamos el formulario nuevo y le pasamos como parámetro
            //el Arraylist para poder operar con él
            Consultar_por_dni form_consulta = new Consultar_por_dni(personas);
            //Con esto mostramos el formulario después de crearlo
            form_consulta.Show();
        }

        private void btn_mostrar_personas_con_algun_dato_vacio_Click(object sender, EventArgs e)
        {
            //Con esto instanciamos el formulario nuevo y le pasamos como parámetro
            //el Arraylist para poder operar con él
            Mostrar_persona_dato_vacio form_dato_vacio = new Mostrar_persona_dato_vacio(personas);
            //Con esto mostramos el formulario después de crearlo
            form_dato_vacio.Show();
        }

        private void btn_mostrar_3_nombres_mas_largos_Click(object sender, EventArgs e)
        {
            //Con esto instanciamos el formulario nuevo y le pasamos como parámetro
            //el Arraylist para poder operar con él
            _3_nombres_mas_largos form_3_nombres = new _3_nombres_mas_largos(personas);
            //Con esto mostramos el formulario después de crearlo
            form_3_nombres.Show();
        }

        private void btn_salir_aplicacion_Click(object sender, RoutedEventArgs e)
        {
            var salir = MessageBox.Show("¿Desea salir de la aplicación?","Salir",MessageBoxButton.YesNo);

            if (salir == MessageBoxResult.Yes) 
            {
                this.Close();
            }
        }
    }
}
