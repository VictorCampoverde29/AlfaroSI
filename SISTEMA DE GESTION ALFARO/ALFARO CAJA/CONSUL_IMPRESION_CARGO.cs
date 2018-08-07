using System;
using System.Data;
using System.Windows.Forms;
using LIBRERIA;
using CrystalDecisions.CrystalReports.Engine;

namespace ALFARO_CAJA
{
    public partial class CONSUL_IMPRESION_CARGO : Form
    {
        public CONSUL_IMPRESION_CARGO()
        {
            InitializeComponent();
        }
        Clsarmador A = new Clsarmador();
        CLSPERDIDA P = new CLSPERDIDA();
        CLSREPORTES REP = new CLSREPORTES();
        private void CONSUL_IMPRESION_CARGO_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            CMBMES.SelectedIndex = 0;
            LISTAR_ARMADORES();
        }
        void LISTAR_ARMADORES()
        {
            CMBARMADOR.DataSource = A.llenar_ARMADOR();
            CMBARMADOR.DisplayMember = "NOMBRE";
            CMBARMADOR.ValueMember = "IDARMADOR";
        }
    
        void PERDIDAS()
        {
            dataGridView1.DataSource = P.DEVOLVER_ARMADOR_PER_MES(CMBARMADOR.Text,(Convert.ToInt32(CMBMES.SelectedIndex)+1));
            dataGridView1.Columns["COD"].Visible = false;

        }
        
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PERDIDAS();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name=="REPORTE")
            {
                try
                {
                    VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                    ReportDocument rpt = new ReportDocument();
                    rpt.Load("C:/SI_Gestion/REPORTES/Cargo_Perdida.rpt");
                    DataSet ds = new DataSet();
                    DataTable dt_c = new DataTable(); //ResultSet de DB  
                    DataTable dt_c2 = new DataTable();
                    dt_c = REP.REPORTE_CARGO_X_CODPERDIDA(Convert.ToInt32(dataGridView1.CurrentRow.Cells["COD"].Value));
                    dt_c2=REP.REPORTE_DETALLE_CARGO_X_CODPERDIDA(Convert.ToInt32(dataGridView1.CurrentRow.Cells["COD"].Value));
                    ds.Tables.Add(dt_c);
                    ds.Tables.Add(dt_c2);
                    rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                    rpt.Database.Tables[1].SetDataSource(ds.Tables[1]);
                    ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                    frm.Refresh();  //se refresca 
                                    //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                                    //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                    frm.Text = "CARGO DE PERDIDA";
                    frm.MdiParent = this.ParentForm;
                    frm.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "NO SE SELECCIONO NINGUN CODIGO",VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                dataGridView2.DataSource = P.Devolver_detalles_PERDIDA(Convert.ToInt32(dataGridView1.CurrentRow.Cells["COD"].Value.ToString()));
                panel1.Visible = true;
            }
        }
    }
}
