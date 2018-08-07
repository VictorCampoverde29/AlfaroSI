using System;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class NUEVO_DIRECTORIO : Form
    {
        public NUEVO_DIRECTORIO()
        {
            InitializeComponent();
        }
        CLSDIRECTORIO DIR = new CLSDIRECTORIO();
        void LLENAR_CLIENTES()
        {
            dataGridView1.DataSource = DIR.MOSTRAR_DIRECTORIO_CLIENTES();
            dataGridView1.Columns["IDDIRECTORIO"].Visible = false;
  
        }
        private void NUEVO_DIRECTORIO_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            TXTCLIENTE.Focus();
            cmbestado.SelectedIndex = 0;
            CMBZONAS.SelectedIndex = 0;
            CMBCLASI.SelectedIndex = 0;
            CMBBUS.SelectedIndex = 0;
            //LLENAR_CLIENTES();
            //MOSTRAR_X_ZONA();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TXTCLIENTE.Clear();
            TXTELEFONOS.Clear();
            TXTEMAIL.Clear();
            TXTOBSERVACION.Clear();
            CMBBUS.SelectedIndex = 0;
            CMBCLASI.SelectedIndex = 0;
            cmbestado.SelectedIndex = 0;
            CMBZONAS.SelectedIndex = 0;
        }
        void MOSTRAR_X_ZONA()
        {
            dataGridView1.DataSource = DIR.MOSTRAR_DIRECTORIO_CLIENTES_SEGUN_ZONA(CMBBUS.Text);
            dataGridView1.Columns["ZONA"].Visible = false;
            dataGridView1.Columns["IDDIRECTORIO"].Visible = false;
        }
        private void CMBBUS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void CMBBUS_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

       
        void FILTRADO_CLIENTES()
        {
            dataGridView1.DataSource = DIR.filtrar_DIRECTORIO_CLIENTES(textBox1.Text, CMBBUS.Text);
            dataGridView1.Columns["IDDIRECTORIO"].Visible = false;
            dataGridView1.Columns["ZONA"].Visible = false;

        }

        


        private void TXTELEFONOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CMBZONAS.Focus();
            }
        }

     

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            TXTCLIENTE.Text = dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
            TXTEMAIL.Text = dataGridView1.CurrentRow.Cells["EMAIL"].Value.ToString();
            TXTELEFONOS.Text = dataGridView1.CurrentRow.Cells["TELEFONO"].Value.ToString();
            CMBZONAS.Text = dataGridView1.CurrentRow.Cells["ZONA"].Value.ToString();
            CMBCLASI.Text = dataGridView1.CurrentRow.Cells["CLASIFICACION"].Value.ToString();
            TXTOBSERVACION.Text = dataGridView1.CurrentRow.Cells["OBSERVACION"].Value.ToString();
            LBLCLIENTE.Text = dataGridView1.CurrentRow.Cells["IDDIRECTORIO"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["ESTADO"].Value.ToString() == "ACT")
            { cmbestado.SelectedIndex = 0; }
            else { cmbestado.SelectedIndex = 1; }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXTCLIENTE.Text == "")
            {
                MessageBox.Show(this, "INDIQUE NOMBRE DEL CLIENTE A REGISTRAR", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                String MSJE = DIR.REGISTRAR_CLIENTE(CMBZONAS.Text, TXTCLIENTE.Text, TXTEMAIL.Text, TXTELEFONOS.Text, TXTOBSERVACION.Text, CMBCLASI.Text);
                if (MSJE == "CLIENTE AÑADIDO AL DIRECTORIO")
                {
                    MessageBox.Show(this, MSJE, "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FILTRADO_CLIENTES();
                    TXTCLIENTE.Clear();
                    TXTELEFONOS.Clear();
                    TXTEMAIL.Clear();
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
                MessageBox.Show(this, "NO SE AH SELECCIONADO NINGUN CLIENTE PARA MODIFICAR", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                Int32 ESTO;
                if (cmbestado.SelectedIndex == 0)
                { ESTO = 1; }
                else { ESTO = 0; }
                String MSJE = DIR.MODIFICAR_CLIENTE(Convert.ToInt32(LBLCLIENTE.Text), CMBZONAS.Text, TXTCLIENTE.Text, TXTEMAIL.Text, TXTELEFONOS.Text, ESTO, TXTOBSERVACION.Text, CMBCLASI.Text);

                MessageBox.Show(this, MSJE, "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);

                FILTRADO_CLIENTES();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FILTRADO_CLIENTES();
        }

        private void CMBBUS_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FILTRADO_CLIENTES();
        }
    }
}
