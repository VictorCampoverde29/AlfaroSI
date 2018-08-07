using System;
using System.Data;
using System.Windows.Forms;
using LIBRERIA;
using CrystalDecisions.CrystalReports.Engine;
using System.Drawing.Printing;

namespace ALFARO_CAJA
{
    public partial class GENERAR_ACTAS_DE_ASEGURAMIENTO : Form
    {
        public GENERAR_ACTAS_DE_ASEGURAMIENTO()
        {
            InitializeComponent();
        }
        
        CLSREPORTES REP = new CLSREPORTES();
        private void GENERAR_ACTAS_DE_ASEGURAMIENTO_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            //LLENAR_LINEA();
        }
        //void LLENAR_LINEA()
        //{
        //    comboBox1.DataSource = CLSLINEA.llenar_LINEAS();
        //    comboBox1.DisplayMember = "DESCRIPCION";
        //    comboBox1.ValueMember = "IDLINEA";
        //}

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }



        void imprime(int valor)
        {
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            rpt.Load("C:/SI_Gestion/REPORTES/Acta_de_Aseguramiento.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            DataTable dt_c2 = new DataTable(); //ResultSet de DB
            dt_c = REP.ACTAS_X_COD_DEV(valor);
            dt_c2 = REP.DET_ACTAS_X_COD_DEV(valor);
            ds.Tables.Add(dt_c);
            ds.Tables.Add(dt_c2);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.Database.Tables[1].SetDataSource(ds.Tables[1]);
            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 

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
                                                 // frm.Show();
        }
        private void DGVDATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Start();
            progressBar1.Visible = true;
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            rpt.Load("C:/SI_Gestion/REPORTES/Acta_de_Aseguramiento.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            DataTable dt_c2 = new DataTable(); //ResultSet de DB
            dt_c = REP.ACTAS_X_COD_DEV(Convert.ToInt32(DGVDATA.CurrentRow.Cells["CODIGO"].Value));
            dt_c2 = REP.DET_ACTAS_X_COD_DEV(Convert.ToInt32(DGVDATA.CurrentRow.Cells["CODIGO"].Value));
            ds.Tables.Add(dt_c);
            ds.Tables.Add(dt_c2);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.Database.Tables[1].SetDataSource(ds.Tables[1]);
            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "REPORTE DE ACTAS DE DEVOLUCION";
            frm.MdiParent = this.ParentForm;
            frm.Show();


        }
        void imprimetodo()
        {
            for (int i = 0; i < DGVDATA.RowCount; i++)
            {
                imprime(Convert.ToInt32(DGVDATA.Rows[i].Cells["CODIGO"].Value));
            }
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVDATA.DataSource = REP.VER_ACTAS_ASEG_FECHA(dateTimePicker4.Value, dateTimePicker3.Value);
            DGVDATA.Columns["CODIGO"].Visible = false;
            if (DGVDATA.RowCount > 0)
            {
                button3.Visible = true;

            }
            else
            {
                button3.Visible = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            timer1.Start();
            imprimetodo();
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }
    }
}
