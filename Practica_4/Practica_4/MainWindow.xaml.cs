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

namespace Practica_4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList salas = new ArrayList();
        ArrayList botones = new ArrayList();
        bool compra;

        public MainWindow()
        {
            InitializeComponent();

            salas.Add(new Sala("Cyrano de Bergerac", "26/06/2021", "20:00"));
        }

        private void Ventana_Inicio_Loaded(object sender, RoutedEventArgs e)
        {
            int pos_arrayList = 0;

            foreach(Sala s in salas) 
            {
                lst_box_salas.Items.Add(s.Nombre_evento);
            }

            for(int x = 0; x < 100; x++) 
            {
                botones.Add(new Button());
                Button btn = (Button)botones[x];
                btn.Background = Brushes.White;
                btn.BorderBrush = Brushes.Black;
                btn.Click += btnClick;
                Grid_asientos.Children.Add((Button)botones[x]);
            }

            for (int x = 1; x <= 10; x++) 
            {
                for (int y = 1; y <= 10; y++) 
                {

                    Grid.SetRow((Button)botones[pos_arrayList],x);
                    Grid.SetColumn((Button)botones[pos_arrayList], y);
                    pos_arrayList++;

                }
            }
            
        }

        private void lst_box_salas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            foreach(Sala s in salas) 
            {
                if (s.Nombre_evento == Convert.ToString(lst_box_salas.SelectedItem)) 
                {
                    MessageBox.Show("Hola");
                }
            }
        }

        private void btnClick(object sender, EventArgs e) 
        {
            Button btn = (Button)sender;
            if (btn.Background == Brushes.Black || btn.Background == Brushes.Yellow)
            {
                Cancelar_compra_reserva cancelacion = new Cancelar_compra_reserva(btn);
                cancelacion.Show();
            }
            else 
            {
                Mensaje_reserva_compra confirmacion = new Mensaje_reserva_compra(btn);
                confirmacion.Show();
            }
        }
    }
}
