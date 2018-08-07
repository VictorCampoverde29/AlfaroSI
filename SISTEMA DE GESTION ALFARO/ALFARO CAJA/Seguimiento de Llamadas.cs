using CrystalDecisions.CrystalReports.Engine;
using LIBRERIA;
using System;
using System.Data;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Seguimiento_de_Llamadas : Form
    {
        public Seguimiento_de_Llamadas()
        {
            InitializeComponent();
        }
        USUARIOS U = new USUARIOS();
        CLSREPORTES RP = new CLSREPORTES();
        private void Seguimiento_de_Llamadas_Load(object sender, EventArgs e)
        {
            LLENARCOMBO();
            STPC.Text = Environment.MachineName;
        }
        void LLENARCOMBO()
        {
            comboBox1.DataSource = U.llenar_USU_MOD_TK();
            comboBox1.DisplayMember = "NOMBRE_COMPLETO";
            comboBox1.ValueMember = "IDUSUARIO";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Start();
            progressBar1.Visible = true;


            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Seguimiento_diario.rpt");
            rpt.Load("C:/SI_Gestion/REPORTES/Seguimiento_diario.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            DataTable dt_c2 = new DataTable();
            dt_c =  RP.REPORTE_LLAMADAS_X_FECHA(DTPFECHADIA.Value);
            dt_c2 = RP.REPORTE_VENTAS_LLAMADAS_X_FECHA(DTPFECHADIA.Value);
            ds.Tables.Add(dt_c);
            ds.Tables.Add(dt_c2);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.Database.Tables[1].SetDataSource(ds.Tables[1]);
            rpt.SetParameterValue("FECHA", DTPFECHADIA.Value);
            rpt.SetParameterValue("USU", STCODIGO.Text);
            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "SEGUIMIENTO DE LLAMADAS SEGUN RANGO DE FECHAS";
            frm.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Start();
            progressBar1.Visible = true;
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Rango_llamadas.rpt");
            rpt.Load("C:/SI_Gestion/REPORTES/Rango_llamadas.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            dt_c = RP.REPORTE_LL_RANGO(RANGO1.Value, RANGO2.Value);
            ds.Tables.Add(dt_c);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.SetParameterValue("DEL",RANGO1.Value);
            rpt.SetParameterValue("AL", RANGO2.Value);

            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "SEGUIMIENTO DE LLAMADAS SEGUN RANGO DE FECHAS";
            frm.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Start();
            progressBar1.Visible = true;
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Reporte_de_Llamadas.rpt");
            rpt.Load("C:/SI_Gestion/REPORTES/Reporte_de_Llamadas.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            dt_c = RP.REPORTE_CONSULTA_LLAMADAS_X_FECHA_TK(comboBox1.SelectedValue.ToString(), dateTimePicker1.Value);
            ds.Tables.Add(dt_c);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.SetParameterValue("USU", STCODIGO.Text);
            rpt.SetParameterValue("NTLK", comboBox1.Text);
            rpt.SetParameterValue("CODIGO", comboBox1.SelectedValue.ToString());
            rpt.SetParameterValue("FECHA", dateTimePicker1.Value.ToShortDateString());

            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "SEGUIMIENTO DE LLAMADAS SEGUN TELEMARKETING";
            frm.Show();


      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
