using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_27_11_2020
{
    //    Atributos: nombre, descripción, precio, fechaInicio, duración.
    //    Métodos: getter, setter, constructor(parametrizado), ToString que devuelva el nombre y precio(sobrecargar)
    public class Paquete : IPaquete
    {
        private string nombre;
        private string descripcion;
        private int precio;
        private DateTime fechaInicio;
        private int duracion;

        public Paquete(string nombre, string descripcion, int precio, DateTime fechaInicio, int duracion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.fechaInicio = fechaInicio;
            this.duracion = duracion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        override
        public string ToString()
        {
            return "Nombre: " + nombre + ", Precio: " + precio;
        }
    }
}
