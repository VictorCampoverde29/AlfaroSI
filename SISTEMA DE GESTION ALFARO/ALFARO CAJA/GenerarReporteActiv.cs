using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Windows.Forms;
using LIBRERIA;
namespace ALFARO_CAJA
{
    public partial class GenerarReporteActiv : Form
    {
        public GenerarReporteActiv()
        {
            InitializeComponent();
        }
        CLSACTIVIDAD acti = new CLSACTIVIDAD();
        private void button2_Click(object sender, EventArgs e)
        {
            ProgressBar1.Visible = true;
            GENERA_REPORTE();
            
        }
        void GENERA_REPORTE()
        {
            timer1.Start();
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Reporte_Actividades.rpt");
            rpt.Load("C:/SI_Gestion/REPORTES/Reporte_Actividades.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            dt_c = acti.Ver_terminadas(DTPDEL.Value, DTPAL.Value);
            ds.Tables.Add(dt_c);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.SetParameterValue("del", DTPDEL.Value);
            rpt.SetParameterValue("al", DTPAL.Value);
            rpt.SetParameterValue("usu", STCODIGO.Text);
            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            timer1.Stop();
            ProgressBar1.Visible = false;
            ProgressBar1.Value = 0;
            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "REPORTE DE ACTIVIDADES POR FECHAS";
            frm.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ProgressBar1.Increment(1);
        }

        private void GenerarReporteActiv_Load(object sender, EventArgs e)
        {

        }
    }
}
