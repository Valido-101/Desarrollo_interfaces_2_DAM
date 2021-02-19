using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_19_02_2021
{
    public class Cliente : ICliente
    {
        private string nombre;
        private string apellidos;
        private string dni;
        private float peso;
        private int saldo;
        private ArrayList listaMonopatines;

        public Cliente(string nombre, string apellidos, string dni, float peso, int saldo)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.peso = peso;
            this.saldo = saldo;
            this.listaMonopatines = new ArrayList();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public float Peso { get => peso; set => peso = value; }
        public int Saldo { get => saldo; set => saldo = value; }
        public ArrayList ListaMonopatines { get => listaMonopatines; set => listaMonopatines = value; }

        public bool CompruebaAlquiler(Monopatin m) 
        {
            try 
            {
                if (peso > m.PesoMaximo) 
                {
                    throw new Exception();
                }

                if (saldo < m.Valor) 
                {
                    throw new Exception();
                }

                if (!m.compruebaEstado()) 
                {
                    throw new Exception();
                }

                return true;
            }
            catch(Exception e) 
            {
                return false;
            }
        }

        //Versión del método con parámetro IMonopatin para las pruebas unitarias
        public bool CompruebaAlquiler(IMonopatin m)
        {
            try
            {
                if (peso > m.PesoMaximo)
                {
                    throw new Exception();
                }

                if (saldo < m.Valor)
                {
                    throw new Exception();
                }

                if (!m.compruebaEstado())
                {
                    throw new Exception();
                }

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        override
        public string ToString() 
        {
            return dni + "-" + nombre + "-" + peso + "-" + saldo;
        }
    }
}
