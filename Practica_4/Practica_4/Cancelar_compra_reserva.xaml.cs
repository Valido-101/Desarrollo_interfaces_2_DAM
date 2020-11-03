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
    /// Lógica de interacción para Cancelar_compra_reserva.xaml
    /// </summary>
    public partial class Cancelar_compra_reserva : Window
    {
        Button btn1;

        public Cancelar_compra_reserva(Button btn1)
        {
            InitializeComponent();
            this.btn1 = btn1;
            if (btn1.Background == Brushes.Black)
            {
                texto_mensaje.Content = "¿Desea cancelar la compra?";
            }
            else 
            {
                texto_mensaje.Content = "¿Desea cancelar la reserva?";
            }
        }

        private void btn_si_Click(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.White;
            this.Close();
        }

        private void btn_no_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
