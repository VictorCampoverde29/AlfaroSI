using System;
using System.Data;
using System.Windows.Forms;
using LIBRERIA;
using CrystalDecisions.CrystalReports.Engine;

namespace ALFARO_CAJA
{
    public partial class REPORTE_DE_MEMORANDUM_POR_FECHA : Form
    {
        public REPORTE_DE_MEMORANDUM_POR_FECHA()
        {
            InitializeComponent();
        }
        Clsarmador ARMA = new Clsarmador();
        CLSMEMORANDUM MEMO = new CLSMEMORANDUM();
        CLSREPORTES REP = new CLSREPORTES();
        void LISTAR_ARMADORES()
        {
            CMBARMADOR.DataSource = ARMA.llenar_ARMADOR();
            CMBARMADOR.DisplayMember = "NOMBRE";
            CMBARMADOR.ValueMember = "IDARMADOR";
        }
        private void REPORTE_DE_MEMORANDUM_POR_FECHA_Load(object sender, EventArgs e)
        {
            LISTAR_ARMADORES();
            STPC.Text = Environment.MachineName;
        }

      

        private void DGVDATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            progressBar1.Visible = true;
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            rpt.Load("C:/SI_Gestion/REPORTES/Memorandum.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB 
            dt_c = REP.VER_MEMO(Convert.ToInt32(DGVDATA.CurrentRow.Cells["CODIGO"].Value));
            ds.Tables.Add(dt_c);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "MEMORANDUM TRABAJADOR";
            frm.Show();
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            rpt.Load("C:/SI_Gestion/REPORTES/Historial_Memorandum.rpt");
            //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Historial_Memorandum.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB 
            dt_c = MEMO.RPT_VER_MEMOS_FECHAS(DTPDELGRL.Value, DTPALGRL.Value);
            ds.Tables.Add(dt_c);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.SetParameterValue("USU", STCODIGO.Text);
            rpt.SetParameterValue("FDEL", DTPDELGRL.Value);
            rpt.SetParameterValue("FAL", DTPALGRL.Value);
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "HISTORIAL DE MEMORANDUM POR FECHA";
            frm.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DGVDATA.DataSource = MEMO.VER_MEMOS_FECHAS_USUARIO(DTPDELGRL.Value, DTPALGRL.Value, Convert.ToInt32(CMBARMADOR.SelectedValue));

        }
    }
}
