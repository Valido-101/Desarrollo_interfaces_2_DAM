using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_prueba
{
    public class Paquete
    {
        private string nombreDest;
        private string direccionDest;
        private string provinciaDest;
        private int peso;

        public Paquete(string nombreDest, string direccionDest, string provinciaDest, int peso)
        {
            this.nombreDest = nombreDest;
            this.direccionDest = direccionDest;
            this.provinciaDest = provinciaDest;
            this.peso = peso;
        }

        public string NombreDest { get => nombreDest; set => nombreDest = value; }
        public string DireccionDest { get => direccionDest; set => direccionDest = value; }
        public string ProvinciaDest { get => provinciaDest; set => provinciaDest = value; }
        public int Peso { get => peso; set => peso = value; }

        //public string enviar(Vehiculo vehiculo) 
        //{

        //}
    }
}
