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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicios_Repaso_5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class VenatanaPrincipal : Window
    {
        public VenatanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnOriginal_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            Button nuevoBoton = new Button();

            nuevoBoton.Content = Convert.ToInt32(boton.Content)+1;

            nuevoBoton.Click += btnOriginal_Click;

            grid.Children.Add(nuevoBoton);

            if ((Grid.GetColumn(boton)+1) % 4 != 0) 
            {
                Grid.SetColumn(nuevoBoton, (Grid.GetColumn(boton) + 1));
                Grid.SetRow(nuevoBoton, Grid.GetRow(boton));
            }
            else
            {
                Grid.SetColumn(nuevoBoton, 0);
                Grid.SetRow(nuevoBoton, (Grid.GetRow(boton)+1));
            }
            
        }
    }
}
