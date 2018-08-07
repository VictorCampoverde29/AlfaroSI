using System;
using System.Windows.Forms;
using LIBRERIA;

namespace ALFARO_CAJA
{
    public partial class CONSULTA_ARMADOR : Form
    {
        public CONSULTA_ARMADOR()
        {
            InitializeComponent();
        }
        Clsarmador A = new Clsarmador();
        CLSPERDIDA P = new CLSPERDIDA();
        private void CONSULTA_ARMADOR_Load(object sender, EventArgs e)
        {
            LISTAR_ARMADORES();
            comboBox1.SelectedIndex = 0;
            STPC.Text = Environment.MachineName;
        }
        void LISTAR_ARMADORES()
        {
            CMBARMADOR.DataSource = A.llenar_ARMADOR();
            CMBARMADOR.DisplayMember = "NOMBRE";
            CMBARMADOR.ValueMember = "IDARMADOR";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = P.CONSULT_ARMADOR_FECHA_ESTADO
          (CMBARMADOR.Text,Convert.ToChar(comboBox1.Text.Substring(0,1)), dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
