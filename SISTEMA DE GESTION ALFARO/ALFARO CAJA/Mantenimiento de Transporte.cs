using LIBRERIA;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Mantenimiento_de_Transporte : Form
    {
        public Mantenimiento_de_Transporte()
        {
            InitializeComponent();
        }
        CLSTRANSPORTE TP = new CLSTRANSPORTE();
        private void Mantenimiento_de_Transporte_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        void BUSQUEDAD()
        {
            if (comboBox1.Text == "RUC")
            {
                dataGridView1.DataSource = TP.BUSQ_TRANSPORTISTA_RUC(textBox1.Text);
                dataGridView1.Columns["idtranspoRTE"].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = TP.FIL_TRANSPORTISTA_NOMBRE(textBox1.Text);
                dataGridView1.Columns["idtranspoRTE"].Visible = false;
            }
        }
        private void metroTile1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BUSQUEDAD();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LBLCODIGO.Text = dataGridView1.CurrentRow.Cells["IDTRANSPORTE"].Value.ToString();
            TXTNOMBRE.Text = dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
            TXTRUC.Text = dataGridView1.CurrentRow.Cells["RUC"].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells["ESTADO"].Value.ToString();
        }

        private void Mantenimiento_de_Transporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void TXTRUC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LBLCODIGO.Text == "------")
            {
                MessageBox.Show(this, "SELECCIONE UN TRANSPORTE A EDITAR", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, TP.MODIFICAR_TRANSPOC(Convert.ToInt32(LBLCODIGO.Text), TXTNOMBRE.Text, TXTRUC.Text, comboBox2.Text.Substring(0, 1)), "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LBLCODIGO.Text = "------";
                TXTNOMBRE.Clear();
                TXTRUC.Clear();
                BUSQUEDAD();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXTNOMBRE.Text == "" || TXTRUC.Text == "")
            {
                MessageBox.Show(this, "FALTAN DATOS", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show(this, TP.NUEVO_TRANSPOC(TXTNOMBRE.Text, TXTRUC.Text), "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
        }
    }
}
