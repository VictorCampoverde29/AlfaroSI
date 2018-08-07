using System;
using System.Data;
using System.Windows.Forms;
using LIBRERIA;


using System.Threading;
using CrystalDecisions.CrystalReports.Engine;

namespace ALFARO_CAJA
{
    public partial class SELECCION_TORTA : Form
    {
        public SELECCION_TORTA()
        {
            InitializeComponent();
        }
        Clscaja CJ = new Clscaja();
        CLSREPORTES REP = new CLSREPORTES();
        private void SELECCION_TORTA_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            STPC.Text = Environment.MachineName;
            comboBox1.SelectedIndex = 0;
            LLENARDGV();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }
        void LLENARDGV()
        {
            DGVDATA.DataSource = CJ.BUSCAR_CAJAS_MES(Convert.ToInt32(comboBox1.SelectedIndex + 1),Convert.ToInt32(numericUpDown1.Value));
            DGVDATA.Columns["CODIGO"].Visible = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LLENARDGV();
        }

        void hacer()
        {
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\GraficoEstadistico.rpt");
            //rpt.Load("C:/SI_Gestion/REPORTES/Valorado_Perdidas.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            dt_c = REP.TORTA((int)DGVDATA.CurrentRow.Cells["CODIGO"].Value);
            ds.Tables.Add(dt_c);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.SetParameterValue("MAÑO", comboBox1.Text + " " + numericUpDown1.Value.ToString());
            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "REPORTE DE VALORADO DE PERDIDAS";
            frm.MdiParent = this.ParentForm;
            frm.Show();




          
        }
        private void DGVDATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            progressBar1.Visible = true;
            timer1.Start();
            hacer();
  
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            LLENARDGV();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }
    }
}
