using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_examen_diciembre
{
    public class Articulo
    {
        private string nombre;
        private int codigo;
        private string descripcion;
        private double precio;
        private int unidades;

        public Articulo(string nombre, int codigo, string descripcion, double precio, int unidades)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.unidades = unidades;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Unidades { get => unidades; set => unidades = value; }

        public double aplicarDescuento(int descuento) 
        {
            return precio - (precio * (descuento / 100));
        }

        override
        public string ToString() 
        {
            return codigo + ": " + nombre;
        }
    }
}
