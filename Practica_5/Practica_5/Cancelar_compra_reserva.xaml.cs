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

namespace Practica_5
{
    /// <summary>
    /// Lógica de interacción para Cancelar_compra_reserva.xaml
    /// </summary>
    public partial class Cancelar_compra_reserva : Window
    {
        Button btn1;
        Sala sala_seleccionada;

        public Cancelar_compra_reserva(Button btn1, Sala sala_seleccionada)
        {
            InitializeComponent();
            this.btn1 = btn1;
            this.sala_seleccionada = sala_seleccionada;
            if (btn1.Background == Brushes.Red)
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
            Confimar_cancelacion conf_canc = new Confimar_cancelacion(btn1, sala_seleccionada);
            conf_canc.Show();
            //btn1.Background = Brushes.White;
            this.Close();
        }

        private void btn_no_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
