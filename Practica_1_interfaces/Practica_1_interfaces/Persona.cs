using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_interfaces
{
    //Clase persona que servirá para crear los objetos
    class Persona
    {
        //Atributos
        private string dni;
        private string nombre;
        private string apellidos;
        private string fecha_nac;
        private int peso;
        private double altura;

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Fecha_nac { get => fecha_nac; set => fecha_nac = value; }
        public int Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }

        //Constructor vacío
        public Persona()
        {

        }

        //Constructor con parámetros
        public Persona(string dni, string nombre, string apellidos, string fecha_nac, int peso, double altura)
        {

            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Fecha_nac = fecha_nac;
            this.Peso = peso;
            this.Altura = altura;

        }


        //Métodos getter y setter 
        public string getDni()
        {
            return Dni;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public string getApellidos()
        {
            return Apellidos;
        }

        public string getFechaNacimiento()
        {
            return Fecha_nac;
        }

        public int getPeso()
        {
            return Peso;
        }

        public double getAltura()
        {
            return Altura;
        }

        public void setDni(string dni)
        {
            this.Dni = dni;
        }

        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        public void setApellidos(string apellidos)
        {
            this.Apellidos = apellidos;
        }

        public void setFechaNacimiento(string fecha_nac)
        {
            this.Fecha_nac = fecha_nac;
        }

        public void setPeso(int peso)
        {
            this.Peso = peso;
        }

        public void setAltura(double altura)
        {
            this.Altura = altura;
        }

        //Método toString para mostrar datos
        public string toString()
        {
            return "Nombre: " + Nombre + "\n Apellidos: " + Apellidos + "\n Dni: " + Dni + "\n Fecha de nacimiento: " + Fecha_nac + "\n Peso: " + Peso + "\n Altura: " + Altura;
        }
    }
}
