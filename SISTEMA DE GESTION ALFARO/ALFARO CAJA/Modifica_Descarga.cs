
using System;
using System.Data;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class Modifica_Descarga : Form
    {
        public Modifica_Descarga()
        {
            InitializeComponent();
        }
        public String LINEA,TPT;
        CLSLINEA L = new CLSLINEA();
        CLSDV DV = new CLSDV();
        CLSDESCARGAS DESC = new CLSDESCARGAS();
        CLSTRANSPORTE TP = new CLSTRANSPORTE();
        void LLENAR_LINEA()
        {
            comboBox1.DataSource = CLSLINEA.llenar_LINEAS();
            comboBox1.DisplayMember = "DESCRIPCION";
            comboBox1.ValueMember = "IDLINEA";

            // cargo la lista de items para el autocomplete dle combobox
            comboBox1.AutoCompleteCustomSource = CLSLINEA.Autocomplete();
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        void LLENAR_TRANSPORTE()
        {
            comboBox2.DataSource = CLSTRANSPORTE.llenar_TRANSPORTISTA();
            comboBox2.DisplayMember = "NOMBRE";
            comboBox2.ValueMember = "IDTRANSPORTE";

            // cargo la lista de items para el autocomplete dle combobox
            comboBox2.AutoCompleteCustomSource = CLSTRANSPORTE.Autocomplete();
            comboBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void Modifica_Descarga_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            LLENAR_LINEA();
            LLENAR_TRANSPORTE();
            comboBox1.Text = LINEA;
            comboBox2.Text = TPT;
            comboBox3.SelectedIndex = 0;
            CARGAR_DETALLES();
            cambiar_etiq_bultos();
        }

        private void chktermos_CheckedChanged(object sender, EventArgs e)
        {
            if (chktermos.Checked == true)
            {
               nudtermos.Enabled = true;
                if(nudtermos.Value>0)
                {
                    cambiar_etiq_bultos();
                }
            }
            else
            {
                nudtermos.Enabled = false;
                cambiar_etiq_bultos();
            }
           
        }

        private void chktoneladas_CheckedChanged(object sender, EventArgs e)
        {
            if (chktoneladas.Checked == true)
            {
                nudtoneladas.Enabled = true;
                if (nudtoneladas.Value > 0)
                {
                    cambiar_etiq_bultos();
                }
            }
            else
            {
                nudtoneladas.Enabled = false;
                cambiar_etiq_bultos();
            }
          
        }


        private void chkcajas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcajas.Checked == true)
            {
                nudcajas.Enabled = true;
                if (nudcajas.Value > 0)
                {
                    cambiar_etiq_bultos();
                }
            }
            else
            {
                nudcajas.Enabled = false;
                cambiar_etiq_bultos();
            }
           
        }

        private void nudtermos_ValueChanged(object sender, EventArgs e)
        {
            if (nudtermos.Value==0)
            {
                chktermos.Checked = false;
            }
            cambiar_etiq_bultos();
        }

        private void nudtoneladas_ValueChanged(object sender, EventArgs e)
        {
            if (nudtoneladas.Value == 0)
            {
                chktoneladas.Checked = false;
            }
            cambiar_etiq_bultos();
        }

        private void nudcajas_ValueChanged(object sender, EventArgs e)
        {
            if (nudcajas.Value == 0)
            {
                chkcajas.Checked = false;
            }

            cambiar_etiq_bultos();
        }

        void cambiar_etiq_bultos()
        {
            if (chkcajas.Checked == true & chktoneladas.Checked == false & chktermos.Checked == false)
            {
                
                lbletibultos.Text = nudcajas.Value.ToString() + " CAJA(S)";
                txtcantidaduni.Text = 0 + "|" + nudcajas.Value.ToString() + "|" + 0;

            }
            else if (chkcajas.Checked == true & chktoneladas.Checked == true & chktermos.Checked == false)
            {
                if (nudtoneladas.Value == 0)
                {
                    lbletibultos.Text = nudcajas.Value.ToString() + " CAJA(S)";
                }
                else if (nudcajas.Value==0)
                {
                   lbletibultos.Text = nudtoneladas.Value.ToString() + " TONELADA(S)";

                }
                else
                {
                    lbletibultos.Text = nudtoneladas.Value.ToString() + " TONELADA(S)," + nudcajas.Value.ToString() + " CAJA(S)";
                }
                txtcantidaduni.Text = nudtoneladas.Value.ToString() + "|" + nudcajas.Value.ToString() + "|" + 0;

            }
            else if (chkcajas.Checked == true & chktoneladas.Checked == false & chktermos.Checked == true)
            {
                if (nudcajas.Value==0)
                {
                    lbletibultos.Text = nudtermos.Value.ToString() + " TERMO(S)";
                }
                else if (nudtermos.Value==0)
                {
                    lbletibultos.Text = nudcajas.Value.ToString() + " CAJA(S)";

                }
                else
                {
                    lbletibultos.Text = nudcajas.Value.ToString() + " CAJA(S)," + nudtermos.Value.ToString() + " TERMO(S)";

                }
                txtcantidaduni.Text = 0 + "|" + nudcajas.Value.ToString() + "|" + nudtermos.Value.ToString();

            }
            else if (chkcajas.Checked == false & chktoneladas.Checked == true & chktermos.Checked == true)
            {
                if (nudtoneladas.Value==0 & nudtermos.Value > 0)
                {
                    lbletibultos.Text =  nudtermos.Value.ToString() + " TERMO(S)";

                }
                else if(nudtermos.Value==0)
                {
                    lbletibultos.Text = nudtoneladas.Value.ToString() + " TONELADA(S)" ;
                }
                else if (nudtoneladas.Value == 0 & nudtermos.Value == 0)
                {
                    lbletibultos.Text = "----------";
                }
                else
                {
                    lbletibultos.Text = nudtoneladas.Value.ToString() + " TONELADA(S)," + nudtermos.Value.ToString() + " TERMO(S)";

                }
                txtcantidaduni.Text = nudtoneladas.Value.ToString() + "|" + 0 + "|" + nudtermos.Value.ToString();

            }
            else if (chkcajas.Checked == false & chktoneladas.Checked == true & chktermos.Checked == false)
            {
                if (nudtoneladas.Value==0)
                {
                    lbletibultos.Text = "----------";
                }
                else
                {
                    lbletibultos.Text = nudtoneladas.Value.ToString() + " TONELADA(S)";
                }
               
                txtcantidaduni.Text = nudtoneladas.Value.ToString() + "|" + 0 + "|" + 0;

            }
            else if (chkcajas.Checked == false & chktoneladas.Checked == false & chktermos.Checked == true)
            {
                if (nudtermos.Value==0)
                {
                    lbletibultos.Text = "----------";
                }
                else
                {
                    lbletibultos.Text = nudtermos.Value.ToString() + " TERMO(S)";

                }
                txtcantidaduni.Text = 0 + "|" + 0 + "|" + nudtermos.Value.ToString();

            }
            else if (chkcajas.Checked == true & chktoneladas.Checked == true & chktermos.Checked == true)
            {
                if (nudcajas.Value==0)
                {
                    lbletibultos.Text = nudtoneladas.Value.ToString() + " TONELADA(S)," + nudtermos.Value.ToString() + " TERMO(S)";

                }
                else if (nudtermos.Value==0)
                {
                    lbletibultos.Text = nudtoneladas.Value.ToString() + " TONELADA(S)," + nudcajas.Value.ToString() + " CAJA(S)" ;

                }
                else if (nudtoneladas.Value==0)
                {
                    lbletibultos.Text =  nudcajas.Value.ToString() + " CAJA(S)," + nudtermos.Value.ToString() + " TERMO(S)";

                }
                else
                {
                    lbletibultos.Text = nudtoneladas.Value.ToString() + " TONELADA(S)," + nudcajas.Value.ToString() + " CAJA(S)," + nudtermos.Value.ToString() + " TERMO(S)";

                }
                txtcantidaduni.Text = nudtoneladas.Value.ToString() + "|" + nudcajas.Value.ToString() + "|" + nudtermos.Value.ToString();

            }
            else
            {
                lbletibultos.Text = "----------";
                txtcantidaduni.Text = 0 + "|" + 0 + "|" + 0;

            }
        }
        void CARGAR_DETALLES()
        {
            dataGridView1.DataSource = DESC.llenar_PERSOnal_x_codigo(Convert.ToInt32(LBLNUMERO.Text));

        }

       

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridView1.RowCount == 0)
                {

                }
                else
                {
                    DESC.ELIMINAR_DETALLE_DESCARGA(dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString(),
                        Convert.ToInt32(LBLNUMERO.Text));
                    CARGAR_DETALLES();
                }
            }
        }

        private void TXTLICDNI_KeyPress(object sender, KeyPressEventArgs e)
        {



            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                String resultado = TP.DEV_PERSONAL_SEGUN_TRANSPORTE_X_LIC(TXTLICDNI.Text, Convert.ToInt32(comboBox2.SelectedValue));

                if (resultado.Equals("NO ENCONTRADO"))
                {
                    TXTLICDNI.Focus();
                }


                else if (TXTLICDNI.Text == "")
                {
                    MessageBox.Show(this, "NECESITA INDICAR EL DNI O LICENCIA",VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    String[] separados = resultado.Split('|');
                    lblcodpers.Text = separados[0];
                    TXTLICDNI.Text = separados[3];
                    TXTNOMBRE.Text = separados[2];
                    comboBox3.Text = separados[1];
                    TXTNOMBRE.Focus();

                }
            }
        }

          
        

        private void TXTNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
 
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
            if (TXTNOMBRE.Text == "")
            {
                MessageBox.Show(this, "NECESITA INDICAR EL NOMBRE", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (TXTLICDNI.Text == "")
            {
                MessageBox.Show(this, "NECESITA INDICAR EL DNI O LICENCIA",VariablesGlobales.Titulo , MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                    String rpta = "NO";
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells["DOCUMENTO"].Value.ToString().Equals(TXTLICDNI.Text)|| dataGridView1.Rows[i].Cells["NOMBRE"].Value.ToString().Equals(TXTNOMBRE.Text))
                        {
                            rpta = "SI";
                        }
                    }
                    if (rpta.Equals("NO"))
                    {
                        DESC.REGISTRAR_DETALLE_DESCARGA(TXTNOMBRE.Text, TXTLICDNI.Text, comboBox3.Text, Convert.ToInt32(LBLNUMERO.Text));
                        TXTNOMBRE.Clear();
                        TXTLICDNI.Clear();
                        TXTNOMBRE.Focus();
                        CARGAR_DETALLES();
                    }
                    else
	                {
                        MessageBox.Show(this, "YA TENEMOS UN PERSONAL CON LOS DATOS INGRESADOS EN EL DETALLE",VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }

                }
        }
       
    }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = CLSLINEA.llenar_LINEAS();
            DataTable dt2 = CLSTRANSPORTE.llenar_TRANSPORTISTA();
            String BIENLINEA = "NO";
            String BIENTRANSP = "NO";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow DR = dt.Rows[i];
                if (DR["DESCRIPCION"].ToString().Equals(comboBox1.Text))
                {
                    BIENLINEA = "SI";
                }
            }

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                DataRow DR = dt2.Rows[i];
                if (DR["NOMBRE"].ToString().Equals(comboBox2.Text))
                {
                    BIENTRANSP = "SI";
                }
            }


            if (BIENLINEA.Equals("NO"))
            {
                MessageBox.Show(this,"EL LABORATORIO ELEGIDO ES INCORRECTO",VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else if (BIENTRANSP.Equals("NO"))
            {
                MessageBox.Show("EL TRANSPORTE ELEGIDO ES INCORRECTO", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtcantidaduni.Text == "0|0|0")

            {
                MessageBox.Show(this, "NECESITA INDICAR EL DETALLE DE CARGA",VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show(this, "NO PUEDE EDITAR SIN REGISTROS DEL PERSONAL DE TRANSPORTE",VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    TP.EDITA_PER_TRA(dataGridView1.Rows[i].Cells["NOMBRE"].Value.ToString(),
                      dataGridView1.Rows[i].Cells["DOCUMENTO"].Value.ToString(),
                      dataGridView1.Rows[i].Cells["TIPO"].Value.ToString(),
                      Convert.ToInt32(comboBox2.SelectedValue)
                      );

                }
                String msje = DESC.MODIFICAR_DESCARGA(Convert.ToInt32(LBLNUMERO.Text),
                   TXTOBSER.Text, comboBox2.Text, lbletibultos.Text,txtcantidaduni.Text,
                   dateTimePicker1.Value, dateTimePicker2.Value, comboBox1.Text);
                MessageBox.Show(this, msje, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            dataGridView2.DataSource = TP.PERSONAL_SEGUN_TRANSPORTE(Convert.ToInt32(comboBox2.SelectedValue));
            dataGridView2.Columns["CODIGO"].Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel4.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblcodpers.Text = dataGridView2.CurrentRow.Cells["CODIGO"].Value.ToString();
            TXTLICDNI.Text = dataGridView2.CurrentRow.Cells["DNI/LIC"].Value.ToString();
            TXTNOMBRE.Text = dataGridView2.CurrentRow.Cells["NOMBRE"].Value.ToString();
            comboBox3.Text = dataGridView2.CurrentRow.Cells["FUNCION"].Value.ToString();
            panel4.Visible = false;
            TXTNOMBRE.Focus();
        }

        

       
    }
}
