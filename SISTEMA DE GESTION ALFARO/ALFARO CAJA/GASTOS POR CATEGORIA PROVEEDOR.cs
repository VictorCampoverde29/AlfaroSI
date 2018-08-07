using System;
using System.Data;
using System.Windows.Forms;
using LIBRERIA;

using CrystalDecisions.CrystalReports.Engine;

namespace ALFARO_CAJA
{
    public partial class GASTOS_POR_CATEGORIA_PROVEEDOR : Form
    {
        CLSREPORTES REP = new CLSREPORTES();
        public GASTOS_POR_CATEGORIA_PROVEEDOR()
        {
            InitializeComponent();
        }
        Clscaja CJ = new Clscaja();
       
        void VER_GASTOS_CAJA()
        {
            dataGridView1.DataSource=CJ.VER_GASTO_CAJAS_MES(Convert.ToInt32(comboBox1.SelectedIndex + 1),Convert.ToInt32(numericUpDown1.Value));
        }
        private void GASTOS_POR_CATEGORIA_PROVEEDOR_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            comboBox1.SelectedIndex = 0;
            VER_GASTOS_CAJA();
            LLENARTOTAL();
            STPC.Text = Environment.MachineName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            VER_GASTOS_CAJA();
            LLENARTOTAL();
        }
        void LLENARTOTAL()
        {
            Decimal TOT = 0;
            for(int i=0;i<dataGridView1.RowCount;i++)
            {
                TOT = TOT + Convert.ToDecimal( dataGridView1.Rows[i].Cells["MONTO"].Value);
          
            }
            LBLGASTOT.Text ="TOTAL GASTADO: " +TOT ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        void generar_rep()
        {
            
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Garfico_Piramide.rpt");
            //rpt.Load("C:/SI_Gestion/REPORTES/Garfico_Piramide.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            dt_c = CJ.VER_GASTO_CAJAS_MES_REPORTE(Convert.ToInt32(comboBox1.SelectedIndex + 1), Convert.ToInt32(numericUpDown1.Value));
            ds.Tables.Add(dt_c);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.SetParameterValue("USU", STCODIGO.Text);
            rpt.SetParameterValue("AÑO", Convert.ToInt32(numericUpDown1.Value));
            rpt.SetParameterValue("GASTO",LBLGASTOT.Text);
            rpt.SetParameterValue("MES", comboBox1.Text);
            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "REPORTE DE CATEGORIA GRAFICO";
            frm.MdiParent = this.ParentForm;
            frm.Show();


        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        void reporte_categoria()
        {
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Reporte_Caja_Categoria.rpt");
            rpt.Load("C:/SI_Gestion/REPORTES/Reporte_Caja_Categoria.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            dt_c = REP.REPORTE_MES_X_CATEGORIA(Convert.ToInt32(comboBox1.SelectedIndex + 1), Convert.ToInt32(numericUpDown1.Value));
            ds.Tables.Add(dt_c);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.SetParameterValue("USU", STCODIGO.Text);
            rpt.SetParameterValue("numero", numericUpDown1.Value);
            rpt.SetParameterValue("MES", comboBox1.Text);
            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "REPORTE DE CATEGORIA DETALLADO";
            frm.MdiParent = this.ParentForm;
            frm.Show();



           
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            VER_GASTOS_CAJA();
            LLENARTOTAL();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            timer1.Start();
            reporte_categoria();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            timer1.Start();
            generar_rep();
        }
    }
}
