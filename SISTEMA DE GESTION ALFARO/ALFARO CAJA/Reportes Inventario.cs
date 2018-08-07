using CrystalDecisions.CrystalReports.Engine;
using LIBRERIA;

using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Reportes_Inventario : Form
    {
        public Reportes_Inventario()
        {
            InitializeComponent();
        }
        CLSINV INV = new CLSINV();
        CLSREPORTES REP = new CLSREPORTES();
        private void Reportes_Inventario_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
          
        }

        void traerdatos()
        {
            IMPRESION_REPORTES ven = new IMPRESION_REPORTES();
            ven.Text = "REPORTE DE SOBRANTES DE INVENTARIOS DE LA SUCURSAL";
            ven.reportViewer1.LocalReport.ReportEmbeddedResource = @"ALFARO_CAJA.REPORTES.REPORTE_DE_SOBRANTES.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("USU", STCODIGO.Text);
            ven.reportViewer1.LocalReport.SetParameters(parametros);
            ven.reportViewer1.RefreshReport();
            ReportDataSource rds = new ReportDataSource("RP_SOBRAS", REP.REPORTE_SOBRANTES_INVENTARIOS());
            ven.reportViewer1.LocalReport.DataSources.Clear();
            ven.reportViewer1.LocalReport.DataSources.Add(rds);
            ven.reportViewer1.RefreshReport();
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            ven.ShowDialog();
        }
      
        
        void  GENERA_RPT_SISTEMAS()
        {

            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            rpt.Load("C:/SI_Gestion/REPORTES/Rpt_Inventario.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            DataTable dt_c2 = new DataTable();
            dt_c = INV.Devolver_datos_inv_x_cod(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CODIGO"].Value));
            dt_c2 = INV.Devolver_detalles_inv_x_cod(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CODIGO"].Value));
            ds.Tables.Add(dt_c2);
            ds.Tables.Add(dt_c);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.Database.Tables[1].SetDataSource(ds.Tables[1]);
            rpt.SetParameterValue("usu", STCODIGO.Text);
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "REPORTE GENERAL DE INVENTARIO";
            frm.Show();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            progressBar1.Visible = true;
            timer1.Start();
            GENERA_RPT_SISTEMAS();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = INV.VER_INVENTARIOS_SEGUN_FECHA(metroDateTime1.Value, metroDateTime2.Value);
            dataGridView1.Columns["tipo"].Visible = false;
        }
    }
}
