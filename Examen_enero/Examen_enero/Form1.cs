using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_enero
{
    public partial class Form_inicio : Form
    {
        ArrayList videojuegos = new ArrayList();
        ArrayList clientes = new ArrayList();

        public Form_inicio()
        {
            InitializeComponent();

            videojuegos.Add(new Videojuego(1, "Blasphemous", "Metroidvania"));
            videojuegos.Add(new Videojuego(2, "Dragon Ball FighterZ", "Lucha"));
            videojuegos.Add(new Videojuego(3,"Marvel's SpiderMan", "Mundo Abierto"));
            videojuegos.Add(new Videojuego(4, "God of War 4", "Mundo Abierto"));
            videojuegos.Add(new Videojuego(5, "Dragon Ball Z: Kakarot", "Lucha/Mundo Abierto"));
        }

        private void btn_altaCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaCliente form_altaCliente = new AltaCliente(clientes);
            form_altaCliente.Show();

            form_altaCliente.FormClosed += Form_altaCliente_FormClosed;
        }

        private void Form_altaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
