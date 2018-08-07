using LIBRERIA;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Elije_Caja : Form
    {
        public Elije_Caja()
        {
            InitializeComponent();
        }

        private void Elije_Caja_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
        }
        Clscaja CJ = new Clscaja();
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show(this, "INGRESE CODIGO DE CAJA PARA BUSCAR", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DGVDATA.DataSource = CJ.BUSCAR_CAJAS(Convert.ToInt32(textBox1.Text), STCODIGO.Text);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "NO EXISTE NINGUNA CAJA CON EL CODIGO INGRESADO", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                VEN.STPERFIL.Text = STPERFIL.Text;
                VEN.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                VEN.LBLCODIGO.Text = DGVDATA.CurrentRow.Cells["CODIGO"].Value.ToString();
                String ESTADO = DGVDATA.CurrentRow.Cells["ESTADO"].Value.ToString();
                if (ESTADO == "APERTURADA") { NOMBRE_ESTADO = "APERTURADA"; VEN.BTNLIQUIDAR.Visible = true; VEN.linkLabel3.Visible = true; }
                else if (ESTADO == "LIQUIDADA") { NOMBRE_ESTADO = "LIQUIDADA"; VEN.BTNCAMBIARESTADO.Visible = true; VEN.linkLabel3.Visible = false; VEN.TXTMONTO.Visible = false; }
                VEN.LBLESTADO.Text = NOMBRE_ESTADO;
                VEN.STCODIGO.Text = STCODIGO.Text;
                VEN.LBLNOMBRECAJA.Text = DGVDATA.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                VEN.LBLFECHA.Text = DGVDATA.CurrentRow.Cells["FECHA APERTURA"].Value.ToString().Substring(0,10);
                VEN.LBLAPERTURADO.Text = DGVDATA.CurrentRow.Cells["APERTURADO POR"].Value.ToString();
                VEN.DGVDATA.DataSource = CJ.Devolver_detalle_cajas_id(Convert.ToInt32(DGVDATA.CurrentRow.Cells["CODIGO"].Value.ToString()));
                VEN.DGVDATA.Columns["ID_DETALLE"].Visible = false;
                double MONTOS = 0;
                for (int i = 0; i < VEN.DGVDATA.RowCount; i++)
                {
                    MONTOS = MONTOS + Convert.ToDouble(VEN.DGVDATA.Rows[i].Cells["MONTO"].Value);
                }
                VEN.LBLTOTALCONTEO.Text = "TOTAL DE ITEMS:" + VEN.DGVDATA.RowCount + " GASTO TOTAL:" + "S/." + MONTOS;

            }
            catch (Exception ex) { }


        }
    }
}
