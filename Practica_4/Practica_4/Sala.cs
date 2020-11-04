using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    public class Sala
    {
        private string nombre_evento;
        private string fecha;
        private string hora;
        private ArrayList asientos;

        public Sala(string nombre_evento, string fecha, string hora) 
        {
            this.nombre_evento = nombre_evento;
            this.fecha = fecha;
            this.hora = hora;
            asientos = new ArrayList();
        }

        public string Nombre_evento { get => nombre_evento; set => nombre_evento = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public ArrayList Asientos { get => asientos; set => asientos = value; }

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
