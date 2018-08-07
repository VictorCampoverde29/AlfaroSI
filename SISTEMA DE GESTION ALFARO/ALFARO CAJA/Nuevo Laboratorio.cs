using LIBRERIA;

using System;

using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Nuevo_Laboratorio : Form
    {
        public Nuevo_Laboratorio()
        {
            InitializeComponent();
        }
        CLSLINEA L = new CLSLINEA();
        Clsarmador ARMA = new Clsarmador();
        private void Nuevo_Laboratorio_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            TXTCOD.Focus();
            llenar_lineas();
        }
        void llenar_lineas()
        {
            dataGridView1.DataSource = L.llenar_LINEAS_mantenimiento();
        }
        private void TXTCOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }


            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            checkBox1.Checked = false;
            TXTCOD.Text = dataGridView1.CurrentRow.Cells["NUMERO"].Value.ToString();
            TXTCOD.Enabled = false;
            textBox1.Text = dataGridView1.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
            TXTRUC.Text = dataGridView1.CurrentRow.Cells["RUC"].Value.ToString();
            TXTDIRECCION.Text = dataGridView1.CurrentRow.Cells["DIRECCION"].Value.ToString();
        }

        private void TXTCOD_TextChanged(object sender, EventArgs e)
        {
            //if (TXTCOD.Text != "---")
            //{
            //    button1.Visible = true;
            //}
            //else
            //{
            //    button1.Visible = false;
            //}
        }

        void LIMPIA()
        {
            TXTCOD.Text = "---";
            TXTDIRECCION.Clear();
            TXTRUC.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (TXTCOD.Text == "---")
            {
                MessageBox.Show(this, "SELECCIONE UNA LINEA A MODIFICAR", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(L.MOD_LINEA(textBox1.Text, Convert.ToInt32(TXTCOD.Text), TXTRUC.Text, TXTDIRECCION.Text));
                llenar_lineas();
                LIMPIA();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string NOMBRE = textBox1.Text;
            if (TXTCOD.Text == "")
            {
                MessageBox.Show(this, "EL CODIGO NO PUEDE ESTAR VACIO", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if(TXTCOD.Text == "---")
        	{
                MessageBox.Show(this, "NECESITA INDICAR UN CODIGO VALIDO", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (NOMBRE == "")
            {
                MessageBox.Show(this, "INGRESE DESCRIPCION", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (TXTRUC.Text == "")
            {
                MessageBox.Show(this, "INGRESE RUC", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                String MSJE = L.REG_LINEA(textBox1.Text, Convert.ToInt32(TXTCOD.Text), TXTRUC.Text, TXTDIRECCION.Text);
                MessageBox.Show(this, MSJE, "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenar_lineas();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                button1.Visible = true;
                button2.Visible = false;
                LIMPIA();
                TXTCOD.Enabled = true;
            }
            else
            {
                button1.Visible = false;
                button2.Visible = true;
                LIMPIA();
                TXTCOD.Enabled = false;
            }
        }
    }
}
