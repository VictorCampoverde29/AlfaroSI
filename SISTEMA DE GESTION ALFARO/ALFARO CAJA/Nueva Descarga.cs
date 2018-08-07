using LIBRERIA;
using System;
using System.Data;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Nueva_Descarga : Form
    {
        public Nueva_Descarga()
        {
            InitializeComponent();
        }
        CLSLINEA L = new CLSLINEA();
        CLSDV DV = new CLSDV();
        CLSDESCARGAS DESC = new CLSDESCARGAS();
        CLSTRANSPORTE TP = new CLSTRANSPORTE();
        private void Nueva_Descarga_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            comboBox3.SelectedIndex = 0;
            LLENAR_LINEA();
            LLENARNUMERO();
            LLENAR_TRANSPORTE();
            cambiar_etiq_bultos();
            comboBox1.Select();
            comboBox1.Focus();
        }
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
        void LLENARNUMERO()
        {
            LBLNUMERO.Text = DV.DEVOLVER_NUMERO() + 1 + "";
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        void cambiar_etiq_bultos()
        {
            if (chkcajas.Checked == true & chktoneladas.Checked==false & chktermos.Checked==false)
            {
                lbletibultos.Text = nudcajas.Value.ToString() + " CAJA(S)";
                lblnumerocant.Text = 0 + "|" + nudcajas.Value.ToString() + "|" + 0;

            }
            else if (chkcajas.Checked == true & chktoneladas.Checked == true & chktermos.Checked == false)
            {
                lbletibultos.Text =nudtoneladas.Value.ToString()+" TONELADA(S),"+ nudcajas.Value.ToString() + " CAJA(S)";
                lblnumerocant.Text = nudtoneladas.Value.ToString() + "|" + nudcajas.Value.ToString() + "|" + 0;

            }
            else if (chkcajas.Checked == true & chktoneladas.Checked == false & chktermos.Checked == true)
            {
                lbletibultos.Text = nudcajas.Value.ToString() + " CAJA(S),"+nudtermos.Value.ToString()+" TERMO(S)";
                lblnumerocant.Text = 0 + "|" + nudcajas.Value.ToString() + "|" + nudtermos.Value.ToString();

            }
            else if (chkcajas.Checked == false & chktoneladas.Checked == true & chktermos.Checked == true)
            {
                lbletibultos.Text = nudtoneladas.Value.ToString() + " TONELADA(S),"+ nudtermos.Value.ToString() + " TERMO(S)";
                lblnumerocant.Text = nudtoneladas.Value.ToString() + "|" + 0 + "|" + nudtermos.Value.ToString();

            }
            else if(chkcajas.Checked == false & chktoneladas.Checked == true & chktermos.Checked == false)
            {
                lbletibultos.Text = nudtoneladas.Value.ToString() + " TONELADA(S)";
                lblnumerocant.Text = nudtoneladas.Value.ToString() + "|" + 0 + "|" + 0;

            }
            else if (chkcajas.Checked == false & chktoneladas.Checked == false & chktermos.Checked == true)
            {
                lbletibultos.Text = nudtermos.Value.ToString() + " TERMO(S)";
                lblnumerocant.Text = 0+ "|" + 0 + "|" + nudtermos.Value.ToString();

            }
            else if (chkcajas.Checked == true & chktoneladas.Checked == true & chktermos.Checked == true)
            {
                lbletibultos.Text = nudtoneladas.Value.ToString() + " TONELADA(S)," + nudcajas.Value.ToString() + " CAJA(S),"+ nudtermos.Value.ToString() + " TERMO(S)";
                lblnumerocant.Text = nudtoneladas.Value.ToString() + "|" + nudcajas.Value.ToString() + "|" + nudtermos.Value.ToString();

            }
            else
            {
                lbletibultos.Text = "----------";
                lblnumerocant.Text = 0 + "|" + 0 + "|" + 0;

            }
        }
        void REGISTRAR_DETALLE(String NOM, String NDOC, String TPO, Int32 COD_DESCARGA)
        {
            DESC.REGISTRAR_DETALLE_DESCARGA(NOM, NDOC, TPO, COD_DESCARGA);
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
                    MessageBox.Show(this, "NECESITA INDICAR EL DNI O LICENCIA", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    String[] separados = resultado.Split('|');
                    lblcodpers.Text = separados[0];
                    TXTLICDNI.Text = separados[3];
                    TXTNOMBRE.Text = separados[2];
                    comboBox3.Text = separados[1];
                    

                }
                TXTNOMBRE.Focus();
            }
        }

        private void TXTOBSER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTLICDNI.Focus();
            }
        }

        private void TXTNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (TXTLICDNI.Text == "")
                {
                    MessageBox.Show(this, "NECESITA INDICAR EL DNI O LICENCIA", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TXTNOMBRE.Text == "")
                {
                    MessageBox.Show(this, "NECESITA INDICAR EL NOMBRE DEL TRANSPORTISTA",VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    String rpta= "NO";
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells["DOCUMENTO"].Value.ToString().Equals(TXTLICDNI.Text)|| dataGridView1.Rows[i].Cells["NOMBRE"].Value.ToString().Equals(TXTNOMBRE.Text))
                        {
                            rpta = "SI";
                        }
                    }
                    if (rpta.Equals("NO"))
                    {
                        dataGridView1.Rows.Add(lblcodpers.Text, comboBox3.Text, TXTNOMBRE.Text, TXTLICDNI.Text);
                        TXTNOMBRE.Clear();
                        TXTLICDNI.Clear();
                        TXTNOMBRE.Focus();
                    }
                    else
                    {
                        MessageBox.Show(this, "YA HAY UN PERSONAL CON ESOS DATOS EN EL REGISTRO", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            DialogResult DG = new DialogResult();
            Mantenimiento_de_Transporte M = new Mantenimiento_de_Transporte();
            M.STCODIGO.Text = STCODIGO.Text;
            DG = M.ShowDialog();
            if(DG==DialogResult.OK)
            {
                LLENAR_LINEA();
            }
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chktermos_CheckedChanged(object sender, EventArgs e)
        {
            if(chktermos.Checked==true)
            {
                nudtermos.Enabled = true;
              
            }
            else
            {
                nudtermos.Enabled = false;
            }
            cambiar_etiq_bultos();
        }

        private void chktoneladas_CheckedChanged(object sender, EventArgs e)
        {
            if (chktoneladas.Checked == true)
            {
                nudtoneladas.Enabled = true;
               
            }
            else
            {
                nudtoneladas.Enabled = false;
            }
            cambiar_etiq_bultos();
        }
      

        private void chkcajas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcajas.Checked == true)
            {
                nudcajas.Enabled = true;
              
            }
            else
            {
                nudcajas.Enabled = false;
            }
            cambiar_etiq_bultos();
        }

        private void nudtermos_ValueChanged(object sender, EventArgs e)
        {
            cambiar_etiq_bultos();
        }

        private void nudtoneladas_ValueChanged(object sender, EventArgs e)
        {
            cambiar_etiq_bultos();
        }

        private void nudcajas_ValueChanged(object sender, EventArgs e)
        {
            cambiar_etiq_bultos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt =CLSLINEA.llenar_LINEAS();
            DataTable dt2 = CLSTRANSPORTE.llenar_TRANSPORTISTA();
            String BIENLINEA = "NO";
            String BIENTRANSP = "NO";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow DR = dt.Rows[i];
                if(DR["DESCRIPCION"].ToString().Equals(comboBox1.Text))
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
                 MessageBox.Show( this,"EL LABORATORIO ELEGIDO ES INCORRECTO", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (BIENTRANSP.Equals("NO"))
            {
                MessageBox.Show("EL TRANSPORTE ELEGIDO ES INCORRECTO", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (lblnumerocant.Text =="0|0|0")

            {
                MessageBox.Show(this, "NECESITA INDICAR EL DETALLE DE CARGA", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else if (TXTOBSER.Text == "")
            {
                MessageBox.Show(this, "INDIQUE OBSERVACION", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show(this, "NO HAY NINGUN PERSONAL EN EL DETALLE", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells["CODIGO"].Value.Equals("N"))
                    {
                        TP.REGISTRA_PER_TRA(dataGridView1.Rows[i].Cells["NOMBRE"].Value.ToString(),
                            dataGridView1.Rows[i].Cells["DOCUMENTO"].Value.ToString(),
                            dataGridView1.Rows[i].Cells["TIPO"].Value.ToString(),
                            Convert.ToInt32(comboBox2.SelectedValue)
                            );
                    }
                }


                String MSJE = DESC.REGISTRAR_DESCARGA(TXTOBSER.Text, comboBox2.Text, lbletibultos.Text, lblnumerocant.Text, dateTimePicker1.Value, comboBox1.Text);
                MessageBox.Show(this, MSJE, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MSJE == "DESCARGA REGISTRADA")

                {
                    for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                    {
                        REGISTRAR_DETALLE(dataGridView1.Rows[i].Cells["NOMBRE"].Value.ToString(),
                            dataGridView1.Rows[i].Cells["DOCUMENTO"].Value.ToString(), dataGridView1.Rows[i].Cells["TIPO"].Value.ToString(),
                            Convert.ToInt32(LBLNUMERO.Text));
                    }

                    LLENARNUMERO();
                    TXTLICDNI.Clear();
                    TXTNOMBRE.Clear();
                    TXTOBSER.Clear();
                    chktermos.Checked = false;
                    chktoneladas.Checked = false;
                    chkcajas.Checked = true;
                    nudtermos.Value = 1;
                    nudtoneladas.Value = 1;
                    nudcajas.Value = 1;
                    dataGridView1.Rows.Clear();
                }


            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            dataGridView2.DataSource = TP.PERSONAL_SEGUN_TRANSPORTE(Convert.ToInt32( comboBox2.SelectedValue));
            dataGridView2.Columns["CODIGO"].Visible = false;
        }

        private void txtfiltrarpersonal_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = TP.FILTRAR_PERSONAL_SEGUN_TRANSPORTE(Convert.ToInt32(comboBox2.SelectedValue), txtfiltrarpersonal.Text);

        }

        private void txtfiltrarpersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblcodpers.Text= dataGridView2.CurrentRow.Cells["CODIGO"].Value.ToString();
            TXTLICDNI.Text = dataGridView2.CurrentRow.Cells["DNI/LIC"].Value.ToString();
            TXTNOMBRE.Text= dataGridView2.CurrentRow.Cells["NOMBRE"].Value.ToString();
            comboBox3.Text= dataGridView2.CurrentRow.Cells["FUNCION"].Value.ToString();
            panel4.Visible = false;
            TXTNOMBRE.Focus();
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTOBSER.Focus();
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                comboBox2.Select();
            }
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                comboBox2.Select();
            }
         }
    }
}
