using System;
using System.Collections;
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

namespace Practica_6
{
    /// <summary>
    /// Lógica de interacción para Ventana_inicio.xaml
    /// </summary>
    public partial class Ventana_inicio : Window
    {
        ArrayList salas = new ArrayList();

        public Ventana_inicio()
        {
            InitializeComponent();

            salas.Add(new Sala("Cyrano de Bergerac", "26/06/2021", "20:00", 10, 10));
            salas.Add(new Sala("Romeo y Julieta", "27/06/2021", "22:00", 10, 10));
        }

        private void btn_crear_sala_Click(object sender, RoutedEventArgs e)
        {
            Crear_sala crear_sala = new Crear_sala(salas,this);
            crear_sala.Show();
            this.Hide();
        }

        private void btn_seleccionar_sala_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventana_salas = new MainWindow(salas,this);
            ventana_salas.Show();
            this.Hide();
        }
    }
}
