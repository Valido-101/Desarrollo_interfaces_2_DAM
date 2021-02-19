using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Examen_prueba
{
    public class Vehiculo
    {
        private string matricula;
        private int pesoPermitido;
        private List<Paquete> paquetes;

        public Vehiculo(string matricula, int pesoPermitido)
        {
            this.matricula = matricula;
            this.pesoPermitido = pesoPermitido;
            this.paquetes = new List<Paquete>();
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public int PesoPermitido { get => pesoPermitido; set => pesoPermitido = value; }
        public List<Paquete> Paquetes { get => paquetes; set => paquetes = value; }

        public bool compruebaPaquete(Paquete paquete) 
        {
            //Expresión regular (mayúsculas de la A a la Z que se repitan 2 veces al principio)
            string regex = @"^([A-Z]{2})";

            string provincia_v = "";
            string provincia_p = "";

            //Recorremos y obtenemos los matches de la expresión regular en la cadena
            foreach(Match match in Regex.Matches(matricula, regex)) 
            {
                //Almacenamos la coincidencia
                provincia_v = match.Groups[0].Value;
            }

            //Mismo proceso que arriba
            foreach (Match match in Regex.Matches(paquete.ProvinciaDest.ToUpper(), regex))
            {
                provincia_p = match.Groups[0].Value;
            }

            //Console.WriteLine(provincia_p);
            //Console.WriteLine(provincia_v);

            

            //Si ambos coinciden, devuelve true
            if (provincia_v.Equals(provincia_p)) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
