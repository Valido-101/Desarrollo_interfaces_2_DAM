using Microsoft.Reporting.WinForms;
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
    public partial class FormularioInforme : Form
    {
        ArrayList patines;
        ArrayList clientes;
        ArrayList patines_alquilados;

        public FormularioInforme(ArrayList patines, ArrayList clientes)
        {
            InitializeComponent();

            this.patines = patines;
            this.clientes = clientes;
            patines_alquilados = new ArrayList();
        }

        private void FormularioInforme_Load(object sender, EventArgs e)
        {
            float media = 0;

            foreach (Monopatin m in patines)
            {
                media += m.VecesAlquilado;
            }

            media = (float)media / patines.Count;

            foreach (Monopatin m in patines)
            {
                foreach(Cliente c in clientes) 
                {
                    if (c.ListaMonopatines.Contains(m))
                    {
                        if (!patines_alquilados.Contains(m))
                        {
                            patines_alquilados.Add(m);
                            break;
                        }
                    }
                }
            }

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", patines));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PatinesAlquilados", patines_alquilados));

            ReportParameter[] parameters = new ReportParameter[1];

            parameters[0] = new ReportParameter("mediaAlquileres", ""+media);

            reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
        }
    }
}
