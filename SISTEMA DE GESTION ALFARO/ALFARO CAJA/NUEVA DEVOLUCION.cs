using System;
using System.Windows.Forms;
using LIBRERIA;

namespace ALFARO_CAJA
{
    public partial class NUEVA_DEVOLUCION : Form
    {
        public NUEVA_DEVOLUCION()
        {
            InitializeComponent();
        }
        CLSLINEA L = new CLSLINEA();
        CLSTRANSPORTE T = new CLSTRANSPORTE();
        CLSDEVOLUCION D = new CLSDEVOLUCION();
        public string VARIABLE;
        private void NUEVA_DEVOLUCION_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            STPC.Text = Environment.MachineName;
            LLENAR_LINEA();
            LLENAR_TRANSPORTISTA();
            CMBUM.SelectedIndex = 0;
            TXTFACTURA.Focus();
            MOSTRAR_RUC_DIRECCION();
            MOSTRAR_RUC_TRASNPORTE();
            TRAER_NUMERO_GUIA();
        }
        void LLENAR_TRANSPORTISTA()
        {
            CMBTRANSPORTISTA.DataSource = CLSTRANSPORTE.llenar_TRANSPORTISTA();
            CMBTRANSPORTISTA.DisplayMember = "NOMBRE";
            CMBTRANSPORTISTA.ValueMember = "IDTRANSPORTE";
        }
        void TRAER_NUMERO_GUIA()
        {
            String MSJE=D.Devolver_numero(STCODIGO.Text, STPC.Text);
            if (MSJE == "SIN PERMISOS" || MSJE=="000-000000")
            {

                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                LBLNUMERO.Text = MSJE;
            }
            else
            {
                LBLNUMERO.Text = MSJE;
            }
        }
        void LLENAR_LINEA()
        {
            comboBox1.DataSource = CLSLINEA.llenar_LINEAS();
            comboBox1.DisplayMember = "DESCRIPCION";
            comboBox1.ValueMember = "IDLINEA";
        }

      
        void REGISTRO_DETALLE(String UM,String DES, String CA, String LT, String cf, String mfc, String mmt, int CODIGO,String OB)
        {
            try
            {
                D.REGISTRO_DETALLE("", UM, DES, CA, LT, "", cf, mfc, mmt, CODIGO, OB);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
                TXTMOTIVO.Focus();
            }
        }

        private void TXTMOTIVO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTPROD.Focus();
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
        void MOSTRAR_RUC_DIRECCION()
        {
            L.DEVOLVER_RUC_DIRECCION(Convert.ToInt32(comboBox1.SelectedValue));
            LBLDIRECCION.Text = L.DIRECCION;
            LBLRUC.Text = L.RUC;

        }

        private void CMBTRANSPORTISTA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MOSTRAR_RUC_TRASNPORTE();
        }
        void MOSTRAR_RUC_TRASNPORTE()
        {
            T.DEVOLVER_RUC(Convert.ToInt32(CMBTRANSPORTISTA.SelectedValue));
            LBLRUCTRANSPORTE.Text = T.RUC;
        }

        private void DGVDATA_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (DGVDATA.RowCount == 0)
            {
                button2.Visible = false;
            }
            else
            {
                button2.Visible = true;
            }
        }

        private void DGVDATA_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            button2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        void LIMPIAR()
        {
            TXTFACTURA.Clear();
            TXTGUIA.Clear();
            CMBTRANSPORTISTA.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            TXTMOTIVO.Clear();
            TRAER_NUMERO_GUIA();
            DGVDATA.Rows.Clear();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TXTMOTIVO.Text = comboBox2.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel6.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel6.Visible = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                DGVDATA.Rows.Add("", textBox2.Text,"","","","","","","","");
                textBox2.Clear(); textBox2.Text = "-";
                panel6.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVDATA.Rows.Clear();
            TXTCAN.Clear();
            TXTFACTURA.Clear();
            TXTGUIA.Clear();
            TXTLOTE.Clear();
            TXTMOTIVO.Clear();
            TXTPROD.Clear();
            textBox2.Clear();
        }

        private void TXTPROD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Consulta_Articulos cons = new Consulta_Articulos();
                cons.MdiParent = this.ParentForm;
                cons.Show();
                cons.FormClosed += Cons_FormClosed;
               
            }
        }

        private void Cons_FormClosed(object sender, FormClosedEventArgs e)
        {
            Consulta_Articulos cons = new Consulta_Articulos();
            TXTPROD.Text = VariablesGlobales.Nombreprod;

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void TXTCANF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTCAN.Focus();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (TXTCANF.Text=="")
            {
                MessageBox.Show(this, "LA CANTIDAD FACTURADA NO PUEDE IR VACIA", "GESTION DE AREAS " + Application.ProductVersion);
                TXTCANF.Focus();
            }
            else if (TXTCAN.Text == "")
            {
                MessageBox.Show(this, "LA CANTIDAD A DEVOLVER NO PUEDE IR VACIA", "GESTION DE AREAS " + Application.ProductVersion);
                TXTCAN.Focus();
            }
            else if(Convert.ToInt32(TXTCANF.Text)< Convert.ToInt32(TXTCAN.Text))
            {
                MessageBox.Show(this, "LA CANTIDAD FACTURADA NO PUEDE SER MENOR A LA CANTIDAD A DEVOLVER", "GESTION DE AREAS " + Application.ProductVersion);
                TXTCANF.Focus();
            }
            else if (DGVDATA.RowCount == 9) { MessageBox.Show(this, "SOLO SE PERMITEN 9 ITEMS", "GESTION DE AREAS " + Application.ProductVersion); }
            else
                {
                    char m_fc,mm;
                String Ob;
                if (comboBox2.SelectedIndex==0)
                {
                    m_fc = 'X';mm = ' ';Ob = " FC";
                }
                else
                {
                    m_fc = ' '; mm = 'X'; Ob = " MT";
                }
                    int IS = Convert.ToInt32(TXTCANF.Text) - Convert.ToInt32(TXTCAN.Text);
                    DGVDATA.Rows.Add( CMBUM.Text, TXTPROD.Text, TXTLOTE.Text, TXTCANF.Text,TXTCAN.Text,IS,m_fc,mm,comboBox2.Text,Ob);
                    TXTCAN.Clear();TXTCANF.Clear();
                    TXTPROD.Clear(); TXTLOTE.Clear();
                    TXTPROD.Focus();
                }
          
        
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MOSTRAR_RUC_DIRECCION();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (TXTFACTURA.Text == "" && TXTGUIA.Text == "")
            {
                MessageBox.Show(this, "TIENE QUE INDICAR AL MENOS UN NUMERO DE REFERENCIA",  VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TXTMOTIVO.Text == "")
            {
                MessageBox.Show(this, "INDIQUE EL MOTIVO DE LA DEVOLUCION",VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(this, "GS:" + LBLNUMERO.Text + Environment.NewLine + "LINEA:" + comboBox1.Text + Environment.NewLine + "TRANSPORTE:" + CMBTRANSPORTISTA.Text + Environment.NewLine + "¿DESEA REGISTRAR LA DEVOLUCION?", VariablesGlobales.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    int MSJE = D.REGISTRO_DEV(TXTFACTURA.Text, TXTGUIA.Text, Convert.ToInt32(CMBTRANSPORTISTA.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue), STCODIGO.Text, LBLNUMERO.Text, "----", dateTimePicker1.Value);
                    if (MSJE == 0)
                    {
                        MessageBox.Show(this, "HUBO UN ERROR NO SE PUEDE REGISTRAR COMUNIQUESE CON EL AREA DE SISTEMAS", VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {

                        for (int i = 0; i < DGVDATA.RowCount; i++)
                        {
                            REGISTRO_DETALLE(DGVDATA.Rows[i].Cells["UNIDAD"].Value.ToString(), DGVDATA.Rows[i].Cells["PRODUCTO"].Value.ToString(), DGVDATA.Rows[i].Cells["CANTIDAD"].Value.ToString(), DGVDATA.Rows[i].Cells["LOTE"].Value.ToString(), DGVDATA.Rows[i].Cells["CANTFAC"].Value.ToString(), DGVDATA.Rows[i].Cells["MFC"].Value.ToString(), DGVDATA.Rows[i].Cells["MMT"].Value.ToString(), MSJE, DGVDATA.Rows[i].Cells["OB"].Value.ToString());
                        }
                        MessageBox.Show(this, "DEVOLUCION REGISTRADA N°:" + MSJE,VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LIMPIAR();

                    }

                }
            }
        }
    }
}
