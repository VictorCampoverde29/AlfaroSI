using LIBRERIA;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class SistemasCaja : Form
    {
        public SistemasCaja()
        {
            InitializeComponent();
        }
        Clscaja CJ = new Clscaja();
        private void SistemasCaja_Load(object sender, EventArgs e)
        {
            LBLCOD.Visible = false;
            button1.Visible = false;
            STPC.Text = Environment.MachineName;
            comboBox1.SelectedIndex = 0;
            CMBESTADO.SelectedIndex = 0;
        }
        void LLENARDGV()
        {
            DGVDATA.DataSource = CJ.BUSCAR_CAJAS_MES(Convert.ToInt32(comboBox1.SelectedIndex + 1), Convert.ToInt32(numericUpDown1.Value));
            DGVDATA.Columns["CODIGO"].Visible = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            LLENARDGV();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
          
        }

        private void DGVDATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LBLCOD.Text = DGVDATA.CurrentRow.Cells["CODIGO"].Value.ToString();
            textBox1.Text = DGVDATA.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
            DTPFECHA.Value = (DateTime)DGVDATA.CurrentRow.Cells["FECHA APERTURA"].Value;
            CMBESTADO.Text = (string)DGVDATA.CurrentRow.Cells["ESTADO"].Value;
            LBLUSUARIO.Text = DGVDATA.CurrentRow.Cells["APERTURADO POR"].Value.ToString();
        }

        private void LBLCOD_TextChanged(object sender, EventArgs e)
        {
            if (LBLCOD.Text == "-------")
            {
                button1.Visible = false;
            }
            else

            {
                button1.Visible = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            LLENARDGV();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, CJ.MODIFICAR_CAJA(Convert.ToInt32(LBLCOD.Text), textBox1.Text, DTPFECHA.Value, CMBESTADO.Text.Substring(0, 1)));
            LBLCOD.Text = "-------";
            textBox1.Clear();
            LBLUSUARIO.Text = "---";
            LLENARDGV();
        }
    }
}
