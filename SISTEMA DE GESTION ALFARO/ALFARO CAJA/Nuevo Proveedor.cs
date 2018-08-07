using LIBRERIA;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Nuevo_Proveedor : Form
    {
        public Nuevo_Proveedor()
        {
            InitializeComponent();
        }
        ClsProveedor PV = new ClsProveedor();
        private void Nuevo_Proveedor_Load(object sender, EventArgs e)
        {

           
        }
        void LLENARDGV()
        {

            dataGridView1.DataSource = PV.llenar_prov();
            dataGridView1.Columns["idprovedor"].Visible = false;
        }

        void LLENARP()
        {
            comboBox1.DataSource = PV.llenar_CAT();
            comboBox1.DisplayMember = "NOMBRE";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PV.filtrar_prov(TXTFILTRAR.Text);
        }

   

        private void Nuevo_Proveedor_Load_1(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 0;
            LLENARP();
            LLENARDGV();
            STPC.Text = Environment.MachineName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXTDESCRIPCION.Text == "") { MessageBox.Show(this, "INGRESE DESCRIPCION", "GESADIV", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                string MSJE = PV.REG_PROVEEDOR(TXTDESCRIPCION.Text, TXTRUC1.Text, comboBox1.Text);
                MessageBox.Show(this, MSJE, "GESADIV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LLENARDGV();
            }
        }

        private void TXTRUC1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
