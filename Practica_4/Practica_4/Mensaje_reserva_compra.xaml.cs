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
using System.Windows.Shapes;

namespace Practica_4
{
    /// <summary>
    /// Lógica de interacción para Mensaje_reserva_compra.xaml
    /// </summary>
    public partial class Mensaje_reserva_compra : Window
    {

        Button btn;

        public Mensaje_reserva_compra(Button btn)
        {
            InitializeComponent();
            this.btn = btn;
        }

        private void btn_comprar_Click(object sender, RoutedEventArgs e)
        {
            btn.Background = Brushes.Black;
            this.Close();
        }

        private void btn_reservar_Click(object sender, RoutedEventArgs e)
        {
            btn.Background = Brushes.Yellow;
            this.Close();
        }
    }
}
