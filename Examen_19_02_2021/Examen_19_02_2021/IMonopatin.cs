namespace Examen_19_02_2021
{
    public interface IMonopatin
    {
        int Codigo { get; set; }
        string Marca { get; set; }
        float PesoMaximo { get; set; }
        int Valor { get; set; }
        int VecesAlquilado { get; set; }


        bool compruebaEstado();
    }
}