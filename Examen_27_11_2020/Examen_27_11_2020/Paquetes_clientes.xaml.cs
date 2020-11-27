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

namespace Examen_27_11_2020
{
    /// <summary>
    /// Lógica de interacción para Paquetes_clientes.xaml
    /// </summary>
    public partial class Paquetes_clientes : Window
    {
        Cliente cliente_seleccionado;
        public Paquetes_clientes(Cliente cliente_seleccionado)
        {
            InitializeComponent();
            this.cliente_seleccionado = cliente_seleccionado;

            foreach(Paquete p in cliente_seleccionado.PaquetesComprados) 
            {
                lstbox_comprados.Items.Add(p);
            }

            foreach (Paquete p in cliente_seleccionado.PaquetesReservados)
            {
                lstbox_reservados.Items.Add(p);
            }

            label_cliente.Content = cliente_seleccionado;
        }

        private void btn_cancelar_Click(object sender, RoutedEventArgs e)
        {
            if (lstbox_comprados.SelectedItem != null) 
            {
                if (cliente_seleccionado.CancelarPaquete((Paquete)lstbox_comprados.SelectedItem) == false)
                {
                    MessageBox.Show("No puede cancelar el paquete '" + ((Paquete)lstbox_comprados.SelectedItem).Nombre + "' porque la fecha de inicio ya ha pasado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else 
                {
                    MessageBox.Show("Paquete '" + ((Paquete)lstbox_comprados.SelectedItem).Nombre + "' cancelado con éxito", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                    lstbox_comprados.Items.Remove(lstbox_comprados.SelectedItem);
                }  
            }
            else 
            {
                if (lstbox_reservados.SelectedItem != null)
                {
                    if (cliente_seleccionado.CancelarPaquete((Paquete)lstbox_reservados.SelectedItem) == false)
                    {
                        MessageBox.Show("No puede cancelar el paquete '" + ((Paquete)lstbox_reservados.SelectedItem).Nombre + "' porque la fecha de inicio ya ha pasado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Paquete '" + ((Paquete)lstbox_reservados.SelectedItem).Nombre + "' cancelado con éxito", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                        lstbox_reservados.Items.Remove(lstbox_reservados.SelectedItem);
                    }
                }
                else 
                {
                    MessageBox.Show("No ha seleccionado ningún paquete", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void lstbox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (((ListBox)sender).Name.Equals("lstbox_comprados"))
            {
                lstbox_reservados.SelectedItem = null;
            }
            else 
            {
                lstbox_comprados.SelectedItem = null;
            }
        }
    }
}
