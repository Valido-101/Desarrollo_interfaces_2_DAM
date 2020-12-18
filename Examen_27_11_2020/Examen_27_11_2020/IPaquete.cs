using System;

namespace Examen_27_11_2020
{
    public interface IPaquete
    {
        string Descripcion { get; set; }
        int Duracion { get; set; }
        DateTime FechaInicio { get; set; }
        string Nombre { get; set; }
        int Precio { get; set; }

        string ToString();
    }
}