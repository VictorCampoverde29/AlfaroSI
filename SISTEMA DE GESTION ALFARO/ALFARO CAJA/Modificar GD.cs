using LIBRERIA;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Modificar_GD : Form
    {
        public Modificar_GD()
        {
            InitializeComponent();
        }
        CLSDEVOLUCION DV = new CLSDEVOLUCION();
        CLSLINEA L = new CLSLINEA();
        CLSTRANSPORTE T = new CLSTRANSPORTE();
        public int NUMERO;
        public string NUMERO_GUIA;
        void LLENAR_DETALLES()
        {
            DGVDATA.DataSource = DV.llenar_Detalles_Modificar(NUMERO);
            DGVDATA.Columns["CODIGO"].Visible = false;
            DGVDATA.Columns["MOTIVO_FC"].Visible = false;
            DGVDATA.Columns["MOTIVO_M"].Visible = false;

        }
        void DEVOLVER_DATOS_GUIA()
        {
            dataGridView1.DataSource = DV.REPORTE_BUSQ_X_NUMERO(NUMERO_GUIA);
            TXTNUMERO.Text = dataGridView1.Rows[0].Cells["NUMERO_GUIA"].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[0].Cells["ESTADO"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["FECHA"].Value);
            comboBox1.Text = dataGridView1.Rows[0].Cells["LINEA"].Value.ToString();
            dtpfechaingm.Value =Convert.ToDateTime( dataGridView1.Rows[0].Cells["FECHA_INGRESO_MERCADERIA"].Value);
            CMBTRANSPORTISTA.Text = dataGridView1.Rows[0].Cells["TRANSPORTISTA"].Value.ToString();
            MOSTRAR_RUC_DIRECCION();
            MOSTRAR_RUC_TRASNPORTE();
            TXTFACTURA.Text = dataGridView1.Rows[0].Cells["RFT"].Value.ToString();
            TXTGUIA.Text = dataGridView1.Rows[0].Cells["RGUIA"].Value.ToString();

        }
        void LLENAR_LINEA()
        {
            comboBox1.DataSource = CLSLINEA.llenar_LINEAS();
            comboBox1.DisplayMember = "DESCRIPCION";
            comboBox1.ValueMember = "IDLINEA";
        }

        void LLENAR_TRANSPORTISTA()
        {
            CMBTRANSPORTISTA.DataSource = CLSTRANSPORTE.llenar_TRANSPORTISTA();
            CMBTRANSPORTISTA.DisplayMember = "NOMBRE";
            CMBTRANSPORTISTA.ValueMember = "IDTRANSPORTE";
        }
        void MOSTRAR_RUC_TRASNPORTE()
        {
            T.DEVOLVER_RUC(Convert.ToInt32(CMBTRANSPORTISTA.SelectedValue));
            LBLRUCTRANSPORTE.Text = T.RUC;
        }
        void MOSTRAR_RUC_DIRECCION()
        {
            L.DEVOLVER_RUC_DIRECCION(Convert.ToInt32(comboBox1.SelectedValue));
            LBLDIRECCION.Text = L.DIRECCION;
            LBLRUC.Text = L.RUC;

        }
        private void TXTFACTURA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTGUIA.Focus();
            }
        }

        private void TXTGUIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
               
            }
        }

   

        private void TXTPROD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTLOTE.Focus();
            }
        }

        private void CMBUM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTCANF.Focus();
            }
        }

        private void TXTLOTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CMBUM.Focus();
            }
        }

        private void TXTCAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                comboBox2.Focus();
            }
        }
        private void Modificar_GD_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            CMBUM.SelectedIndex = 0;
            LLENAR_LINEA();
            LLENAR_TRANSPORTISTA();
            LLENAR_DETALLES();
            DEVOLVER_DATOS_GUIA();
            STPC.Text = Environment.MachineName;
        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
          

        }

        private void TXTPROD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                DialogResult resultado = new DialogResult();
                Consulta_Articulos cons = new Consulta_Articulos();
                resultado = cons.ShowDialog();
                if (resultado == DialogResult.OK)
                {

                    TXTPROD.Text = cons.nombrepro;
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "REGISTRADA") { comboBox3.ForeColor = Color.Green; }
            else if (comboBox3.Text == "TRASLADADA") { comboBox3.ForeColor = Color.Blue; }
            else { comboBox3.ForeColor = Color.Red; }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MOSTRAR_RUC_DIRECCION();
        }

        private void CMBTRANSPORTISTA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MOSTRAR_RUC_TRASNPORTE();
        }

        private void DGVDATA_KeyDown(object sender, KeyEventArgs e)
        {
            if (DGVDATA.RowCount == 0)
            { }
            else
            {
                if (e.KeyValue == (char)Keys.Delete)
                {
                    MessageBox.Show(this,DV.ELIMINAR_ITEM(Convert.ToInt32(DGVDATA.CurrentRow.Cells["CODIGO"].Value)),VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LLENAR_DETALLES();
                }
            }
        }

        private void TXTNUMERO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTFACTURA.Focus();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
              
              DV.REGISTRO_DETALLE("","", textBox2.Text,
                    "", "","","","","", NUMERO,"");
                LLENAR_DETALLES();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.Visible = false;
        }

        private void TXTCANF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTCAN.Focus();
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXTCANF.Text == "")
            {
                MessageBox.Show(this, "LA CANTIDAD FACTURADA NO PUEDE IR VACIA", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTCANF.Focus();
            }
            else if (TXTCAN.Text == "")
            {
                MessageBox.Show(this, "LA CANTIDAD A DEVOLVER NO PUEDE IR VACIA", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTCAN.Focus();
            }
            else if (Convert.ToInt32(TXTCANF.Text) < Convert.ToInt32(TXTCAN.Text))
            {
                MessageBox.Show(this, "LA CANTIDAD FACTURADA NO PUEDE SER MENOR A LA CANTIDAD A DEVOLVER", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTCANF.Focus();
            }
            else if (DGVDATA.RowCount == 9) { MessageBox.Show(this, "SOLO SE PERMITEN 9 ITEMS", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                String m_fc, mm;
                String Ob;
                if (comboBox2.SelectedIndex == 0)
                {
                    m_fc = "X"; mm = " "; Ob = " FC";
                }
                else
                {
                    m_fc = " "; mm = "X"; Ob = " MT";
                }

                DV.REGISTRO_DETALLE("", CMBUM.Text, TXTPROD.Text, TXTCAN.Text, TXTLOTE.Text, "", TXTCANF.Text, m_fc, mm, NUMERO, Ob);
                TXTCAN.Clear();
                TXTPROD.Clear(); TXTLOTE.Clear();
                TXTPROD.Focus();
                LLENAR_DETALLES();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TXTFACTURA.Text == "" && TXTGUIA.Text == "")
            {
                MessageBox.Show(this, "TIENE QUE INDICAR AL MENOS UN NUMERO DE REFERENCIA", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult result = MessageBox.Show("GS:" + TXTNUMERO.Text + Environment.NewLine + "LINEA:" + comboBox1.Text + Environment.NewLine + "TRANSPORTE:" + CMBTRANSPORTISTA.Text + Environment.NewLine + "¿DESEA MODIFICAR LA DEVOLUCION?", VariablesGlobales.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    String ES;
                    if (comboBox3.SelectedIndex == 0) { ES = "N"; }
                    else if (comboBox3.SelectedIndex == 1) { ES = "A"; }
                    else { ES = "T"; }
                    MessageBox.Show(this, DV.EDITAR_DEV(NUMERO, dateTimePicker1.Value, TXTFACTURA.Text, TXTGUIA.Text, ES, Convert.ToInt32(CMBTRANSPORTISTA.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue), STCODIGO.Text, TXTNUMERO.Text, "", dtpfechaingm.Value), VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }

            }
        }
    }
}
