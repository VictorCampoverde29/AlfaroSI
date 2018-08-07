using LIBRERIA;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Consulta_de_Caja : Form
    {
        public Consulta_de_Caja()
        {
            InitializeComponent();
        }
        Clscaja CJ = new Clscaja();
        private void Consulta_de_Caja_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            STPC.Text = Environment.MachineName;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show(this,"INGRESE CODIGO DE CAJA PARA BUSCAR", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DGVDATA.DataSource = CJ.BUSCAR_CAJAS(Convert.ToInt32(textBox1.Text), STCODIGO.Text);
                }
            }
            else if (Char.IsDigit(e.KeyChar))
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (comboBox2.SelectedIndex == 2)
            {
                DGVDATA.DataSource = CJ.BUSCAR_CAJAS_MES(Convert.ToInt32(comboBox1.SelectedIndex) + 1,Convert.ToInt32(numericUpDown1.Value));
            }
            else
            {
                DGVDATA.DataSource = CJ.BUSCAR_CAJAS_MES_ESTADO(Convert.ToInt32(comboBox1.SelectedIndex) + 1, comboBox2.Text.Substring(0, 1), Convert.ToInt32(numericUpDown1.Value));
            }
        }

        private void DGVDATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String NOMBRE_ESTADO = "";
                Mantenimiento_Caja VEN = new Mantenimiento_Caja();
                VEN.MdiParent = this.ParentForm;
                VEN.Show();
                VEN.Text = "Consulta de Caja:";
                VEN.LBLCODIGO.Text = DGVDATA.CurrentRow.Cells["CODIGO"].Value.ToString();
                String ESTADO = DGVDATA.CurrentRow.Cells["ESTADO"].Value.ToString();
                if (ESTADO == "APERTURADA") { NOMBRE_ESTADO = "APERTURADA"; }
                else if (ESTADO == "LIQUIDADA") { NOMBRE_ESTADO = "LIQUIDADA"; }
                VEN.LBLESTADO.Text = NOMBRE_ESTADO;
                VEN.STCODIGO.Text = STCODIGO.Text;
                VEN.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                VEN.STPERFIL.Text = STPERFIL.Text;
                VEN.LBLNOMBRECAJA.Text = DGVDATA.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                VEN.LBLFECHA.Text = DGVDATA.CurrentRow.Cells["FECHA APERTURA"].Value.ToString().Substring(0,10);
                VEN.LBLAPERTURADO.Text = DGVDATA.CurrentRow.Cells["APERTURADO POR"].Value.ToString();
                VEN.DGVDATA.DataSource = CJ.Devolver_detalle_cajas_id(Convert.ToInt32(DGVDATA.CurrentRow.Cells["CODIGO"].Value.ToString()));
                VEN.DGVDATA.Columns["ID_DETALLE"].Visible = false;
                //VEN.panel2.Enabled = false;
                VEN.BTNCAMBIARESTADO.Visible = false;
                VEN.BTNLIQUIDAR.Visible = false;
                //VEN.lbl.Text = STCODIGO.Text;
                VEN.linkLabel3.Visible = false;
                double MONTOS = 0;
                for (int i = 0; i < VEN.DGVDATA.RowCount; i++)
                {
                    MONTOS = MONTOS + Convert.ToDouble( VEN.DGVDATA.Rows[i].Cells["MONTO"].Value);
                }
                VEN.LBLTOTALCONTEO.Text = "TOTAL DE ITEMS:" + VEN.DGVDATA.RowCount + " GASTO TOTAL:" + "S/." + MONTOS;

            }
            catch (Exception ex) { throw ex; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
