﻿using System;
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

namespace Prueba_tunneling_bubbling
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void onClickContenido(object sender, RoutedEventArgs e) 
        {
            MessageBox.Show("Soy el botón contenido");
        }

        public void onClickContenedor(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Soy el botón contenedor");
        }
    }
}