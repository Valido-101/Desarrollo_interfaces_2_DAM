using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_examen_diciembre
{
    public class Almacen
    {
        private string nombre;
        private string ubicacion;
        private ArrayList articulos;

        public Almacen(string nombre, string ubicacion)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            articulos = new ArrayList();
        }

        public double getValor() 
        {
            double valor_almacen=0;

            foreach(Articulo a in articulos) 
            {
                valor_almacen += a.Precio*a.Unidades;
            }

            return valor_almacen;
        }

        public bool comprar(int cod_articulo, int unidades) 
        {
            foreach (Articulo a in articulos)
            {
                if (a.Codigo == cod_articulo) 
                {
                    if (unidades >= a.Unidades) 
                    {
                        a.Unidades -= unidades;
                        return true;
                    }
                    else 
                    {
                        a.Unidades = 0;
                        return true;
                    }
                }
            }

            return false;
        }

        public bool reponer(int cod_articulo, int unidades)
        {
            foreach (Articulo a in articulos)
            {
                if (a.Codigo == cod_articulo)
                {
                    a.Unidades += unidades;
                    return true;
                }
            }

            return false;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public ArrayList Articulos { get => articulos; set => articulos = value; }

        override
        public string ToString()
        {
            return nombre + ": " + ubicacion;
        }
    }
}
