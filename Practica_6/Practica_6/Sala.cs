﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6
{
    public class Sala
    {
        private string nombre_evento;
        private string fecha;
        private string hora;
        private ArrayList asientos;
        private int filas;
        private int columnas;
        private string ruta_imagen;

        public Sala(string nombre_evento, string fecha, string hora, int filas, int columnas, string ruta_imagen)
        {
            this.nombre_evento = nombre_evento;
            this.fecha = fecha;
            this.hora = hora;
            asientos = new ArrayList();
            this.filas = filas;
            this.columnas = columnas;
            this.ruta_imagen = ruta_imagen;
        }

        public string Nombre_evento { get => nombre_evento; set => nombre_evento = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public ArrayList Asientos { get => asientos; set => asientos = value; }
        public int Filas { get => filas; set => filas = value; }
        public int Columnas { get => columnas; set => columnas = value; }
        public string Ruta_imagen { get => ruta_imagen; set => ruta_imagen = value; }

        public void addAsiento(Asiento a)
        {
            asientos.Add(a);
        }

        override public String ToString()
        {
            return Nombre_evento;
        }
    }
}
