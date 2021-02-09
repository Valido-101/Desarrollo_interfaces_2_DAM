using System;
using System.Collections.Generic;
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
    public partial class FormPrincipal : Form
    {

        //Variable de control que indica dónde se guarda el texto de TextBox
        private bool conmutarPulsado = false;

        public FormPrincipal()
        {
            InitializeComponent();
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

        public ListBox getListBox() 
        {
            return lstbox1;
        }

        public ComboBox getComboBox() 
        {
            return combobox1;
        }

        private void btnNuevoForm_Click(object sender, EventArgs e)
        {
            ArrayList listaLstBox = new ArrayList();
            ArrayList listaComboBox = new ArrayList();

            foreach (string item in combobox1.Items)
            {
                listaComboBox.Add(item);
            }

            foreach (string item in lstbox1.Items)
            {
                listaLstBox.Add(item);
            }

            //FormPrincipal newForm = new FormPrincipal(this, listaLstBox, listaComboBox);

            //newForm.Show();

            Form2 newForm = new Form2(this, listaComboBox, listaLstBox);
            newForm.Show();
        }
    }
}
