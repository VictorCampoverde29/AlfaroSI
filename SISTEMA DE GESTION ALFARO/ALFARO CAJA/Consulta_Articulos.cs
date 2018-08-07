using System;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class Consulta_Articulos : Form
    {
        ClsArticulo ARTI = new ClsArticulo();
        public String codigo,nombrepro;
        public Consulta_Articulos()
        {
            InitializeComponent();
        }
        
        private void Consulta_Articulos_Load(object sender, EventArgs e)
        {
            txttexto.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txttexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar==(int)Keys.Enter)
            {
                dataGridView1.DataSource = ARTI.Devuelve_Datos_Por_Nombre('N', txttexto.Text);
                dataGridView1.Columns["ESTADO"].Visible = false;
                if (dataGridView1.RowCount>0)
                {
                    dataGridView1.Focus();
                }
            }
        }

        private void txttexto_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            if ((int)e.KeyValue == (int)Keys.Enter)
            {
                e.SuppressKeyPress = true;
                NUEVA_DEVOLUCION nd = new NUEVA_DEVOLUCION();
                VariablesGlobales.Nombreprod= dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                VariablesGlobales.CodAlfa = dataGridView1.CurrentRow.Cells["cod_alfa"].Value.ToString();
                codigo = dataGridView1.CurrentRow.Cells["cod_alfa"].Value.ToString();
                nombrepro = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
              Close();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Consulta_Articulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
  }

