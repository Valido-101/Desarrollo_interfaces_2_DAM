using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_30_10_2020
{
    public class Libro
    {
        string iban;
        string titulo;
        string autor;

        public Libro(string iban, string titulo, string autor) 
        {
            this.iban = iban;
            this.titulo = titulo;
            this.autor = autor;
        }

        public string Iban { get => iban; set => iban = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }

        public string toString() 
        {
            return "IBAN: " + iban + ", Autor: " + autor + ", Título: " + titulo;
        }
    }
}
