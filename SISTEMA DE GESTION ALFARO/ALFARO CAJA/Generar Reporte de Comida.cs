using CrystalDecisions.CrystalReports.Engine;
using LIBRERIA;
using System;
using System.Data;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Generar_Reporte_de_Comida : Form
    {
        public Generar_Reporte_de_Comida()
        {
            InitializeComponent();
        }
        CLSREPORTES RP = new CLSREPORTES();
        private void Generar_Reporte_de_Comida_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            STPC.Text = Environment.MachineName;
        }
        void GENERA_REPORTE()
        {
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            rpt.Load("C:/SI_Gestion/REPORTES/Reporte_de_Menu.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            dt_c = RP.REPORTE_COMIDA_RANGO(DTPDEL.Value, DTPAL.Value);
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
            frm.Text = "REPORTE DE COMIDA POR FECHAS";
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ProgressBar1.Increment(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ProgressBar1.Visible = true;
            GENERA_REPORTE();
        }
    }
}
