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

namespace Practica_5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList salas = new ArrayList();
        ArrayList botones = new ArrayList();
        Sala sala_seleccionada;

        public MainWindow()
        {
            InitializeComponent();

            salas.Add(new Sala("Cyrano de Bergerac", "26/06/2021", "20:00"));
            salas.Add(new Sala("Romeo y Julieta", "27/06/2021", "22:00"));
        }

        private void Ventana_Inicio_Loaded(object sender, RoutedEventArgs e)
        {
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

            MessageBox.Show("Para comprar o reservar un asiento, haga click sobre uno de los asientos.","Compra o reserva de asientos",MessageBoxButton.OK,MessageBoxImage.Information);

            for (int x = 0; x < 100; x++)
            {
                botones.Add(new Button());
                Button btn = (Button)botones[x];
                btn.Background = Brushes.White;
                btn.BorderBrush = Brushes.Black;
                btn.Click += btnClick;
                Grid_asientos.Children.Add((Button)botones[x]);
            }

            int pos_arrayList = 0;

            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y <= 10; y++)
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

        private void btnClick(object sender, EventArgs e) 
        {
            Button btn = (Button)sender;
            /*if (btn.Background == Brushes.Red || btn.Background == Brushes.Yellow)
            {
                Cancelar_compra_reserva cancelacion = new Cancelar_compra_reserva(btn, sala_seleccionada);
                cancelacion.Show();
            }
            else 
            {
                Mensaje_reserva_compra confirmacion = new Mensaje_reserva_compra(btn, sala_seleccionada);
                confirmacion.Show();
            }
            */
        }
    }
}
