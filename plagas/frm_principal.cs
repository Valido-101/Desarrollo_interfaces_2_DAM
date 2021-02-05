using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plagas
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();

            helpProvider.HelpNamespace = Path.Combine(Application.StartupPath, @"files\Control de Plagas.chm");

            System.Media.SoundPlayer rep = new System.Media.SoundPlayer();
            
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new alta()).ShowDialog();
        }

        private void modificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetCurrentDirectory();
            this.BackgroundImage = Image.FromFile(dir+@"\files\mosca.jpg");
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetCurrentDirectory();
            this.BackgroundImage = Image.FromFile(dir + @"\files\Mosquito-dengue.jpg");
        }
    }
}
