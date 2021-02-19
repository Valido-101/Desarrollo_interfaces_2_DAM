using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_19_02_2021
{
    public class Monopatin : IMonopatin
    {
        private int codigo;
        private string marca;
        private float pesoMaximo;
        private int valor;
        private int vecesAlquilado;

        public Monopatin(int codigo, string marca, int pesoMaximo, int valor, int vecesAlquilado)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.pesoMaximo = pesoMaximo;
            this.valor = valor;
            this.vecesAlquilado = vecesAlquilado;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public float PesoMaximo { get => pesoMaximo; set => pesoMaximo = value; }
        public int Valor { get => valor; set => valor = value; }
        public int VecesAlquilado { get => vecesAlquilado; set => vecesAlquilado = value; }

        public bool compruebaEstado()
        {
            if (vecesAlquilado >= 20)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        override
        public string ToString()
        {
            return codigo + "-" + pesoMaximo + "-" + marca + "-" + valor;
        }
    }
}
