using Microsoft.Reporting.WinForms;
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

namespace Practica_6
{
    public partial class Formulario_Informe : Form
    {
        Sala sala_seleccionada;

        public Formulario_Informe(Sala sala_seleccionada)
        {
            InitializeComponent();
            this.sala_seleccionada = sala_seleccionada;
        }

        private void Formulario_Informe_Load(object sender, EventArgs e)
        {
            List<Asiento> asientos = new List<Asiento>();

            foreach (Asiento a in sala_seleccionada.Asientos)
            {
                asientos.Add(a);
            }

            ReportParameter[] parameters = new ReportParameter[2];

            parameters[0] = new ReportParameter("param_nombre_evento", sala_seleccionada.Nombre_evento);

            parameters[1] = new ReportParameter("total_entrada", Convert.ToString(asientos.Count*7));

            reportViewer1.LocalReport.SetParameters(parameters);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DatosAsiento", asientos));

            this.reportViewer1.RefreshReport();
        }
    }
}
