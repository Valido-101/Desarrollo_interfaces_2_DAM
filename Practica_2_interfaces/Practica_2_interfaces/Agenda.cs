using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_interfaces
{
    public class Agenda
    {
        private int id;
        private string nombre;
        private int annio;

        public Agenda() 
        {
        
        }

        public Agenda(int id, string nombre, int annio) 
        {
            this.id = id;
            this.nombre = nombre;
            this.annio = annio;
        }

        public void setId(int id) 
        {
            this.id = id;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setAnnio(int annio)
        {
            this.annio = annio;
        }

        public int getId()
        {
            return id;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getAnnio()
        {
            return annio;
        }
    }
}
