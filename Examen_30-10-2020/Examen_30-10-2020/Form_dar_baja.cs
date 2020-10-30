using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_30_10_2020
{
    public partial class Form_dar_baja : Form
    {
        ArrayList socios;

        public Form_dar_baja(ArrayList socios)
        {
            this.socios = socios;
            InitializeComponent();
        }

        private void Form_dar_baja_Load(object sender, EventArgs e)
        {

        }
    }
}
