
using System;
using System.Data;
using System.Windows.Forms;
using LIBRERIA;
using CrystalDecisions.CrystalReports.Engine;

namespace ALFARO_CAJA
{
    public partial class GENERA_RPT_CAJA_CHICA : Form
    {
        public GENERA_RPT_CAJA_CHICA()
        {
            InitializeComponent();
        }
        Clscaja CJ = new Clscaja();
        CLSREPORTES REP = new CLSREPORTES();
        private void GENERA_RPT_CAJA_CHICA_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            comboBox1.SelectedIndex = 0;
        }
        void LLENARDGV()
        {
            DGVDATA.DataSource = CJ.BUSCAR_CAJAS_MES(Convert.ToInt32(comboBox1.SelectedIndex + 1), Convert.ToInt32(numericUpDown1.Value));
            DGVDATA.Columns["CODIGO"].Visible = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LLENARDGV();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            LLENARDGV();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
          

        }

        private void DGVDATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            timer1.Start();
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            rpt.Load("C:/SI_Gestion/REPORTES/Caja_Chica.rpt");
            //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Caja_Chica.rpt");

            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            dt_c = REP.LISTAR_DETALLES_CAJAS_USUARIOS(Convert.ToInt32(DGVDATA.CurrentRow.Cells["CODIGO"].Value));
            ds.Tables.Add(dt_c);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.SetParameterValue("usu", STCODIGO.Text);
            rpt.SetParameterValue("numero", DGVDATA.CurrentRow.Cells["CODIGO"].Value.ToString());
            rpt.SetParameterValue("ap", DGVDATA.CurrentRow.Cells["FECHA APERTURA"].Value.ToString());
            rpt.SetParameterValue("descrip", DGVDATA.CurrentRow.Cells["DESCRIPCION"].Value.ToString());
            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "REPORTE DE CAJA CHICA";
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(10);
        }
    }
}
