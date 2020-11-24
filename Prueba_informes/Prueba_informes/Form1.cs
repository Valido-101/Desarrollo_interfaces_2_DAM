using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Prueba_informes
{
    public partial class Form1 : Form
    {
        public List<Class1> Invoice = new List<Class1>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();

            ReportParameter[] parameters = new ReportParameter[1];

            parameters[0] = new ReportParameter("Str1Class1","Valores Class1");

            reportViewer1.LocalReport.SetParameters(parameters);

            Invoice.Add(new Class1("Párametro str Clase 1",1));
            Invoice.Add(new Class1("Párametro str Clase 1", 2));
            Invoice.Add(new Class1("ñeh",3));

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DatosClass1",Invoice));

            this.reportViewer1.RefreshReport();
        }
    }
}
