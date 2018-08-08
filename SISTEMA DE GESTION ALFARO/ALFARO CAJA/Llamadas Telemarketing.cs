using CrystalDecisions.CrystalReports.Engine;
using LIBRERIA;
using System;
using System.Data;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Llamadas_Telemarketing : Form
    {
        public Llamadas_Telemarketing()
        {
            InitializeComponent();
        }
        CLSLLAMADAS LL = new CLSLLAMADAS();
        CLSREPORTES REP = new CLSREPORTES();
        private void Llamadas_Telemarketing_Load(object sender, EventArgs e)
        {
            
            STPC.Text = Environment.MachineName;
            LLENAR_LLAMADAS();
            TXTCLIENTE.Focus();
        }
        void REGISTRAR_LLAMADAS(String CLI, String OBS, String VTA, String USU)
        {
            String MSJE = LL.REGISTRAR_LLAMADA(Convert.ToDateTime(DateTime.Now.ToShortDateString()), CLI, OBS, VTA, USU);
            MessageBox.Show(this,MSJE,VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
            TXTCLIENTE.Clear();
            TXTNOTA.Clear();
        }
        void LLENAR_LLAMADAS()
        {
            dataGridView1.DataSource = LL.Devolver_LLAMADAST(STCODIGO.Text);
            LBLTOTLLAMADAS.Text = dataGridView1.RowCount + "";
            dataGridView1.Columns["IDLLAMADAS"].Visible = false;
        }
        private void metroLink1_Click(object sender, EventArgs e)
        {
           
        }

        private void TXTCLIENTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTNOTA.Focus();
            }
        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
          
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
          
          
        }

        private void Llamadas_Telemarketing_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CONSULTA_DIRcs VEN = new CONSULTA_DIRcs();
            VEN.MdiParent = this.ParentForm;
            VEN.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
            VEN.STPERFIL.Text = STPERFIL.Text;
            VEN.STCODIGO.Text = STCODIGO.Text;
            VEN.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            // rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Reporte_de_Llamadas.rpt");
            rpt.Load("C:/SI_Gestion/REPORTES/Reporte_de_Llamadas.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            dt_c = REP.REPORTE_CONSULTA_LLAMADAS_X_FECHA_TK(STCODIGO.Text, Convert.ToDateTime(DateTime.Now));
            ds.Tables.Add(dt_c);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.SetParameterValue("USU", STCODIGO.Text);
            rpt.SetParameterValue("NTLK", STNOMBRECOMPLETO.Text);
            rpt.SetParameterValue("CODIGO", STCODIGO.Text);
            rpt.SetParameterValue("FECHA", DateTime.Now.ToShortDateString());

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

        private void TXTNOTA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (TXTCLIENTE.Text == "") { MessageBox.Show(this, "NECESITA INDICAR UN CLIENTE", "Gestion Areas " + Application.ProductVersion); }
                else if (TXTNOTA.Text == "") { MessageBox.Show(this, "NECESITA INDICAR ALGO EN CAMPO OBSERVACION", "Gestion Areas " + Application.ProductVersion); }
                else
                {
                    DialogResult result = MessageBox.Show(this, "CLIENTE:" + TXTCLIENTE.Text + Environment.NewLine + "NOTA:" + TXTNOTA.Text + Environment.NewLine + "¿LA LLAMADA TERMINO EN VENTA?", "GESADIV", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        REGISTRAR_LLAMADAS(TXTCLIENTE.Text, TXTNOTA.Text, "SV", STCODIGO.Text);
                        LLENAR_LLAMADAS();
                    }
                    else
                    {
                        REGISTRAR_LLAMADAS(TXTCLIENTE.Text, TXTNOTA.Text, "NV", STCODIGO.Text);
                        LLENAR_LLAMADAS();
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridView1.RowCount == 0) { MessageBox.Show(this, "NO HAY REGISTROS PARA ELIMINAR", "GESADIV", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                try
                {
                    String MSJE = LL.QUITAR_LLAMADAS(Convert.ToInt32(dataGridView1.CurrentRow.Cells["IDLLAMADAS"].Value));
                    MessageBox.Show(this, MSJE, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LLENAR_LLAMADAS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "SELECCIONE REGISTRO PARA ELIMINAR", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
