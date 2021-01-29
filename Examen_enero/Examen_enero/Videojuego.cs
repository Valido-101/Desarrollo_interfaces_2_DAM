using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_enero
{
    public class Videojuego
    {
        private int codigo;
        private string nombre, tema;

        public Videojuego(int codigo, string nombre, string tema) 
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.tema = tema;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tema { get => tema; set => tema = value; }

        override
        public string ToString()
        {
            return "Videojuego: Código -> " + codigo + " | Nombre -> " + nombre + " | Tema -> " + tema;
        }

    }
}
