using System;
using System.Data;
using System.Windows.Forms;
using LIBRERIA;
using CrystalDecisions.CrystalReports.Engine;

namespace ALFARO_CAJA
{
    public partial class CONSULTA_RECEPCION : Form
    {
        public CONSULTA_RECEPCION()
        {
            InitializeComponent();
        }
        CLSDESCARGAS ds = new CLSDESCARGAS();
        DataTable dtv = new DataTable();
        DataTable dtd = new DataTable();
        private void CONSULTA_RECEPCION_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
        }

     


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            DETALLE_DE_CONSULTA_DESCARGAS_Y_VISITAS VEN = new DETALLE_DE_CONSULTA_DESCARGAS_Y_VISITAS();
            VEN.groupBox1.Text = "LABORATORIO:";
            VEN.lblnombreempresa.Text =dataGridView1.CurrentRow.Cells["LABORATORIO"].Value.ToString();
            VEN.DGVDATADETALLE.DataSource = ds.llenar_PERSOnal_x_codigo(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CODIGO"].Value));
            VEN.MdiParent = this.ParentForm;
            VEN.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            M_PRINCIPAL padre = new M_PRINCIPAL();
            DETALLE_DE_CONSULTA_DESCARGAS_Y_VISITAS VEN = new DETALLE_DE_CONSULTA_DESCARGAS_Y_VISITAS();
            VEN.groupBox1.Text = "EMPRESA";
            VEN.lblnombreempresa.Text = dataGridView2.CurrentRow.Cells["EMPRESA"].Value.ToString();
            VEN.DGVDATADETALLE.DataSource = ds.llenar_PERSOnal_x_codigo(Convert.ToInt32(dataGridView2.CurrentRow.Cells["CODIGO"].Value));
            VEN.MdiParent = this.ParentForm;
            VEN.Show();
        }

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);

        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            dtv = ds.llenar_VISITA(dateTimePicker1.Value);
            dtd = ds.llenar_descarga(dateTimePicker1.Value);

            dataGridView1.DataSource = dtd;
            dataGridView1.Columns["CANTIDADES"].Visible = false;
            dataGridView1.Columns["CODIGO"].Visible = false;
            //LBLREGISTROSDESCARGAS.Text = dataGridView1.RowCount + " REGISTROS";
            dataGridView2.DataSource = dtv;
            dataGridView2.Columns["CODIGO"].Visible = false;
            //LBLVISITASRG.Text= dataGridView2.RowCount + " REGISTROS";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String Vista=tabControl1.SelectedTab.Name.ToString();
            if (Vista.Equals("DESCARGAS"))
            {
                timer1.Start();
                progressBar1.Visible = true;
                VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                ReportDocument rpt = new ReportDocument();
                //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Rpt_Descargas.rpt");
                rpt.Load("C:/SI_Gestion/REPORTES/Rpt_Descargas.rpt");
                DataSet dst = new DataSet();
                DataTable dt_c = new DataTable(); //ResultSet de DB
                dt_c = ds.llenar_descargas_rp(dateTimePicker1.Value);
                dst.Tables.Add(dt_c);
                rpt.Database.Tables[0].SetDataSource(dst.Tables[0]);
                rpt.SetParameterValue("USU", STCODIGO.Text);
                rpt.SetParameterValue("FECHA", dateTimePicker1.Value);

                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                frm.Refresh();  //se refresca 
                timer1.Stop();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                frm.Text = "REPORTE DE DESCARGAS POR FECHA";
                frm.Show();
            }
            else
            {
                timer1.Start();
                progressBar1.Visible = true;
                VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                ReportDocument rpt = new ReportDocument();
                // rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Rpt_Visitas.rpt");
                rpt.Load("C:/SI_Gestion/REPORTES/Rpt_Visitas.rpt");
                DataSet dst = new DataSet();
                DataTable dt_c = new DataTable(); //ResultSet de DB
                dt_c = ds.llenar_visitas_rp(dateTimePicker1.Value);
                dst.Tables.Add(dt_c);
                rpt.Database.Tables[0].SetDataSource(dst.Tables[0]);
                rpt.SetParameterValue("USU", STCODIGO.Text);
                rpt.SetParameterValue("FECHA", dateTimePicker1.Value);

                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                frm.Refresh();  //se refresca 
                timer1.Stop();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                frm.Text = "REPORTE DE VISITAS POR FECHA";
                frm.Show();
            }

        }

     
    }
}
