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
        private string id_compra;

        public Asiento(int fila, int columna, bool opcion, string id_compra) 
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
            this.id_compra = id_compra;
        }

        public int Fila { get => fila; set => fila = value; }
        public int Columna { get => columna; set => columna = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Id_compra { get => id_compra; set => id_compra = value; }
    }
}
