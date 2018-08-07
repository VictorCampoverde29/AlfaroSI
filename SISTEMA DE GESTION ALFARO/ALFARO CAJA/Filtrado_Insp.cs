using System;
using System.Windows.Forms;
using LIBRERIA;
namespace ALFARO_CAJA
{
    public partial class Filtrado_Insp : Form
    {
        public Filtrado_Insp()
        {
            InitializeComponent();
        }
        ClsInspeccion INSPE = new ClsInspeccion();
        private void Filtrado_Insp_Load(object sender, EventArgs e)
        {
            textBox1.Select();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = INSPE.FILTRADO_PRODUCTOS(textBox1.Text,lblcate.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VariablesGlobales.PRODUCTO=dataGridView1.CurrentRow.Cells["PRODUCTO"].Value.ToString();
            VariablesGlobales.LOTE=dataGridView1.CurrentRow.Cells["LOTE"].Value.ToString();
            VariablesGlobales.VTO=Convert.ToDateTime(dataGridView1.CurrentRow.Cells["VTO"].Value.ToString());
            VariablesGlobales.REG_SANITARIO= dataGridView1.CurrentRow.Cells["REG SANITARIO"].Value.ToString();
            VariablesGlobales.FPRESENT = dataGridView1.CurrentRow.Cells["FORMA DE PRESENTACION"].Value.ToString();
            VariablesGlobales.CONCENTRACION = dataGridView1.CurrentRow.Cells["CONCENTRACION"].Value.ToString();
            this.Close();
        }
    }
}
