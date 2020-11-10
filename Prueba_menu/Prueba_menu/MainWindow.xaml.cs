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

namespace Prueba_menu
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ContextMenu context_menu;

        public MainWindow()
        {
            InitializeComponent();
            context_menu = new ContextMenu();
            context_menu.Items.Add(new MenuItem());
            MenuItem menu_item1 = (MenuItem)context_menu.Items.GetItemAt(0);
            menu_item1.Header = "Decir hola";
            menu_item1.Click += MenuItem_Click;
            context_menu.Items.Add(new MenuItem());
            MenuItem menu_item2 = (MenuItem)context_menu.Items.GetItemAt(1);
            menu_item2.Header = "Decir adiós";
            menu_item2.Click += MenuItem_Click;
            for(int x=0; x<toolbar_herramientas.Items.Count; x++) 
            {
                Button btn = (Button)toolbar_herramientas.Items.GetItemAt(x);
                btn.Click += context_menu_enable;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menu_item = (MenuItem)sender;
            MessageBox.Show("Has pulsado la opcion "+menu_item.Header);
            e.Handled = true;
        }

        private void context_menu_enable(object sender, RoutedEventArgs e)
        {
            
            toolbar_herramientas.ContextMenu = context_menu;
            context_menu.PlacementTarget = (Button)sender;
            context_menu.IsOpen = true;
            
        }
    }
}
