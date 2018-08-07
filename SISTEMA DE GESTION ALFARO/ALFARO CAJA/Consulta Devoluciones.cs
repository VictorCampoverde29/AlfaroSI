using CrystalDecisions.CrystalReports.Engine;
using LIBRERIA;
using System;
using System.Data;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Consulta_Devoluciones : Form
    {
        public Consulta_Devoluciones()
        {
            InitializeComponent();
        }
        CLSDEVOLUCION DV = new CLSDEVOLUCION();
        CLSTRANSPORTE T = new CLSTRANSPORTE();       
        CLSREPORTES RP = new CLSREPORTES();
        private void Consulta_Devoluciones_Load(object sender, EventArgs e)
        {
            LLENAR_LINEA();
            LLENAR_TRANSPORTISTA();
            CMBESTADO.SelectedIndex = 0;
            STPC.Text = Environment.MachineName;
            if (checkBox1.Checked == true)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
  
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dataGridView1.DataSource = DV.REPORTE_BUSQ_X_NUMERO(textBox1.Text);
                dataGridView1.Columns["CODIGO"].Visible = false;
            }
         
        }
        void LLENAR_TRANSPORTISTA()
        {
            CMBTRANSPORTISTA.DataSource = CLSTRANSPORTE.llenar_TRANSPORTISTA();
            CMBTRANSPORTISTA.DisplayMember = "NOMBRE";
            CMBTRANSPORTISTA.ValueMember = "IDTRANSPORTE";
        }
        void LLENAR_LINEA()
        {
            comboBox1.DataSource = CLSLINEA.llenar_LINEAS();
            comboBox1.DisplayMember = "DESCRIPCION";
            comboBox1.ValueMember = "IDLINEA";
        }
    

         

    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Detalle_de_Devolucion VEN = new Detalle_de_Devolucion();
            VEN.Text = "GUIA NUMERO:" + dataGridView1.CurrentRow.Cells["NUMERO_GUIA"].Value.ToString();
            VEN.LBLESTADO.Text = dataGridView1.CurrentRow.Cells["ESTADO"].Value.ToString();
            VEN.LBLGUIA.Text = dataGridView1.CurrentRow.Cells["NUMERO_GUIA"].Value.ToString();
            VEN.LBLLINEA.Text = dataGridView1.CurrentRow.Cells["LINEA"].Value.ToString();
            VEN.LBLFECHA.Text = dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString();
            VEN.LBLFECHATRASLADO.Text = dataGridView1.CurrentRow.Cells["FECHA_TRASLADO"].Value.ToString();
            VEN.LBLREFERENCIA.Text = dataGridView1.CurrentRow.Cells["MOTIVO"].Value.ToString(); 
            VEN.LBLTRANSPORTE.Text = dataGridView1.CurrentRow.Cells["TRANSPORTISTA"].Value.ToString();
            VEN.dataGridView1.DataSource = RP.IMPR_GUIA_DEVOL_DETALLES(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CODIGO"].Value));
            VEN.MdiParent = this.ParentForm;
            VEN.Show();
        }

        private void LBLVALOR_TextChanged(object sender, EventArgs e)
        {
            if (LBLVALOR.Text == "REPORTE")
            {
                //metroPanel4.Visible = false;
                //metroPanel3.Visible = false;
                dataGridView1.Visible = false;
            }
            else
            {
                //metroPanel4.Visible = true;
                //metroPanel3.Visible = true;
            }
        }

        private void TXTBUSFT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dataGridView1.DataSource = DV.REPORTE_BUSQ_X_FT(TXTBUSFT.Text);
                dataGridView1.Columns["CODIGO"].Visible = false;
            }
    
        }

        private void TXTBUSGUIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dataGridView1.DataSource = DV.REPORTE_BUSQ_X_GUIA(TXTBUSGUIA.Text);
                dataGridView1.Columns["CODIGO"].Visible = false;
            }
        
        }

        private void CMBESTADO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel4_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
           


        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {
           
        }

        private void CMBESTADO_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LBLVALOR.Text == "REPORTE")
            {

                VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                ReportDocument rpt = new ReportDocument();
                //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Reporte_Devoluciones_Fecha.rpt");
                rpt.Load("C:/SI_Gestion/REPORTES/Reporte_Devoluciones_Fecha.rpt");
                DataSet ds = new DataSet();
                DataTable dt_c = new DataTable(); //ResultSet de DB
                dt_c = DV.REPORTE_BUSQ_X_FECHA(dateTimePicker1.Value, dateTimePicker2.Value);
                ds.Tables.Add(dt_c);
                rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                rpt.SetParameterValue("USU", STCODIGO.Text);
                rpt.SetParameterValue("DEL", dateTimePicker1.Value + "");
                rpt.SetParameterValue("AL", dateTimePicker2.Value + "");
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                frm.Refresh();  //se refresca 
                timer1.Stop();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                frm.Text = "REPORTE GUIAS POR FECHA Y ESTADO";
                frm.MdiParent = this.ParentForm;
                frm.Show();
            }
            else
            {
                dataGridView1.DataSource = DV.REPORTE_BUSQ_X_FECHA(dateTimePicker1.Value, dateTimePicker2.Value);
                dataGridView1.Columns["CODIGO"].Visible = false;

            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LBLVALOR.Text == "REPORTE")
            {

                VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                ReportDocument rpt = new ReportDocument();
                rpt.Load("C:/SI_Gestion/REPORTES/Reporte_devoluciones_x_linea.rpt");
                DataSet ds = new DataSet();
                DataTable dt_c = new DataTable(); //ResultSet de DB
                dt_c = DV.REPORTE_BUSQ_X_LABORATORIO(Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Value, dateTimePicker2.Value);
                ds.Tables.Add(dt_c);
                rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                rpt.SetParameterValue("USU", STCODIGO.Text);
                rpt.SetParameterValue("FDEL", dateTimePicker1.Value);
                rpt.SetParameterValue("FAL", dateTimePicker2.Value + "");
                rpt.SetParameterValue("LINEA", comboBox1.Text.ToUpper());
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                frm.Refresh();  //se refresca 
                timer1.Stop();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                frm.Text = "REPORTE DE DEVOLUCIONES DE ACUERDO A N° DE GUIAS X LABORATORIO";
                frm.MdiParent = this.ParentForm;
                frm.Show();


            }
            else
            {
                dataGridView1.DataSource = DV.REPORTE_BUSQ_X_LABORATORIO(Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Value, dateTimePicker2.Value);
                dataGridView1.Columns["CODIGO"].Visible = false;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LBLVALOR.Text == "REPORTE")
            {
                VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                ReportDocument rpt = new ReportDocument();
                //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Reporte_Devoluciones_x_Transportista.rpt");
                rpt.Load("C:/SI_Gestion/REPORTES/Reporte_Devoluciones_x_Transportista.rpt");
                DataSet ds = new DataSet();
                DataTable dt_c = new DataTable(); //ResultSet de DB
                dt_c = DV.REPORTE_BUSQ_X_TRASNPORTE(Convert.ToInt32(CMBTRANSPORTISTA.SelectedValue), dateTimePicker1.Value, dateTimePicker2.Value);
                ds.Tables.Add(dt_c);
                rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                rpt.SetParameterValue("USU", STCODIGO.Text);
                rpt.SetParameterValue("DEL", dateTimePicker1.Value + "");
                rpt.SetParameterValue("AL", dateTimePicker2.Value + "");
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                frm.Refresh();  //se refresca 
                timer1.Stop();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                frm.Text = "REPORTE DE GUIAS DE DEVOLUCION:" + CMBTRANSPORTISTA.Text;
                frm.MdiParent = this.ParentForm;
                frm.Show();


            }
            else
            {
                dataGridView1.DataSource = DV.REPORTE_BUSQ_X_TRASNPORTE(Convert.ToInt32(CMBTRANSPORTISTA.SelectedValue), dateTimePicker1.Value, dateTimePicker2.Value);
                dataGridView1.Columns["CODIGO"].Visible = false;

            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Char ESTADO = 'A';
            if (CMBESTADO.SelectedIndex == 0) { ESTADO = 'A'; }
            else if (CMBESTADO.SelectedIndex == 1) { ESTADO = 'T'; }
            else { ESTADO = 'N'; }
            if (LBLVALOR.Text == "REPORTE")
            {
                progressBar1.Visible = true;
                if (ESTADO == 'T')
                {

                    VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                    ReportDocument rpt = new ReportDocument();
                    //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\Reporte_de_Devoluciones.rpt");
                    rpt.Load("C:/SI_Gestion/REPORTES/Reporte_de_Devoluciones.rpt");
                    DataSet ds = new DataSet();
                    DataTable dt_c = new DataTable(); //ResultSet de DB
                    dt_c = RP.REPORTE_TRANSLADADAS_FECHA(dateTimePicker1.Value, dateTimePicker2.Value);
                    ds.Tables.Add(dt_c);
                    rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                    rpt.SetParameterValue("USU", STCODIGO.Text);
                    rpt.SetParameterValue("FDEL", dateTimePicker1.Value);
                    rpt.SetParameterValue("FAL", dateTimePicker2.Value + "");
                    rpt.SetParameterValue("ESTADO", CMBESTADO.Text.ToUpper());
                    ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                    frm.Refresh();  //se refresca 
                    timer1.Stop();
                    progressBar1.Visible = false;
                    progressBar1.Value = 0;
                    //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                    //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                    frm.Text = "REPORTE DE GUIAS POR ESTADO:" + "TRANSPORTADA";
                    frm.MdiParent = this.ParentForm;
                    frm.Show();

                }
                else
                {
                    VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                    ReportDocument rpt = new ReportDocument();
                    rpt.Load("C:/SI_Gestion/REPORTES/Reporte_de_Devoluciones.rpt");
                    DataSet ds = new DataSet();
                    DataTable dt_c = new DataTable(); //ResultSet de DB
                    dt_c = RP.REPORTE_ESTADOS_FECHA(ESTADO, dateTimePicker1.Value, dateTimePicker2.Value);
                    ds.Tables.Add(dt_c);
                    rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                    rpt.SetParameterValue("USU", STCODIGO.Text);
                    rpt.SetParameterValue("FDEL", dateTimePicker1.Value);
                    rpt.SetParameterValue("FAL", dateTimePicker2.Value + "");
                    rpt.SetParameterValue("ESTADO", CMBESTADO.Text);
                    ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                    frm.Refresh();  //se refresca 
                    timer1.Stop();
                    progressBar1.Visible = false;
                    progressBar1.Value = 0;
                    //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                    //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                    frm.Text = "REPORTE DE GUIAS POR ESTADO:" + CMBESTADO.Text;
                    frm.MdiParent = this.ParentForm;
                    frm.Show();

                }
            }
            else
            {
                if (ESTADO == 'T')
                {
                    dataGridView1.DataSource = RP.REPORTE_TRANSLADADAS_FECHA(dateTimePicker1.Value, dateTimePicker2.Value);
                    dataGridView1.Columns["CODIGO"].Visible = false;


                }
                else
                {
                    dataGridView1.DataSource = DV.REPORTE_BUSQ_X_ESTADO(ESTADO, dateTimePicker1.Value, dateTimePicker2.Value);
                    dataGridView1.Columns["CODIGO"].Visible = false;

                }
            }

        }
    }
}
