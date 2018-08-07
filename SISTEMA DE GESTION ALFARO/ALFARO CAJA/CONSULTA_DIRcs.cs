using LIBRERIA;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class CONSULTA_DIRcs : Form
    {
        public CONSULTA_DIRcs()
        {
            InitializeComponent();
        }
        CLSDIRECTORIO DIR = new CLSDIRECTORIO();
        private void CONSULTA_DIRcs_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            CMBBUS.SelectedIndex = 0;
            STPC.Text = Environment.MachineName;
        }

      

        private void RBNXNOMBRE_CheckedChanged(object sender, EventArgs e)
        {
            CMBBUS.Visible = false;
            LBLZONA.Visible = false;
        }

        private void RBNXZONA_CheckedChanged(object sender, EventArgs e)
        {
            CMBBUS.Visible = true;
            LBLZONA.Visible = true;
        }

        private void RBNXEMPRESA_CheckedChanged(object sender, EventArgs e)
        {
            CMBBUS.Visible = false;
            LBLZONA.Visible = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (RBNXZONA.Checked == true)
                {
                    dataGridView1.DataSource = DIR.filtrar_DIRECTORIO_CLIENTES(textBox1.Text, CMBBUS.Text);
                    dataGridView1.Columns["IDDIRECTORIO"].Visible = false;
                }
                if (RBNXNOMBRE.Checked == true && comboBox1.SelectedIndex == 1)
                {
                    dataGridView1.DataSource = DIR.filtrar_DIRECTORIO_Contactos(textBox1.Text);
                    dataGridView1.Columns["IDDIRECTORIO"].Visible = false;
                }
                if (RBNXEMPRESA.Checked == true && comboBox1.SelectedIndex == 1)
                {
                    dataGridView1.DataSource = DIR.filtrar_DIRECTORIO_CONTACTOS_X_EMPRESA(textBox1.Text);
                    dataGridView1.Columns["IDDIRECTORIO"].Visible = false;
                }
                if (RBNXNOMBRE.Checked == true && comboBox1.SelectedIndex == 0)
                {
                    dataGridView1.DataSource = DIR.filtrar_DIRECTORIO_CLIENTES_X_NOMBRE(textBox1.Text);
                    dataGridView1.Columns["IDDIRECTORIO"].Visible = false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                RBNXEMPRESA.Enabled = false;
                RBNXZONA.Enabled = true;
                RBNXZONA.Checked = true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                RBNXEMPRESA.Enabled = true;
                RBNXEMPRESA.Checked = true;
                RBNXZONA.Enabled = false;
            }
        }
    }
}
