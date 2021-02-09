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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicios_Repaso_4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class VentanaPrincipal : Window
    {

        //Variable de control que indica dónde se guarda el texto de TextBox
        private bool conmutarPulsado = false;

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnConmutar_Click(object sender, RoutedEventArgs e)
        {
            if (conmutarPulsado)
            {
                conmutarPulsado = false;
            }
            else
            {
                conmutarPulsado = true;
            }
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            switch (conmutarPulsado)
            {
                case false:

                    lstbox1.Items.Add(txtboxInput.Text);

                    break;
                case true:

                    combobox1.Items.Add(txtboxInput.Text);

                    break;
            }

            txtboxInput.Clear();
        }

        public ListBox getListBox()
        {
            return lstbox1;
        }

        public ComboBox getComboBox()
        {
            return combobox1;
        }

        private void btnNuevoFormulario_Click(object sender, RoutedEventArgs e)
        {
            ArrayList listaLstBox = new ArrayList();
            ArrayList listaComboBox = new ArrayList();

            foreach (string item in combobox1.Items)
            {
                listaComboBox.Add(item);
            }

            foreach (string item in lstbox1.Items)
            {
                listaLstBox.Add(item);
            }

            VentanaSecundaria ventanaSecundaria = new VentanaSecundaria(this, listaComboBox, listaLstBox);
            ventanaSecundaria.Show();
        }
    }
}
