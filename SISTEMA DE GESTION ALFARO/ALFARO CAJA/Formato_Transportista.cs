using System;
using System.Data;
using System.Windows.Forms;
using LIBRERIA;
using CrystalDecisions.CrystalReports.Engine;
using System.Drawing.Printing;

namespace ALFARO_CAJA
{
    public partial class Formato_Transportista : Form
    {
        public Formato_Transportista()
        {
            InitializeComponent();
        }
        CLSDESCARGAS desc = new CLSDESCARGAS();
        CLSREPORTES RP = new CLSREPORTES();
        private void Formato_Transportista_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
        }
        void BUSCA()
        {

            dataGridView1.DataSource = desc.llenar_descargas_x_estado(1, dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.Columns["CODIGO"].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult DRS = new DialogResult();
            Detalle_formato_t dt = new Detalle_formato_t();
            dt.lblcodigo.Text= dataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString();
            dt.txtprov.Text = dataGridView1.CurrentRow.Cells["PROVEEDOR"].Value.ToString();
            dt.txtfecha.Text= dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString().Substring(0,10);
            dt.txthoraini.Text= dataGridView1.CurrentRow.Cells["HORA"].Value.ToString();
            dt.numbultos.Text =dataGridView1.CurrentRow.Cells["CANTIDAD_BULTOS"].Value.ToString();
            dt.txtconductor.Text = dataGridView1.CurrentRow.Cells["CONDUCTOR"].Value.ToString();
            dt.txtlicencia.Text = dataGridView1.CurrentRow.Cells["LICENCIA"].Value.ToString();
            dt.txttransporte.Text = dataGridView1.CurrentRow.Cells["EMPRESA_CARGA"].Value.ToString();
            dt.STCODIGO.Text = STCODIGO.Text;
            DRS =dt.ShowDialog();
            if (DRS==DialogResult.OK)
            {
                BUSCA();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BUSCA();
        }

        void imprime(DateTime F)
        {
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Reporte_Individual_T.rpt");
            rpt.Load("C:/SI_Gestion/REPORTES/Reporte_Individual_T.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            dt_c = RP.REP_FORMATO_TRANSPORTISTA(F);
            ds.Tables.Add(dt_c);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.SetParameterValue("FECHA", F);
            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;


            string NombreImpresora = "";//Donde guardare el nombre de la impresora por defecto

            //Busco la impresora por defecto
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                PrinterSettings a = new PrinterSettings();
                a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
                if (a.IsDefaultPrinter)
                {
                    NombreImpresora = PrinterSettings.InstalledPrinters[i].ToString();

                }

            }
            rpt.PrintOptions.PrinterName = NombreImpresora;
        
            rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            //frm.MdiParent = this.ParentForm;
            //frm.Text = "FORMATO DE TRANSPORTISTA";
            //frm.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            timer1.Start();
            progressBar1.Visible = true;
            DateTime[] fechas;
            DateTime del= dateTimePicker3.Value;
            DateTime al = dateTimePicker4.Value;
            TimeSpan dif = al - del;
            if (Convert.ToInt32(dif.Days) == 0)
            {
                imprime(del);
            }
            else
            {
                for (int i = 0; i < Convert.ToInt32(dif.Days)+1; i++)
                {
                    imprime((del.AddDays(i)));
                }
            }
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
