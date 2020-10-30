using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_30_10_2020
{
    public class Socio
    {
        private string nombre;
        private string apellidos;
        private int id_socio;
        private ArrayList libros;

        public Socio(string nombre, string apellidos, int id_socio, ArrayList libros) 
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.id_socio = id_socio;
            this.libros = libros;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Id_socio { get => id_socio; set => id_socio = value; }
        public ArrayList Libros { get => libros; set => libros = value; }

        public string toString() 
        {
            return "Nombre: " + nombre + ", Apellidos: " + apellidos;
        }
    }
}
