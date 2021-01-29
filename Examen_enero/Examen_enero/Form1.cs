using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            //Esto se encarga de encontrar el archivo chm
            this.helpProvider1.HelpNamespace = Path.Combine(Application.StartupPath, @"..\..\Ayuda\Documento Ayuda Examen.chm");
        }

        private void btn_altaCliente_Click(object sender, EventArgs e)
        {
            //Ocultamos este formulario
            this.Hide();
            //Creamos el otro formulario y lo mostramos
            AltaCliente form_altaCliente = new AltaCliente(clientes);
            form_altaCliente.Show();

            //Cuando se cierre el otro formulario, mostraremos de nuevo el formulario inicial
            form_altaCliente.FormClosed += Form_altaCliente_FormClosed;
        }

        //Método que se ejecutará al cerrarse el formulario AltaCliente
        private void Form_altaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btn_alquilarVideojuego_Click(object sender, EventArgs e)
        {
            //Ocultamos este formulario
            this.Hide();
            //Creamos el otro formulario y lo mostramos
            AlquilarVideojuego form_alquilarVideojuego = new AlquilarVideojuego(videojuegos,clientes);
            form_alquilarVideojuego.Show();

            //Cuando se cierre el otro formulario, mostraremos de nuevo el formulario inicial
            form_alquilarVideojuego.FormClosed += Form_alquilarVideojuego_FormClosed;
        }

        //Método que se ejecutará al cerrarse el formulario AlquilarVideojuego
        private void Form_alquilarVideojuego_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btn_devolverVideojuegos_Click(object sender, EventArgs e)
        {
            //Ocultamos este formulario
            this.Hide();
            //Creamos el otro formulario y lo mostramos
            DevolverVideojuegos form_devolverVideojuegos = new DevolverVideojuegos(clientes, videojuegos);
            form_devolverVideojuegos.Show();

            //Cuando se cierre el otro formulario, mostraremos de nuevo el formulario inicial
            form_devolverVideojuegos.FormClosed += Form_devolverVideojuegos_FormClosed;
        }

        private void Form_devolverVideojuegos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
