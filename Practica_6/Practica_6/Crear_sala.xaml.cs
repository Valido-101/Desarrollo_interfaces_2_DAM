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
    /// Lógica de interacción para Crear_sala.xaml
    /// </summary>
    public partial class Crear_sala : Window
    {
        ArrayList salas;
        Ventana_inicio ventana_inicio;

        public Crear_sala(ArrayList salas, Ventana_inicio ventana_inicio)
        {
            InitializeComponent();

            this.salas = salas;
            this.ventana_inicio = ventana_inicio;
        }

        private void btn_crear_Click(object sender, RoutedEventArgs e)
        {
            //salas.Add(new Sala(txtbox_nombre_evento.Text,txtbox_fecha.Text,txtbox_hora.Text,Convert.ToInt32(txtbox_filas.Text),Convert.ToInt32(txtbox_columnas.Text)));
            MessageBox.Show("Sala creada con éxito.","Información",MessageBoxButton.OK,MessageBoxImage.Information);

            this.Close();

        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            ventana_inicio.Show();
        }

        private void txtbox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox txt_box = (TextBox)sender;

            if (txt_box.Text == "Formato dd/mm/aaa" || txt_box.Text == "Formato hh:mm" || txt_box.Text == "Número de filas" || txt_box.Text == "Butacas por fila") 
            {
                txt_box.Text = "";
                txt_box.Foreground = Brushes.Black;
            }
            else 
            {
                txt_box.Foreground = Brushes.Black;
            }

        }

        private void txtbox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox txtbox = ((TextBox)sender);

            if (txtbox.Text == "") 
            {
                txtbox.Foreground = Brushes.Gray;

                switch (txtbox.Name) 
                {
                    case "txtbox_fecha":
                            txtbox.Text = "Formato dd/mm/aaa";
                        break;

                    case "txtbox_hora":
                            txtbox.Text = "Formato hh:mm";
                        break;

                    case "txtbox_filas":
                            txtbox.Text = "Número de filas";
                        break;

                    case "txtbox_columnas":
                            txtbox.Text = "Butacas por fila";
                        break;
                }
            }
        }
    }
}
