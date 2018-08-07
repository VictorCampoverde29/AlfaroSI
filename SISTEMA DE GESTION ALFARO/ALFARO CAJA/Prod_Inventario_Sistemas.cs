using System;
using System.Drawing;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class Prod_Inventario_Sistemas : Form
    {
        public Prod_Inventario_Sistemas()
        {
            InitializeComponent();
        }
        CLSINV INVE = new CLSINV();
        private void Prod_Inventario_Sistemas_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            VER_INV_ACTIVOS();
            LLENAR_AREAS();
            CMBCATEGORIA.SelectedIndex = 0;
            LLENAPROD();
            CANTIDAD_REGISTROS();
            TXTPRODUCTO.Focus();
            cmbestado.SelectedIndex = 0;
        }
        void LLENAPROD()
        {
            dataGridView1.DataSource = INVE.VER_PROD_INVENTARIO_ST(1,"", Convert.ToInt32(CMBINVENTARIO.SelectedValue));
            dataGridView1.Columns["iddet_inv_area"].Visible = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if(dataGridView1[7,i].Value.ToString()=="POR MANTENIMIENTO")
                {
                    dataGridView1[7,i].Style.ForeColor = Color.Red;
                }
                else if (dataGridView1[7, i].Value.ToString() == "OPERATIVO")
                {
                    dataGridView1[7, i].Style.ForeColor = Color.Green;
                }
                else
                {
                    dataGridView1[6, i].Style.ForeColor = Color.Black;
                }
            }
        }
        void VER_INV_ACTIVOS()
        {
            CMBINVENTARIO.DataSource = INVE.llenar_INVENTARIOS_ACTIVOS_SISTEMAS();
            CMBINVENTARIO.DisplayMember = "NOMBRE";
            CMBINVENTARIO.ValueMember = "idinventario";
        }
        void LLENAR_AREAS()
        {
            CMBAREA.DataSource = INVE.LLENAR_AREAS();
            CMBAREA.DisplayMember = "descripcion";
            CMBAREA.ValueMember = "idarea_inventario";
        }
        void CANTIDAD_REGISTROS()
        {
            int total = dataGridView1.RowCount;
            if (total>0)
            {
                LBLTOTALREGISTROS.Text = total + " REGISTROS";
                lblquitar.Visible = true;
            }
            
        }

        private void TXTPRODUCTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTSERIE.Focus();
            }
        }

        private void CMBCATEGORIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTPRODUCTO.Focus();
            }
        }

        private void TXTSERIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTMARCA.Focus();
            }
        }

        private void TXTMARCA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CMBAREA.Focus();
            }
        }

        private void CMBAREA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                NPDCANTIDAD.Focus();
            }
        }

        private void NPDCANTIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                cmbestado.Focus();
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CMBINVENTARIO.Items.Count==0)
            {
                MessageBox.Show(this, "No cuenta con ningun inventario de Sistemas Activo", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (TXTPRODUCTO.Text == "")
            {
                MessageBox.Show(this, "Indique Nombre del Producto", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTPRODUCTO.Focus();
            }
            else if (TXTMARCA.Text=="")
            {
                MessageBox.Show(this, "Indique la marca del Producto", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTMARCA.Focus(); 
            }
            else if (TXTSERIE.Text == "")
            {
                MessageBox.Show(this, "Indique la Serie del Producto", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTSERIE.Focus();
            }
            else
            {
                String MSJE = INVE.NUEVO_PROD_SISTEMAS(TXTPRODUCTO.Text, Convert.ToInt32(NPDCANTIDAD.Value), CMBCATEGORIA.Text, TXTMARCA.Text, TXTSERIE.Text, TXTOBSV.Text, cmbestado.Text,
                    Convert.ToInt32(CMBAREA.SelectedValue), Convert.ToInt32(CMBINVENTARIO.SelectedValue));
                MessageBox.Show(this, MSJE, "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTPRODUCTO.Clear();
                NPDCANTIDAD.Value = 1;
                TXTMARCA.Clear();
                TXTSERIE.Clear();
                TXTOBSV.Clear();
                TXTPRODUCTO.Focus();
                LLENAPROD();
                CANTIDAD_REGISTROS();
            }


            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbestado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTOBSV.Focus();
            }
        }

        private void TXTOBSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                linkLabel2.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                TXTSERIE.Text = "--";
            }
            else
            {
                TXTSERIE.Text = "";
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void LBLTOTALREGISTROS_Click(object sender, EventArgs e)
        {

        }

        private void lblquitar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String msje = INVE.ELIMINA_PROD_INV_ST(Convert.ToInt32(dataGridView1.CurrentRow.Cells["iddet_inv_area"].Value));
            MessageBox.Show(this, msje, "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);
            LLENAPROD();
            CANTIDAD_REGISTROS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CMBINVENTARIO.Items.Count == 0)
            {
                MessageBox.Show(this, "No cuenta con ningun inventario de Sistemas Activo", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                CONSULTA_AGREGADOS_INVENTARIO VEN = new CONSULTA_AGREGADOS_INVENTARIO();
                VEN.MdiParent = this.ParentForm;
                VEN.LBLIDINV.Text = CMBINVENTARIO.SelectedValue.ToString();
                VEN.Show();
            }
        }

        private void CMBAREA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
