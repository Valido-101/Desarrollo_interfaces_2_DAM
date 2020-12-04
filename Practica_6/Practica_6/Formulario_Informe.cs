using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_6
{
    public partial class Formulario_Informe : Form
    {
        Sala sala_seleccionada;
        ArrayList carrito;
        string texto_codificado = "";

        public Formulario_Informe(Sala sala_seleccionada, ArrayList carrito)
        {
            InitializeComponent();
            this.sala_seleccionada = sala_seleccionada;
            this.carrito = carrito;
        }

        private void Formulario_Informe_Load(object sender, EventArgs e)
        {
            List<Asiento> asientos = new List<Asiento>();

            foreach (Asiento a in carrito)
            {
                asientos.Add(a);
                texto_codificado += "Asiento_" + a.Fila + "_" + a.Columna + ";";
            }

            if (asientos.Count == 0)
            {
                MessageBox.Show("El carrito está vacío", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                texto_codificado = "Sin asientos";
            }

            var qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            var qrCode = qrEncoder.Encode(texto_codificado);
            var renderer = new GraphicsRenderer(new FixedModuleSize(5, QuietZoneModules.Two), Brushes.Black, Brushes.White);
            using (var stream = new FileStream(Application.StartupPath + @"\qrcode.png", FileMode.Create)) renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, stream);

            reportViewer1.LocalReport.EnableExternalImages = true;

            string ruta = Application.StartupPath + @"\qrcode.png";

            ReportParameter[] parameters = new ReportParameter[6];

            parameters[0] = new ReportParameter("param_nombre_evento", sala_seleccionada.Nombre_evento);

            parameters[1] = new ReportParameter("total_entrada", Convert.ToString(asientos.Count * 7));

            parameters[2] = new ReportParameter("rutaImagen", @"file:\" + ruta, true);

            parameters[3] = new ReportParameter("rutaImagen2", @"file:\"+sala_seleccionada.Ruta_imagen,true);

            parameters[4] = new ReportParameter("fecha", sala_seleccionada.Fecha);

            parameters[5] = new ReportParameter("hora", sala_seleccionada.Hora);

            reportViewer1.LocalReport.SetParameters(parameters);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DatosAsiento", asientos));

            this.reportViewer1.RefreshReport();
        }
    }
}
