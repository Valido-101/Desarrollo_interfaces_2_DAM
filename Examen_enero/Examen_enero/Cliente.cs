using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_enero
{
    public class Cliente
    {
        private string nombre, apellidos, dni;
        private ArrayList videojuegos;

        public Cliente(string nombre, string apellidos, string dni)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.videojuegos = new ArrayList();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public ArrayList Videojuegos { get => videojuegos; set => videojuegos = value; }

        override
        public string ToString()
        {
            return "Cliente: Nombre -> " + nombre + " | Apellidos -> " + apellidos + " | DNI -> " + dni;
        }
    }
}
