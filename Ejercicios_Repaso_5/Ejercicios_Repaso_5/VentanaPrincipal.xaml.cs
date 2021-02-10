using System;
using System.Collections.Generic;
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

namespace Ejercicios_Repaso_5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class VentanaPrincipal : Window
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnOriginal_Click(object sender, RoutedEventArgs e)
        {
            //Obtenemos el botón que ha activado el evento
            Button boton = (Button)sender;

            //Comprobamos si el contenido del botón es menor a 16 (el grid es de 4x4 así que el botón 16 será el último)
            if (Convert.ToInt32(boton.Content)<16)
            {
                //Creamos un nuevo botón
                Button nuevoBoton = new Button();

                //Le introducimos el contenido
                nuevoBoton.Content = Convert.ToInt32(boton.Content) + 1;

                //Le asignamos un evento onClick
                nuevoBoton.Click += btnOriginal_Click;

                //Lo añadimos a la lista de hijos del grid
                grid.Children.Add(nuevoBoton);

                //Si la columna del botón no es divisible entre 4 (no es la última columna de esa fila) crea un botón a la derecha
                if ((Grid.GetColumn(boton) + 1) % 4 != 0)
                {
                    Grid.SetColumn(nuevoBoton, (Grid.GetColumn(boton) + 1));
                    Grid.SetRow(nuevoBoton, Grid.GetRow(boton));
                }
                //Si la columna del botón es divisible entre 4 (es la última columna de esa fila) crea un botón en la primera columna
                //de la fila de abajo
                else
                {
                    Grid.SetColumn(nuevoBoton, 0);
                    Grid.SetRow(nuevoBoton, (Grid.GetRow(boton) + 1));
                }
            }
            //Si el contenido del botón que ha lanzado el evento es "16" se pregunta si quiere crear otro formulario
            else 
            {
                //Lanzamos el mensaje y recogemos la respuesta
                var respuesta = MessageBox.Show("El formulario está lleno. ¿Desea crear otro y empezar desde cero?", "Información", MessageBoxButton.YesNo, MessageBoxImage.Information);

                //Si ha pulsado "Sí" se abre una nueva ventana
                if (respuesta == MessageBoxResult.Yes) 
                {
                    VentanaPrincipal nuevaVentana = new VentanaPrincipal();
                    nuevaVentana.Show();
                }
            }
            
        }
    }
}
