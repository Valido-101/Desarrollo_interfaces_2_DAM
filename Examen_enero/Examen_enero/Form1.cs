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
    }
}
