using System;
using System.Windows.Forms;
using LIBRERIA;
namespace ALFARO_CAJA
{
    public partial class MANT_PERSONAL : Form
    {
        public MANT_PERSONAL()
        {
            InitializeComponent();
        }

        Clsarmador ARM = new Clsarmador();
        private void MANT_PERSONAL_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            LLENAR_TRABAJADORES();
        }
        void LLENAR_TRABAJADORES()
        {
            DATOS.DataSource = ARM.llenar_ARMADOR_TODOS();
            DATOS.Columns["IDARMADOR"].Visible = false;
        }
        private void metroTile2_Click(object sender, EventArgs e)
        {

        }

        private void DATOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTNOMBRE.Text = DATOS.CurrentRow.Cells["NOMBRE"].Value.ToString();
            TXTDNI.Text = DATOS.CurrentRow.Cells["DNI"].Value.ToString();
            comboBox1.Text = DATOS.CurrentRow.Cells["CARGO"].Value.ToString();
            comboBox2.Text = DATOS.CurrentRow.Cells["ESTADO"].Value.ToString();
            LBLCOD.Text = DATOS.CurrentRow.Cells["IDARMADOR"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LBLCOD.Text == "--")
            {
                MessageBox.Show(this, "CARGUE ALGUN TRABAJADOR PARA MODIFICAR LOS DATOS", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int ESTA;
                if (comboBox2.SelectedIndex == 0) { ESTA = 1; } else { ESTA = 0; }
                String MSJE = ARM.MODIFICAR_ARMADOR(Convert.ToInt32(LBLCOD.Text), TXTNOMBRE.Text, TXTDNI.Text, comboBox1.Text, ESTA);

                MessageBox.Show(this, MSJE, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MSJE == "PERSONAL MODIFICADO")
                {
                    LBLCOD.Text = "--";
                    TXTDNI.Clear();
                    TXTNOMBRE.Clear();
                    LLENAR_TRABAJADORES();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DNI = TXTDNI.Text;
            if (TXTNOMBRE.Text == "")
            {
                MessageBox.Show(this, "INGRESE NOMBRE", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (DNI.Length < 7)
            {

                MessageBox.Show(this, "DNI INCORRECTO", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                String MSJE = ARM.REG_ARMADOR(TXTNOMBRE.Text, TXTDNI.Text, comboBox1.Text);
                MessageBox.Show(this, MSJE, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LLENAR_TRABAJADORES();
            }
        }

        private void TXTNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar==(int)Keys.Enter)
            {
                TXTDNI.Focus();
            }
        }

        private void TXTDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                comboBox1.Focus();
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                comboBox2.Focus();
            }
        }
    }
}
