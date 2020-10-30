using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_30_10_2020
{
    public partial class form_inicio : Form
    {

        ArrayList socios = new ArrayList();
        ArrayList libros = new ArrayList();

        public form_inicio()
        {
            InitializeComponent();
            libros.Add(new Libro("1", "Martín Matín", "Es un Agente o Drácula"));
            libros.Add(new Libro("2", "Las Increíbles Aventuras de Lisandro", "Benito Camela"));
            libros.Add(new Libro("3", "Por qué España sigue molando", "Santiago Abascal"));
            libros.Add(new Libro("4", "Cómo armar un misil en 657 sencillos pasos", "Kim Jong Un"));
            libros.Add(new Libro("5", "La Vida de Un Borderline", "Amador Rivas"));
            socios.Add(new Socio("Juan","Valido Vázquez",1,new ArrayList()));
            socios.Add(new Socio("Fernando", "García Sánchez", 2, new ArrayList()));
            socios.Add(new Socio("Francisco Javier", "Gómez Bru", 3, new ArrayList()));
            socios.Add(new Socio("Pilar", "Zambrana Pérez", 4, new ArrayList()));
            socios.Add(new Socio("María", "Martín Navarro", 5, new ArrayList()));
        }
    }
}
