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
    /// Lógica de interacción para Confimar_cancelacion.xaml
    /// </summary>
    public partial class Confimar_cancelacion : Window
    {

        Button btn;
        Sala sala_seleccionada;
        ArrayList carrito;

        public Confimar_cancelacion(Button btn, Sala sala_seleccionada, ArrayList carrito)
        {
            InitializeComponent();
            this.btn = btn;
            this.sala_seleccionada = sala_seleccionada;
            this.carrito = carrito;
        }

        private void btn_aceptar_Click(object sender, RoutedEventArgs e)
        {
            if (txtbox_id_compra.Text != null)
            {
                foreach (Asiento a in sala_seleccionada.Asientos)
                {
                    if (a.Fila == Grid.GetRow(btn) && a.Columna == Grid.GetColumn(btn))
                    {
                        if (a.Id_compra.Equals(btn.Content + sala_seleccionada.Nombre_evento)) 
                        {
                            btn.Background = Brushes.White;
                            sala_seleccionada.Asientos.Remove(a);
                            carrito.Remove(a);
                            MessageBox.Show("Cancelación realizada con éxito", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                        }
                    }
                }
                this.Close();
            }
            else 
            {
                MessageBox.Show("No ha escrito nada", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
