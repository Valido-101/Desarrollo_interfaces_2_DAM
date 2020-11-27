using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Examen_27_11_2020
{
//Atributos: nombre, apellido, dni, teléfono, paquetesReservados, paquetesComprados.

//Métodos: getter, setter, constructor(parametrizado), ToString que devuelva el dni y nombre(sobrecargar)

//CancelarPaquete: eliminará un paquete de la lista de comprados o reservados(precargar con al menos 5 paquetes
//cada una), dependiendo de lo que haya cancelado.Si la fecha ya ha pasado, no podrá cancelarlo y mostrará un mensaje por
//pantalla.
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string telefono;
        private ArrayList paquetesReservados;
        private ArrayList paquetesComprados;

        public Cliente(string nombre, string apellido, string dni, string telefono, ArrayList paquetesReservados, ArrayList paquetesComprados)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
            this.paquetesReservados = paquetesReservados;
            this.paquetesComprados = paquetesComprados;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public ArrayList PaquetesReservados { get => paquetesReservados; set => paquetesReservados = value; }
        public ArrayList PaquetesComprados { get => paquetesComprados; set => paquetesComprados = value; }

        public void ComprarPaquete(Paquete paquete) 
        {
            paquetesComprados.Add(paquete);
            MessageBox.Show("Paquete '" + paquete.Nombre + "' comprado con éxito", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void ReservarPaquete(Paquete paquete) 
        {
            paquetesReservados.Add(paquete);
            MessageBox.Show("Paquete '" + paquete.Nombre + "' reservado con éxito", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public bool CancelarPaquete(Paquete paquete) 
        {
            if (DateTime.Compare(paquete.FechaInicio,System.DateTime.Now)<=0) 
            {
                if (paquetesComprados.Contains(paquete)) 
                {
                    paquetesComprados.Remove(paquete);
                    return true;
                }
                else 
                {
                    paquetesReservados.Remove(paquete);
                    return true;
                }
            }
            else 
            {
                return false;
            }
        }

        override
        public string ToString()
        {
            return "DNI: " + dni + ", Nombre: " + nombre;
        }
    }
}
