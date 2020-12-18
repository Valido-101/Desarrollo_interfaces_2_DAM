using System.Collections;

namespace Examen_27_11_2020
{
    public interface ICliente
    {
        string Apellido { get; set; }
        string Dni { get; set; }
        string Nombre { get; set; }
        ArrayList PaquetesComprados { get; set; }
        ArrayList PaquetesReservados { get; set; }
        string Telefono { get; set; }

        bool CancelarPaquete(Paquete paquete);
        void ComprarPaquete(Paquete paquete);
        void ReservarPaquete(Paquete paquete);
        string ToString();
    }
}