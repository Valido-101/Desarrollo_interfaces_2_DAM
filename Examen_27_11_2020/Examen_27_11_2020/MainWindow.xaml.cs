using System;
using System.Collections;
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

namespace Examen_27_11_2020
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList clientes = new ArrayList();
        ArrayList paquetesReserva = new ArrayList();
        ArrayList paquetesCompra = new ArrayList();

        public MainWindow()
        {
            InitializeComponent();

            paquetesReserva.Add(new Paquete("Maravilla1","Viaje Maravilloso1",50,new DateTime(2021,6,24),5));
            paquetesReserva.Add(new Paquete("Maravilla2", "Viaje Maravilloso2", 60, new DateTime(2020, 8, 21), 5));
            paquetesReserva.Add(new Paquete("Maravilla3", "Viaje Maravilloso3", 40, new DateTime(2019, 3, 12), 5));
            paquetesReserva.Add(new Paquete("Maravilla4", "Viaje Maravilloso4", 50, new DateTime(2025, 4, 5), 5));
            paquetesReserva.Add(new Paquete("Maravilla5", "Viaje Maravilloso5", 90, new DateTime(2021, 2, 7), 5));

            paquetesCompra.Add(new Paquete("MaravillaA", "Viaje MaravillosoA", 20, new DateTime(2022, 7, 24), 5));
            paquetesCompra.Add(new Paquete("MaravillaB", "Viaje MaravillosoB", 40, new DateTime(2020, 4, 24), 5));
            paquetesCompra.Add(new Paquete("MaravillaC", "Viaje MaravillosoC", 10, new DateTime(2011, 2, 24), 5));
            paquetesCompra.Add(new Paquete("MaravillaD", "Viaje MaravillosoD", 80, new DateTime(2013, 5, 24), 5));
            paquetesCompra.Add(new Paquete("MaravillaE", "Viaje MaravillosoE", 120, new DateTime(2021, 8, 24), 5));

            clientes.Add(new Cliente("Juan","Valido Vázquez","123456789V","123454311",(ArrayList)paquetesReserva.Clone(),(ArrayList)paquetesCompra.Clone()));
            clientes.Add(new Cliente("Fernando", "Benítez González", "123456789N", "123454311", (ArrayList)paquetesReserva.Clone(), (ArrayList)paquetesCompra.Clone()));
            clientes.Add(new Cliente("Marta", "Jiménez Pérez", "123456789M", "123454311", (ArrayList)paquetesReserva.Clone(), (ArrayList)paquetesCompra.Clone()));
            clientes.Add(new Cliente("Rocío", "Rodríguez de la Fuente", "123456789U", "123454311", (ArrayList)paquetesReserva.Clone(), (ArrayList)paquetesCompra.Clone()));
            clientes.Add(new Cliente("Francisco", "Gómez Bru", "123456789W", "123454311", (ArrayList)paquetesReserva.Clone(), (ArrayList)paquetesCompra.Clone()));

            lstbox_clientes.ItemsSource = clientes;

            paquetesCompra.Clear();
            paquetesReserva.Clear();
            
        }

        private void btn_siguiente_Click(object sender, RoutedEventArgs e)
        {
            if (lstbox_clientes.SelectedItem != null) 
            {
                Paquetes_clientes paq_cli = new Paquetes_clientes((Cliente)lstbox_clientes.SelectedItem);
                paq_cli.Show();
                this.Hide();
                paq_cli.Closed += Window_Closed;
            }
            else 
            {
                MessageBox.Show("No ha seleccionado ningún cliente", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btn_comprar_paquetes_Click(object sender, RoutedEventArgs e)
        {
            if (lstbox_clientes.SelectedItem != null)
            {
                Comprar_reservar compra_reserva = new Comprar_reservar((Cliente)lstbox_clientes.SelectedItem);
                compra_reserva.Show();
                this.Hide();
                compra_reserva.Closed += Window_Closed;
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningún cliente", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
