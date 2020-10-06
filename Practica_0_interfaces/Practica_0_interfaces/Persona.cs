using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_0_interfaces
{
    class Persona
    {

        private string dni;
        private string nombre;
        private string apellidos;
        private string fecha_nac;
        private int peso;
        private double altura;

        public Persona()
        {

        }

        public Persona(string dni, string nombre, string apellidos, string fecha_nac, int peso, double altura) 
        {

            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fecha_nac = fecha_nac;
            this.peso = peso;
            this.altura = altura;

        }

        public string getDni()
        {
            return dni;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getApellidos()
        {
            return apellidos;
        }

        public string getFechaNacimiento()
        {
            return fecha_nac;
        }

        public int getPeso()
        {
            return peso;
        }

        public double getAltura()
        {
            return altura;
        }

        public void setDni(string dni)
        {
            this.dni = dni;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }

        public void setFechaNacimiento(string fecha_nac)
        {
            this.fecha_nac = fecha_nac;
        }

        public void setPeso(int peso)
        {
            this.peso = peso;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public string toString() 
        {
            return "Nombre: " + nombre + "\nApellidos: " + apellidos + "\nDni: " + dni + "\nFecha de nacimiento: " + fecha_nac + "\nPeso: " + peso + "\nAltura: " + altura;
        } 
    }
}
