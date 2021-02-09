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

namespace Ejercicios_Repaso_4
{
    /// <summary>
    /// Lógica de interacción para VentanaSecundaria.xaml
    /// </summary>
    public partial class VentanaSecundaria : Window
    {

        private bool conmutarPulsado = false;
        private VentanaPrincipal ventanaAnterior;

        public VentanaSecundaria()
        {
            InitializeComponent();
        }

        public VentanaSecundaria(VentanaPrincipal ventanaAnterior, ArrayList datoscb, ArrayList datoslb)
        {
            InitializeComponent();

            this.ventanaAnterior = ventanaAnterior;

            foreach (var item in datoscb)
            {
                lstbox1.Items.Add(item);
            }

            foreach (var item in datoslb)
            {
                combobox1.Items.Add(item);
            }
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (var item in combobox1.Items)
            {
                if (!ventanaAnterior.getListBox().Items.Contains(item))
                {
                    ventanaAnterior.getListBox().Items.Add(item);
                }
            }

            foreach (var item in lstbox1.Items)
            {
                if (!ventanaAnterior.getComboBox().Items.Contains(item))
                {
                    ventanaAnterior.getComboBox().Items.Add(item);
                }
            }
        }
    }
}
