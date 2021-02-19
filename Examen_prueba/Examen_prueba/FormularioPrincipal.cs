using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_prueba
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
            Vehiculo v = new Vehiculo("SE1234LL", 12);
            Paquete p = new Paquete("Jesús", "ljnk", "Sevilla", 12);
            if (v.compruebaPaquete(p)) 
            {
                MessageBox.Show("true");
            }
            else 
            {
                MessageBox.Show("false");
            }
        }
    }
}
