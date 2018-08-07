
using System;
using System.Drawing;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class CONSULTA_AGREGADOS_INVENTARIO : Form
    {
        public CONSULTA_AGREGADOS_INVENTARIO()
        {
            InitializeComponent();
        }
        CLSINV INVE = new CLSINV();
        private void CONSULTA_AGREGADOS_INVENTARIO_Load(object sender, EventArgs e)
        {
            CMBCATEGORIA.SelectedIndex = 0;
            LLENAR_AREAS();
        }
        void LLENAR_AREAS()
        {
            CMBAREA.DataSource = INVE.LLENAR_AREAS();
            CMBAREA.DisplayMember = "descripcion";
            CMBAREA.ValueMember = "idarea_inventario";
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = INVE.VER_PROD_INVENTARIO_ST(2, CMBCATEGORIA.Text, Convert.ToInt32(LBLIDINV.Text));
            dataGridView1.Columns["iddet_inv_area"].Visible = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[6, i].Value.ToString() == "POR MANTENIMIENTO")
                {
                    dataGridView1[6, i].Style.ForeColor = Color.Red;
                }
                else if (dataGridView1[6, i].Value.ToString() == "OPERATIVO")
                {
                    dataGridView1[6, i].Style.ForeColor = Color.Green;
                }
                else
                {
                    dataGridView1[6, i].Style.ForeColor = Color.Black;
                }
            }
        }
        void busqxnombre()
        {
            dataGridView1.DataSource = INVE.VER_PROD_INVENTARIO_ST(3, TXTPRODUCTO.Text, Convert.ToInt32(LBLIDINV.Text));
            dataGridView1.Columns["iddet_inv_area"].Visible = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[6, i].Value.ToString() == "POR MANTENIMIENTO")
                {
                    dataGridView1[6, i].Style.ForeColor = Color.Red;
                }
                else if (dataGridView1[6, i].Value.ToString() == "OPERATIVO")
                {
                    dataGridView1[6, i].Style.ForeColor = Color.Green;
                }
                else
                {
                    dataGridView1[6, i].Style.ForeColor = Color.Black;
                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            busqxnombre();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = INVE.VER_PROD_INVENTARIO_ST(4, TXTMARCA.Text, Convert.ToInt32(LBLIDINV.Text));
            dataGridView1.Columns["iddet_inv_area"].Visible = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[6, i].Value.ToString() == "POR MANTENIMIENTO")
                {
                    dataGridView1[6, i].Style.ForeColor = Color.Red;
                }
                else if (dataGridView1[6, i].Value.ToString() == "OPERATIVO")
                {
                    dataGridView1[6, i].Style.ForeColor = Color.Green;
                }
                else
                {
                    dataGridView1[6, i].Style.ForeColor = Color.Black;
                }
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = INVE.VER_PROD_INVENTARIO_ST(5, CMBAREA.SelectedValue.ToString(), Convert.ToInt32(LBLIDINV.Text));
            dataGridView1.Columns["iddet_inv_area"].Visible = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1[6, i].Value.ToString() == "POR MANTENIMIENTO")
                {
                    dataGridView1[6, i].Style.ForeColor = Color.Red;
                }
                else if (dataGridView1[6, i].Value.ToString() == "OPERATIVO")
                {
                    dataGridView1[6, i].Style.ForeColor = Color.Green;
                }
                else
                {
                    dataGridView1[6, i].Style.ForeColor = Color.Black;
                }
            }
        }

        private void lblquitar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show(this, "No hay Datos que eliminar", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                String msje = INVE.ELIMINA_PROD_INV_ST(Convert.ToInt32(dataGridView1.CurrentRow.Cells["iddet_inv_area"].Value));
                MessageBox.Show(this, msje,VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                busqxnombre();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
