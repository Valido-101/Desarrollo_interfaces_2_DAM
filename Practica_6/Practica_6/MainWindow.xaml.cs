using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
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

namespace Practica_6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList salas;
        ArrayList botones = new ArrayList();
        ArrayList carrito = new ArrayList();
        Sala sala_seleccionada;
        ContextMenu context_menu;
        Ventana_inicio ventana_inicio;

        public MainWindow(ArrayList salas, Ventana_inicio ventana_inicio)
        {
            InitializeComponent();

            this.salas = salas;
            context_menu = new ContextMenu();
            this.ventana_inicio = ventana_inicio;
        }

        private void Ventana_Inicio_Loaded(object sender, RoutedEventArgs e)
        {
            lst_box_salas.Items.Clear();

            foreach(Sala s in salas) 
            {
                lst_box_salas.Items.Add(s);
            }

            for(int x = 0; x < 10; x++) 
            {
                Grid_asientos.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int x = 0; x < 10; x++)
            {
                Grid_asientos.RowDefinitions.Add(new RowDefinition());
            }
        }

        private void lst_box_salas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            botones.Clear();

            sala_seleccionada = (Sala)lst_box_salas.SelectedItem;

            label_fecha.Content = "Fecha: "+sala_seleccionada.Fecha;
            label_fecha.FontSize = 15;
            label_hora.Content = "Hora: " + sala_seleccionada.Hora;
            label_hora.FontSize = 15;
            canvas_escenario.Visibility = Visibility.Visible;
            label_escenario.Visibility = Visibility.Visible;
            label_color_ocupado.Visibility = Visibility.Visible;
            label_ocupado.Visibility = Visibility.Visible;
            label_color_reservado.Visibility = Visibility.Visible;
            label_reservado.Visibility = Visibility.Visible;
            label_color_libre.Visibility = Visibility.Visible;
            label_libre.Visibility = Visibility.Visible;
            btn_confirmar_compra.Visibility = Visibility.Visible;

            MessageBox.Show("Para comprar o reservar un asiento, haga click sobre uno de los asientos. Cada asiento cuesta 7€.","Compra o reserva de asientos",MessageBoxButton.OK,MessageBoxImage.Information);

            int total_asientos = sala_seleccionada.Filas * sala_seleccionada.Columnas;

            for (int x = 0; x < total_asientos; x++)
            {
                botones.Add(new Button());
                Button btn = (Button)botones[x];
                btn.Background = Brushes.White;
                btn.BorderBrush = Brushes.Black;
                btn.Click += context_menu_enable;
                Grid_asientos.Children.Add((Button)botones[x]);
            }

            int pos_arrayList = 0;

            for (int x = 1; x <= sala_seleccionada.Filas; x++)
            {
                for (int y = 1; y <= sala_seleccionada.Columnas; y++)
                {

                    foreach(Asiento a in sala_seleccionada.Asientos) 
                    {
                        if(a.Fila==x && a.Columna == y) 
                        {
                            Button btn = (Button)botones[pos_arrayList];
                            if (a.Estado == "Ocupado") 
                            {
                                btn.Background = Brushes.Red;
                            }
                            else 
                            {
                                if (a.Estado == "Reservado") 
                                {
                                    btn.Background = Brushes.Yellow;
                                }
                            }
                        }
                    }

                    Grid.SetRow((Button)botones[pos_arrayList], x);
                    Grid.SetColumn((Button)botones[pos_arrayList], y);
                    ((Button)botones[pos_arrayList]).Content = x + "." + y;
                    pos_arrayList++;

                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e, Button btn)
        {
            MenuItem menu_item = (MenuItem)sender;
            String id_compra = btn.Content + sala_seleccionada.Nombre_evento;
            switch (menu_item.Header) 
            {
                case "Comprar":
                        sala_seleccionada.Asientos.Add(new Asiento(Grid.GetRow(btn), Grid.GetColumn(btn), true, id_compra));
                        carrito.Add(new Asiento(Grid.GetRow(btn), Grid.GetColumn(btn), true, id_compra));
                    MessageBox.Show("Su id de compra es el siguiente: " + id_compra + ". Guárdelo para poder cancelar la compra en caso de ser necesario.", "Compra realizada con éxito", MessageBoxButton.OK);
                        btn.Background = Brushes.Red;
                    break;
                case "Reservar":
                        sala_seleccionada.Asientos.Add(new Asiento(Grid.GetRow(btn), Grid.GetColumn(btn), false, id_compra));
                        MessageBox.Show("Su id de reserva es el siguiente: " + id_compra + ". Guárdelo para poder cancelar la Reserva en caso de ser necesario.", "Reserva realizada con éxito", MessageBoxButton.OK);
                        btn.Background = Brushes.Yellow;
                    break;
                case "Cancelar compra o reserva":
                    Confimar_cancelacion conf_canc = new Confimar_cancelacion(btn, sala_seleccionada, carrito);
                    conf_canc.Show();
                    break;

            }
        }

        private void context_menu_enable(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Background == Brushes.Red || btn.Background == Brushes.Yellow)
            {
                //Cancelar_compra_reserva cancelacion = new Cancelar_compra_reserva(btn, sala_seleccionada);
                //cancelacion.Show();
                context_menu.Items.Clear();
                context_menu.Items.Add(new MenuItem());
                MenuItem menu_item1 = (MenuItem)context_menu.Items.GetItemAt(0);
                menu_item1.Header = "Cancelar compra o reserva";
                menu_item1.Click += (sendr, RoutedEventArgs) => { MenuItem_Click(sendr, RoutedEventArgs, btn); }; ; ;
            }
            else
            {
                //Mensaje_reserva_compra confirmacion = new Mensaje_reserva_compra(btn, sala_seleccionada);
                //confirmacion.Show();
                context_menu.Items.Clear();
                context_menu.Items.Add(new MenuItem());
                MenuItem menu_item1 = (MenuItem)context_menu.Items.GetItemAt(0);
                menu_item1.Header = "Comprar";
                menu_item1.Click += (sendr, RoutedEventArgs) => { MenuItem_Click(sendr, RoutedEventArgs, btn); }; ;
                context_menu.Items.Add(new MenuItem());
                MenuItem menu_item2 = (MenuItem)context_menu.Items.GetItemAt(1);
                menu_item2.Header = "Reservar";
                menu_item2.Click += (sendr, RoutedEventArgs) => { MenuItem_Click(sendr, RoutedEventArgs, btn); }; ;
            }
            btn.ContextMenu = context_menu;
            context_menu.PlacementTarget = (Button)sender;
            context_menu.IsOpen = true;

        }

        private void Ventana_Inicio_Closed(object sender, EventArgs e)
        {
            ventana_inicio.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
