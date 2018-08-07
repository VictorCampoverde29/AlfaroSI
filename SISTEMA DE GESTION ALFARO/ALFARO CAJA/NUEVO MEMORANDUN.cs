using System;
using System.Data;
using System.Windows.Forms;
using LIBRERIA;

using CrystalDecisions.CrystalReports.Engine;

namespace ALFARO_CAJA
{
    public partial class NUEVO_MEMORANDUN : Form
    {
        public NUEVO_MEMORANDUN()
        {
            InitializeComponent();
        }
        CLSMEMORANDUM MEMO = new CLSMEMORANDUM();
        Clsarmador ARMA = new Clsarmador();
        CLSREPORTES REP = new CLSREPORTES();
        private void NUEVO_MEMORANDUN_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            CMBASUNTO.SelectedIndex = 0;
            CMBTIPO.SelectedIndex = 0;
            LISTAR_ARMADORES();
        }
        void LISTAR_ARMADORES()
        {
            CMBARMADOR.DataSource = ARMA.llenar_ARMADOR();
            CMBARMADOR.DisplayMember = "NOMBRE";
            CMBARMADOR.ValueMember = "IDARMADOR";
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
            frm.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            

            
        }
        void llenado_txt()
        {
            if (CMBTIPO.Text == "INASISTENCIA INJUSTIFICADA")
            {
                TXTCP1.Text = "Mediante la presente se le hace llegar una llamada de atención por la inasistencia injusticada " +
                    "del dia --/--/----.";
                TXTCP2.Text = "Cabe mencionar que toda inasistencia debe ser justificada en el momento a fin de " +
                    "evitarse llamadas de atención.";
                TXTCP3.Text = "En este sentido,apelamos a su criterio para corregir "
           + "esta mala actitud de lo contrario nos veremos en la necesidad de tomar " + 
           "otras medidas que afectaran a su continuidad en la empresa.";
            }
            else if (CMBTIPO.Text == "TARDANZA")
            {
                TXTCP1.Text = "Mediante la presente se le hace llegar el presente memorandum " +
                    "por la tardanza del dia --/--/----.";
                TXTCP2.Text = "Cabe mencionar que toda tardanza debe ser justificada en el momento a fin de " +
                    "evitarse llamadas de atención.";
                TXTCP3.Text = "En este sentido,apelamos a su criterio para corregir "
           + "esta mala actitud de lo contrario nos veremos en la necesidad de tomar " +
           "otras medidas que afectaran a su continuidad en la empresa.";
            }
            else if (CMBTIPO.Text == "FALTA DISCIPLINARIA")
            {
                TXTCP1.Text = "Mediante la presente se le hace llegar una llamada de atención ..............................";
                TXTCP2.Text = "Es de su conocimiento que todo trabajador tiene que acatar las disposiciones y políticas " +
                    "de la empresa,sin embargo Ud. está haciendo caso omiso a tales disposiciones,por tal se le está "+
                    "amonestando por esta indisciplina.";
                TXTCP3.Text = "En este sentido,apelamos a su criterio para corregir "
           + "esta mala actitud de lo contrario nos veremos en la necesidad de tomar " +
           "otras medidas que afectaran a su continuidad en la empresa.";
            }
            else if (CMBTIPO.Text == "ERROR DE TRABAJO")
            {
                TXTCP1.Text = "Mediante la presente se le hace llegar una llamada de atención,por NO realizar bien su trabajo......................";
                TXTCP2.Text = "Es de su conocimiento que todo trabajador tiene que realizar bien su función y asi " +
                    "de la empresa,sin embargo Ud. está haciendo caso omiso a tales disposiciones,por tal se le está " +
                    "evitarse llamadas de atención.";
                TXTCP3.Text = "En este sentido,apelamos a su criterio para corregir "
           + "esta mala actitud de lo contrario nos veremos en la necesidad de tomar " +
           "otras medidas que afectaran a su continuidad en la empresa.";
            }
            else if (CMBTIPO.Text == "COMUNICADO")
            {
                TXTCP1.Text = "";
                TXTCP2.Text = "";
                TXTCP3.Text = "";
            }
        }
        private void CMBTIPO_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CMBASUNTO_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
           

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenado_txt();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBASUNTO.SelectedIndex == 0)
            {
                CMBTIPO.Items.Clear();
                CMBTIPO.Items.Add("COMUNICADO");
                CMBTIPO.SelectedIndex = 0;

            }
            else if (CMBASUNTO.SelectedIndex == 1)
            {
                CMBTIPO.Items.Clear();
                CMBTIPO.Items.Add("INASISTENCIA INJUSTIFICADA");
                CMBTIPO.Items.Add("ERROR DE TRABAJO");
                CMBTIPO.Items.Add("FALTA DISCIPLINARIA");
                CMBTIPO.SelectedIndex = 0;

            }
            else
            {
                CMBTIPO.Items.Clear();
                CMBTIPO.Items.Add("TARDANZA");
                CMBTIPO.SelectedIndex = 0;
            }

        }

        private void CLAVE_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CMBTIPO.Text == "COMUNICADO")
            {
                Int32 NUM = MEMO.APLICAR_MEMO(TXTCP1.Text, TXTCP2.Text, TXTCP3.Text, dateTimePicker1.Value, CMBASUNTO.Text, 292906, STCODIGO.Text, CMBTIPO.Text);
                if (NUM == 999)
                {
                    MessageBox.Show("YA SE APLICO UN MEMORANDUM PARA ESTE USUARIO EN ESTA FECHA");
                }
                else
                {
                    MessageBox.Show("MEMORANDUM N°:" + NUM + " REGISTRADO");
                    REPORTE_MEMO(NUM);
                }
            }
            else
            {
                Int32 NUM = MEMO.APLICAR_MEMO(TXTCP1.Text, TXTCP2.Text, TXTCP3.Text, dateTimePicker1.Value, CMBASUNTO.Text, Convert.ToInt32(CMBARMADOR.SelectedValue), STCODIGO.Text, CMBTIPO.Text);
                if (NUM == 999)
                {
                    MessageBox.Show("YA SE APLICO UN MEMORANDUM PARA ESTE USUARIO EN ESTA FECHA");
                }
                else
                {
                    MessageBox.Show("MEMORANDUM N°:" + NUM + " REGISTRADO");
                    REPORTE_MEMO(NUM);
                }
            }
        }
    }
}
