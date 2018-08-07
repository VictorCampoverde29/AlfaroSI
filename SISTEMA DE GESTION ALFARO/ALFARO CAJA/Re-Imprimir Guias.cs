using LIBRERIA;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Re_Imprimir_Guias : Form
    {
        public Re_Imprimir_Guias()
        {
            InitializeComponent();
        }
        CLSDEVOLUCION DV = new CLSDEVOLUCION();
        CLSREPORTES REP = new CLSREPORTES();
        public String PERFIL;
        private void Re_Imprimir_Guias_Load(object sender, EventArgs e)
        {
         
            STPC.Text = Environment.MachineName;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dataGridView1.DataSource = DV.REPORTE_BUSQ_X_NUMERO(textBox1.Text);
                dataGridView1.Columns["CODIGO"].Visible = false;
            }
        }

        private void linkLabel4_Click(object sender, EventArgs e)
        {
           
        }
        

     


        void muestra_solo()
        {
            progressBar1.Visible = true;
            if (PERFIL == "DEVOLUCIONES")
            {

                IMPRESION_REPORTES VEN = new IMPRESION_REPORTES();
                VEN.Text = "IMPRESION DE GUIA";
                VEN.reportViewer1.LocalReport.ReportEmbeddedResource = @"ALFARO_CAJA.REPORTES.G_Devolucion_Dev.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                VEN.reportViewer1.RefreshReport();
                ReportDataSource rds = new ReportDataSource("DEVO", REP.IMPR_GUIA_DEVOL_AREA_DEVOL(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CODIGO"].Value)));
                ReportDataSource rds1 = new ReportDataSource("DEVO_DET", REP.IMPR_GUIA_DEVOL_DETALLES_AREA_DEVOLUCION(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CODIGO"].Value)));
                VEN.reportViewer1.LocalReport.DataSources.Clear();
                VEN.reportViewer1.LocalReport.DataSources.Add(rds);
                VEN.reportViewer1.LocalReport.DataSources.Add(rds1);
                VEN.reportViewer1.RefreshReport();
                VEN.MdiParent = this.ParentForm;
                VEN.Show();
            }
            else
            {
                IMPRESION_REPORTES VEN = new IMPRESION_REPORTES();
                VEN.Text = "IMPRESION DE GUIA";
                VEN.reportViewer1.LocalReport.ReportEmbeddedResource = @"ALFARO_CAJA.REPORTES.G_Devolucion.rdlc";
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("USU", STCODIGO.Text);
                VEN.reportViewer1.LocalReport.SetParameters(parametros);
                VEN.reportViewer1.RefreshReport();
                ReportDataSource rds = new ReportDataSource("DATOS_DEVO", REP.IMPR_GUIA_D(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CODIGO"].Value)));
                ReportDataSource rds1 = new ReportDataSource("Detalles_devo", REP.IMPR_GUIA_DEVOL_DETALLES(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CODIGO"].Value)));
                VEN.reportViewer1.LocalReport.DataSources.Clear();
                VEN.reportViewer1.LocalReport.DataSources.Add(rds);
                VEN.reportViewer1.LocalReport.DataSources.Add(rds1);
                VEN.reportViewer1.RefreshReport();
                VEN.MdiParent = this.ParentForm;
                VEN.Show();


            }
            progressBar1.Visible = false;
            progressBar1.Value = 0;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            muestra_solo();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DV.BUSQUEDAD_GUIAS_X_USUARIO(STCODIGO.Text, 'A', dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.Columns["CODIGO"].Visible = false;
        }
    }
}
