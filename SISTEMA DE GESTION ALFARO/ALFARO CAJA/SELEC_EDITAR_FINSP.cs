using System;
using System.Windows.Forms;
using LIBRERIA;
namespace ALFARO_CAJA
{
    public partial class SELEC_EDITAR_FINSP : Form
    {
        public SELEC_EDITAR_FINSP()
        {
            InitializeComponent();
        }
        ClsInspeccion insp = new ClsInspeccion();
        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }
        void buscar()
        {
            dataGridView1.DataSource = insp.VER_INSPECCION_X_CATEG(comboBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value);
            if (comboBox1.Text.Substring(0,3).Equals("SOL"))
            {
                dataGridView1.Columns["COND. DE ALMACENAMIENTO"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["COND. DE ALMACENAMIENTO"].Visible = false;

            }
        }
        private void SELEC_EDITAR_FINSP_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            STPC.Text = Environment.MachineName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Editar_Inspeccion EINS = new Editar_Inspeccion();
                EINS.lbltipo.Text = comboBox1.Text;
                EINS.lblcod.Text = dataGridView1.CurrentRow.Cells["COD"].Value.ToString();
                EINS.txtconcentracion.Text = dataGridView1.CurrentRow.Cells["CONCENTRACION"].Value.ToString();
                EINS.txtfactura.Text = dataGridView1.CurrentRow.Cells["FACTURA"].Value.ToString();
                EINS.txtforma.Text = dataGridView1.CurrentRow.Cells["F. PRESENTACION"].Value.ToString();
                EINS.txtguia.Text = dataGridView1.CurrentRow.Cells["GUIA"].Value.ToString();
                EINS.txtlote.Text = dataGridView1.CurrentRow.Cells["LOTE"].Value.ToString();
                EINS.txtnomprod.Text = dataGridView1.CurrentRow.Cells["PRODUCTO"].Value.ToString();
                EINS.txtproveedor.Text = dataGridView1.CurrentRow.Cells["PROVEEDOR"].Value.ToString();
                EINS.txtregsanitario.Text = dataGridView1.CurrentRow.Cells["REG. SANITARIO"].Value.ToString();
                EINS.dtpvcto.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["VCTO"].Value);
                EINS.dtpfecha.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["FECHA"].Value);
                EINS.nupmuestra.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CANT. MUESTREADA"].Value);
                EINS.nupcant.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CANTIDAD"].Value);
                EINS.npdcansoli.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CANT. SOLICITADA"].Value);
                EINS.txtcondalmacenarecep.Text = dataGridView1.CurrentRow.Cells["COND. DE ALMACENAMIENTO REC"].Value.ToString();
                EINS.txtobservacion.Text = dataGridView1.CurrentRow.Cells["OBSERVACION"].Value.ToString();
                EINS.TXTCONDALMACENAMIENTO.Text = dataGridView1.CurrentRow.Cells["COND. DE ALMACENAMIENTO"].Value.ToString();
                if (comboBox1.Text.Substring(0, 3).Equals("SOL"))
                {
                    EINS.lblcondicion.Visible = true;
                    EINS.TXTCONDALMACENAMIENTO.Visible = true;
                }
                EINS.MdiParent = this.ParentForm;
                if (Application.OpenForms["Editar_Inspeccion"] == null)
                {
                    EINS.Show();
                }

                EINS.FormClosed += EINS_FormClosed;
            }
            catch (Exception)
            {

             
            }
           
        }

        private void EINS_FormClosed(object sender, FormClosedEventArgs e)
        {
            buscar(); 
        }
    }
}
