using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2_interfaces
{
    public class Tarea
    {
        private int id_agenda;
        private int dia;
        private int mes;
        private DateTime hora;
        private string descripcion;
        private string lugar;

        public Tarea() 
        {
            
        }

        public Tarea(int id_agenda,int dia, int mes, DateTime hora, string descripcion, string lugar) 
        {
            this.id_agenda = id_agenda;
            this.dia = dia;
            this.mes = mes;
            this.hora = hora;
            this.descripcion = descripcion;
            this.lugar = lugar;
        }

        public void setId_agenda(int id_agenda) 
        {
            this.id_agenda = id_agenda;
        }

        public void setDia(int dia)
        {
            this.dia = dia;
        }

        public void setMes(int mes)
        {
            this.mes = mes;
        }

        public void setHora(DateTime hora)
        {
            this.hora = hora;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public void setLugar(string lugar)
        {
            this.lugar = lugar;
        }

        public int getId_agenda()
        {
            return id_agenda;
        }

        public int getDia()
        {
            return dia;
        }

        public int getMes()
        {
            return mes;
        }

        public DateTime getHora()
        {
            return hora;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public string getLugar()
        {
            return lugar;
        }
    }
}
