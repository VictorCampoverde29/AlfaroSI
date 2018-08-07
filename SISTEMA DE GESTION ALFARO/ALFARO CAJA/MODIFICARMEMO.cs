using System;
using System.Data;
using System.Windows.Forms;
using LIBRERIA;
using CrystalDecisions.CrystalReports.Engine;

namespace ALFARO_CAJA
{
    public partial class MODIFICARMEMO : Form
    {
        public MODIFICARMEMO()
        {
            InitializeComponent();
        }
        Clsarmador ARMA = new Clsarmador();
        CLSMEMORANDUM MEMO = new CLSMEMORANDUM();
        CLSREPORTES REP = new CLSREPORTES();
        public string NOMBRE_TRABAJADOR;
        public string NOMBRE_USUARIO_QUE_REGISTRO;
        void LISTAR_ARMADORES()
        {
            CMBARMADOR.DataSource = ARMA.llenar_ARMADOR();
            CMBARMADOR.DisplayMember = "NOMBRE";
            CMBARMADOR.ValueMember = "IDARMADOR";
            CMBARMADOR.Text = NOMBRE_TRABAJADOR;
        }
        private void MODIFICARMEMO_Load(object sender, EventArgs e)
        {
            LISTAR_ARMADORES();
            STPC.Text = Environment.MachineName;
        }
        void REPORTE_MEMO(Int32 NUM)
        {
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            rpt.Load("C:/SI_Gestion/REPORTES/Memorandum.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB 
            dt_c = REP.VER_MEMO(Convert.ToInt32(NUM));
            ds.Tables.Add(dt_c);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);

            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "MEMORANDUM TRABAJADOR";
            frm.MdiParent = this.ParentForm;
            frm.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CMBTIPO.Text == "COMUNICADO")
            {
                String NUM = MEMO.MODIFICAR_MEMO(Convert.ToInt32(LBLCOD.Text), TXTCP1.Text, TXTCP2.Text, TXTCP3.Text, dateTimePicker1.Value, CMBASUNTO.Text, 292906, STCODIGO.Text, CMBTIPO.Text);
                MessageBox.Show(this, NUM,VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                REPORTE_MEMO(Convert.ToInt32(LBLCOD.Text));

            }
            else
            {
                String NUM = MEMO.MODIFICAR_MEMO(Convert.ToInt32(LBLCOD.Text), TXTCP1.Text, TXTCP2.Text, TXTCP3.Text, dateTimePicker1.Value, CMBASUNTO.Text, Convert.ToInt32(CMBARMADOR.SelectedValue), STCODIGO.Text, CMBTIPO.Text);
                MessageBox.Show(this, NUM, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                REPORTE_MEMO(Convert.ToInt32(LBLCOD.Text));
            }
        }
    }
    }

