using LIBRERIA;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class FACTURAR_X_TRABAJADOR : Form
    {
        public FACTURAR_X_TRABAJADOR()
        {
            InitializeComponent();
        }
        Clsarmador A = new Clsarmador();
        CLSPERDIDA P = new CLSPERDIDA();
        private void FACTURAR_X_TRABAJADOR_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            comboBox1.SelectedIndex = 0;
            PERDIDAS();
        }
        void PERDIDAS()
        {
            dataGridView1.DataSource = P.DEVOLVER_ARMADOR_FACT(Convert.ToChar(comboBox1.Text.ToString().Substring(0,1)),dateTimePicker1.Value,dateTimePicker2.Value);
            dataGridView1.Columns["CODI"].Visible = false;
        }
      
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Cuadro_facturar VEN = new Cuadro_facturar();
            VEN.numero = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CODI"].Value.ToString());
            VEN.TXTCDALFA.Text = dataGridView1.CurrentRow.Cells["COD_ALFA"].Value.ToString();
            VEN.TXTPROD.Text = dataGridView1.CurrentRow.Cells["PRODUCTO"].Value.ToString();
            VEN.TXTLOTE.Text = dataGridView1.CurrentRow.Cells["LOTE"].Value.ToString();
            VEN.dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["VCTO"].Value.ToString());
            VEN.TXTMOTIVO.Text= dataGridView1.CurrentRow.Cells["MOTIVO"].Value.ToString();
            VEN.TXTOBS.Text= dataGridView1.CurrentRow.Cells["OBSERVACION"].Value.ToString();
            VEN.NUMEROS.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CANTIDAD"].Value.ToString());
            VEN.comboBox2.Text= dataGridView1.CurrentRow.Cells["AREA"].Value.ToString();
            VEN.comboBox3.Text = comboBox1.Text;
            VEN.STCODIGO.Text = STCODIGO.Text;
            VEN.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
            VEN.STPERFIL.Text = STPERFIL.Text;
            VEN.MdiParent = this.ParentForm;            
            VEN.Show();
            VEN.FormClosed += VEN_FormClosed;
           
           
        }

        private void VEN_FormClosed(object sender, FormClosedEventArgs e)
        {
            PERDIDAS();
        }

        private void CMBARMADOR_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PERDIDAS();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                String MSJE = P.ELIMINAR(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CODI"].Value.ToString()));
                MessageBox.Show(this, MSJE, VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
                PERDIDAS();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "SELECCIONE PERDIDA ELIMINAR", VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        
        }
    }
}
