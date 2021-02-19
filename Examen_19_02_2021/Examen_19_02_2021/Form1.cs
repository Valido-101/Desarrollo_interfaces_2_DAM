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
    public partial class Form1 : Form
    {
        ArrayList patines;
        ArrayList clientes;

        public Form1()
        {
            InitializeComponent();

            patines = new ArrayList();
            clientes = new ArrayList();

            for (int x = 1; x <= 10; x++)
            {
                patines.Add(new Monopatin(x, "Marca" + x, x, x, x));
            }

            for (int x = 1; x <= 10; x++)
            {
                clientes.Add(new Cliente("Nombre" + x, "Apellidos" + x, "Dni" + x, (float)x * 10, x));
            }

            Cliente c1=(Cliente)clientes[1];
            Cliente c2 = (Cliente)clientes[2];

            c1.ListaMonopatines.Add((Monopatin)patines[4]);
            c2.ListaMonopatines.Add((Monopatin)patines[8]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstboxClientes.Items.Clear();
            lstboxPatines.Items.Clear();

            foreach (Cliente c in clientes)
            {
                lstboxClientes.Items.Add(c);
            }

            foreach (Monopatin m in patines)
            {
                bool alquilado = false;

                foreach (Cliente c in clientes)
                {
                    if (c.ListaMonopatines.Contains(m)) 
                    {
                        alquilado = true;
                        break;
                    }
                }

                if (!alquilado) 
                {
                    lstboxPatines.Items.Add(m);
                }

            }
        }

        private void btnSiguienteForm_Click(object sender, EventArgs e)
        {
            FormSecundario form2 = new FormSecundario(clientes, patines);
            form2.FormClosing += Form2_FormClosing;
            this.Hide();
            form2.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            Form1_Load(new Object(), new EventArgs());
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            FormularioInforme informe = new FormularioInforme(patines, clientes);
            informe.FormClosing += Form2_FormClosing;
            this.Hide();
            informe.Show();
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstboxClientes.SelectedItem == null || lstboxPatines.SelectedItem==null) 
                {
                    throw new Exception("Debe seleccionar un cliente y un monopatín");
                }

                Cliente c = (Cliente)lstboxClientes.SelectedItem;
                Monopatin m = (Monopatin)lstboxPatines.SelectedItem;

                if (c.Saldo < m.Valor)
                {
                    throw new Exception("Saldo insuficiente");
                }

                c.ListaMonopatines.Add(m);
                m.VecesAlquilado = m.VecesAlquilado + 1;
                c.Saldo = c.Saldo - m.Valor;

                MessageBox.Show("Monopatín alquilado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1_Load(new Object(), new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
