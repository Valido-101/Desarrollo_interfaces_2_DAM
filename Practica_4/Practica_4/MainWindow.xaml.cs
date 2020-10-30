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

        public MainWindow()
        {
            InitializeComponent();

            salas.Add(new Sala("Cyrano de Bergerac", "26/06/2021", "20:00"));
            
        }

        private void Ventana_Inicio_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(Sala s in salas) 
            {
                lst_box_salas.Items.Add(s.Nombre_evento);
            }

            ColumnDefinition columna = new ColumnDefinition();
            
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
    }
}
