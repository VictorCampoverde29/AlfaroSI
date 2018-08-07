using LIBRERIA;


using System;

using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class NUEVO_CONTACTO : Form
    {
        public NUEVO_CONTACTO()
        {
            InitializeComponent();
        }
        CLSDIRECTORIO DIR = new CLSDIRECTORIO();
        private void NUEVO_CONTACTO_Load(object sender, EventArgs e)
        {
            cmbclasi.SelectedIndex = 0;
            cmbestado.SelectedIndex = 0;
            STPC.Text = Environment.MachineName;
        }
        void LLENAR_CONTACTOS()
        {
            dataGridView1.DataSource = DIR.MOSTRAR_DIRECTORIO_CONTACTOS();
            dataGridView1.Columns["IDDIRECTORIO"].Visible = false;
            dataGridView1.Columns["CLASIFICACION"].Visible = false;

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
           
        }
        private void TXTELEFONOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                cmbestado.Focus();
            }
        }
        private void TXTEMAIL_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTELEFONOS.Focus();
            }
        }

        private void TXTCLIENTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTEMAIL.Focus();
            }
        }

        private void TXTOBSERVACION_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTCLIENTE.Text = dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
            TXTEMAIL.Text = dataGridView1.CurrentRow.Cells["EMAIL"].Value.ToString();
            TXTELEFONOS.Text = dataGridView1.CurrentRow.Cells["TELEFONO"].Value.ToString();
            cmbclasi.Text = dataGridView1.CurrentRow.Cells["CLASIFICACION"].Value.ToString();
            TXTOBSERVACION.Text = dataGridView1.CurrentRow.Cells["EMPRESA"].Value.ToString();
            LBLCLIENTE.Text = dataGridView1.CurrentRow.Cells["IDDIRECTORIO"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["ESTADO"].Value.ToString() == "ACT")
            { cmbestado.SelectedIndex = 0; }
            else { cmbestado.SelectedIndex = 1; }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DIR.filtrar_DIRECTORIO_Contactos(textBox1.Text);
            dataGridView1.Columns["IDDIRECTORIO"].Visible = false;
            dataGridView1.Columns["CLASIFICACION"].Visible = false;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TXTCLIENTE.Clear();
            TXTELEFONOS.Clear();
            TXTEMAIL.Clear();
            TXTOBSERVACION.Clear();
            cmbclasi.SelectedIndex = 0;
            cmbestado.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXTCLIENTE.Text == "")
            {
                MessageBox.Show(this, "INDIQUE NOMBRE DEL CONTACTO A REGISTRAR", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                String MSJE = DIR.REGISTRAR_CONTACTO(TXTCLIENTE.Text, TXTEMAIL.Text, TXTELEFONOS.Text, TXTOBSERVACION.Text, cmbclasi.Text);
                if (MSJE == "CONTACTO AÑADIDO AL DIRECTORIO")
                {
                    MessageBox.Show(this, MSJE, "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LLENAR_CONTACTOS();
                    TXTCLIENTE.Clear();
                    TXTEMAIL.Clear();
                    TXTELEFONOS.Clear();
                    TXTOBSERVACION.Clear();
                    TXTCLIENTE.Focus();
                }
                else
                {

                    MessageBox.Show(this, MSJE, "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (LBLCLIENTE.Text == "-----")
            {
                MessageBox.Show(this, "NO SE AH SELECCIONADO NINGUN CONTACTO PARA MODIFICAR", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                Int32 ESTO;
                if (cmbestado.SelectedIndex == 0)
                { ESTO = 1; }
                else { ESTO = 0; }
                String MSJE = DIR.MODIFICAR_CONTACTOS(Convert.ToInt32(LBLCLIENTE.Text), TXTCLIENTE.Text, TXTEMAIL.Text, TXTELEFONOS.Text, ESTO, TXTOBSERVACION.Text, cmbclasi.Text);
                MessageBox.Show(this, MSJE, "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }
}
