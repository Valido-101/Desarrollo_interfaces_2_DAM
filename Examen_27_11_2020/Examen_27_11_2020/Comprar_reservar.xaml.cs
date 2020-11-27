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
using System.Windows.Shapes;

namespace Examen_27_11_2020
{
    /// <summary>
    /// Lógica de interacción para Comprar_reservar.xaml
    /// </summary>
    public partial class Comprar_reservar : Window
    {
        Cliente cliente_seleccionado;

        ArrayList paquetes = new ArrayList();

        public Comprar_reservar(Cliente cliente_seleccionado)
        {
            InitializeComponent();
            this.cliente_seleccionado = cliente_seleccionado;

            label_cliente.Content = cliente_seleccionado;

            paquetes.Add(new Paquete("NuevoPaquete1", "Viaje Maravilloso1", 50, new DateTime(2021, 6, 24), 5));
            paquetes.Add(new Paquete("NuevoPaquete2", "Viaje Maravilloso2", 60, new DateTime(2020, 8, 21), 5));
            paquetes.Add(new Paquete("NuevoPaquete3", "Viaje Maravilloso3", 40, new DateTime(2019, 3, 12), 5));
            paquetes.Add(new Paquete("NuevoPaquete4", "Viaje Maravilloso4", 50, new DateTime(2025, 4, 5), 5));
            paquetes.Add(new Paquete("NuevoPaquete5", "Viaje Maravilloso5", 90, new DateTime(2021, 2, 7), 5));

            Rellenar_ComboBox(paquetes);

            Rellenar_lstbox();
        }

        private void btn_comprar_Click(object sender, RoutedEventArgs e)
        {
            cliente_seleccionado.ComprarPaquete((Paquete)combobox_paquetes.SelectedItem);
            Rellenar_lstbox();
            Rellenar_ComboBox(paquetes);
        }

        private void btn_reservar_Click(object sender, RoutedEventArgs e)
        {
            cliente_seleccionado.ReservarPaquete((Paquete)combobox_paquetes.SelectedItem);
            Rellenar_lstbox();
            Rellenar_ComboBox(paquetes);
        }

        private void Rellenar_lstbox()
        {
            lstbox_paquetes_comprados.Items.Clear();
            lstbox_paquetes_reservados.Items.Clear();

            foreach (Paquete p in cliente_seleccionado.PaquetesComprados)
            {
                lstbox_paquetes_comprados.Items.Add(p);
            }

            foreach (Paquete p in cliente_seleccionado.PaquetesReservados)
            {
                lstbox_paquetes_reservados.Items.Add(p);
            }
        }

        private void Rellenar_ComboBox(ArrayList paquetes) 
        {
            combobox_paquetes.Items.Clear();

            foreach(Paquete p in paquetes) 
            {
                if(lstbox_paquetes_comprados.Items.Contains(p)==false && lstbox_paquetes_reservados.Items.Contains(p) == false) 
                {
                   combobox_paquetes.Items.Add(p);
                }
            }
        }
    }
}
