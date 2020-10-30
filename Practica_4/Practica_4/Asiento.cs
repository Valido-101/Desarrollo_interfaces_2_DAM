using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    public class Asiento
    {
        private int fila;
        private int columna;
        private string estado;

        public Asiento(int fila, int columna, bool opcion) 
        {
            this.fila = fila;
            this.columna = columna;
            if (opcion == true) 
            {
                estado = "Ocupado";
            }
            else 
            {
                estado = "Reservado";
            }
        }

        public int Fila { get => fila; set => fila = value; }
        public int Columna { get => columna; set => columna = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
