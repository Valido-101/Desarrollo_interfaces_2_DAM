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

namespace Practica_6
{
    /// <summary>
    /// Lógica de interacción para Confirmar_compra.xaml
    /// </summary>
    public partial class Confirmar_compra : Window
    {

        ArrayList carrito;
        Sala sala_seleccionada;

        public Confirmar_compra(ArrayList carrito, Sala sala_seleccionada)
        {
            InitializeComponent();
            this.carrito = carrito;
            this.sala_seleccionada = sala_seleccionada;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            label_total.Content = "(Total: " + (carrito.Count * 7) + "€)";
        }

        private void btn_confirmar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
