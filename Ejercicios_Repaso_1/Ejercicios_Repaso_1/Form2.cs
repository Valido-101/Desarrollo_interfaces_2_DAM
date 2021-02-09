using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Repaso_1
{
    public partial class Form2 : Form
    {
        private bool conmutarPulsado = false;
        private FormPrincipal formAnterior;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(FormPrincipal formAnterior,ArrayList datoscb,ArrayList datoslb) 
        {
            InitializeComponent();

            this.formAnterior = formAnterior;

            foreach (var item in datoscb)
            {
                lstbox1.Items.Add(item);
            }

            foreach (var item in datoslb)
            {
                combobox1.Items.Add(item);
            }
        }

        //Evento que se activa al pulsar el botón agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (conmutarPulsado)
            {
                case false:

                    lstbox1.Items.Add(txtboxInput.Text);

                    break;
                case true:

                    combobox1.Items.Add(txtboxInput.Text);

                    break;
            }

            txtboxInput.Clear();
        }

        //Evento que se activa al pulsar el botón Conmutar
        private void btnConmutar_Click(object sender, EventArgs e)
        {
            if (conmutarPulsado)
            {
                conmutarPulsado = false;
            }
            else
            {
                conmutarPulsado = true;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in combobox1.Items)
            {
                if (!formAnterior.getListBox().Items.Contains(item)) 
                {
                    formAnterior.getListBox().Items.Add(item);
                }
            }

            foreach (var item in lstbox1.Items)
            {
                if (!formAnterior.getComboBox().Items.Contains(item))
                {
                    formAnterior.getComboBox().Items.Add(item);
                }
            }
        }
    }
}
