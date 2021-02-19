using System.Collections;

namespace Examen_19_02_2021
{
    public interface ICliente
    {
        string Apellidos { get; set; }
        string Dni { get; set; }
        ArrayList ListaMonopatines { get; set; }
        string Nombre { get; set; }
        float Peso { get; set; }
        int Saldo { get; set; }

        bool CompruebaAlquiler(IMonopatin m);
    }
}