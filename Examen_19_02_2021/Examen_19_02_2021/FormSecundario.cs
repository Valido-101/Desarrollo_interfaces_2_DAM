using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_19_02_2021
{
    public partial class FormSecundario : Form
    {
        ArrayList clientes;
        ArrayList patines;

        public FormSecundario(ArrayList clientes, ArrayList patines)
        {
            InitializeComponent();

            this.clientes = clientes;
            this.patines = patines;
        }

        private void FormSecundario_Load(object sender, EventArgs e)
        {
            comboboxClientes.Items.Clear();
            comboboxClientes.Text = "";
            lstboxPatines.Items.Clear();

            foreach (Cliente c in clientes)
            {
                if (c.ListaMonopatines.Count > 0) 
                {
                    comboboxClientes.Items.Add(c);
                }
            }
        }

        private void comboboxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstboxPatines.Items.Clear();

            ComboBox cb = (ComboBox)sender;

            Cliente c = (Cliente)cb.SelectedItem;

            foreach (Monopatin m in c.ListaMonopatines)
            {
                lstboxPatines.Items.Add(m);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try 
            {
                if (comboboxClientes.SelectedItem == null || lstboxPatines.SelectedItem==null) 
                {
                    throw new Exception("Necesita seleccionar un cliente y un monopatín");
                }

                Cliente c = (Cliente)comboboxClientes.SelectedItem;
                Monopatin m = (Monopatin)lstboxPatines.SelectedItem;

                c.ListaMonopatines.Remove(m);
                patines.Add(m);

                MessageBox.Show("Monopatín devuelto con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormSecundario_Load(new object(), new EventArgs());
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
