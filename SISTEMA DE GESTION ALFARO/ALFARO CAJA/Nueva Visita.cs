using LIBRERIA;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Nueva_Visita : Form
    {
        public Nueva_Visita()
        {
            InitializeComponent();
        }
       
        CLSDV DV = new CLSDV();
        CLSDESCARGAS DESC = new CLSDESCARGAS();
        String EMPRESA;
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
        void LLENARNUMERO()
        {
            LBLNUMERO.Text = DV.DEVOLVER_NUMERO() + 1 + "";
        }
        private void Nueva_Visita_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            LLENAR_LINEA();
            LLENARNUMERO();
            EMPRESA = comboBox1.Text;
        }

        void REGISTRAR_DETALLE(String NOM, String NDOC, String TPO, Int32 COD_DESCARGA)
        {
            DESC.REGISTRAR_DETALLE_VISITA(NOM, NDOC, COD_DESCARGA);
        }
    

        private void TXTDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
         
             if ((int)e.KeyChar == (int)Keys.Enter)
            {
               
                 if (TXTDNI.Text == "")
                {
                    MessageBox.Show(this, "NECESITA INDICAR EL DNI ", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    TXTNOMBRE.Focus();
                }
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox1.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                textBox1.Enabled = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
 
                    TXTOBSER.Focus();
               
            }
        }

        private void TXTOBSER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
               
                    TXTDNI.Focus();
         

            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = CLSLINEA.llenar_LINEAS();
           
            String BIENLINEA = "NO";
         
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow DR = dt.Rows[i];
                if (DR["DESCRIPCION"].ToString().Equals(comboBox1.Text))
                {
                    BIENLINEA = "SI";
                }
            }

           


            if (BIENLINEA.Equals("NO"))
            {
                MessageBox.Show("EL LABORATORIO ELEGIDO ES INCORRECTO");

            }
           
            else if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show(this, "AGREGE AL MENOS UNA PERSONA PARA GUARDAR LA VISITA", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (TXTOBSER.Text == "")
            {
                MessageBox.Show(this, "INDIQUE MOTIVO", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show(this, "NO HAY NINGUN PERSONAL EN EL DETALLE", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                if (textBox1.Enabled == true)
                {
                    EMPRESA = textBox1.Text;
                }
                else
                {
                    EMPRESA = comboBox1.Text;
                }
                String MSJE = DESC.REGISTRAR_VISITA(TXTOBSER.Text, EMPRESA, dateTimePicker1.Value, EMPRESA);
                MessageBox.Show(this, MSJE, "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MSJE == "VISITA REGISTRADA")

                {
                    for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                    {
                        REGISTRAR_DETALLE(dataGridView1.Rows[i].Cells["NOMBRE"].Value.ToString(),
                            dataGridView1.Rows[i].Cells["DOCUMENTO"].Value.ToString(), dataGridView1.Rows[i].Cells["TIPO"].Value.ToString(),
                            Convert.ToInt32(LBLNUMERO.Text));
                    }

                    LLENARNUMERO();
                    TXTDNI.Clear();
                    TXTNOMBRE.Clear();
                    TXTOBSER.Clear();
                    dataGridView1.Rows.Clear();
                    textBox1.Clear();
                }
            }
        }

        private void TXTNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            String repetido = "NO";

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells["NOMBRE"].Value.ToString().Equals(TXTNOMBRE.Text) || dataGridView1.Rows[i].Cells["DOCUMENTO"].Value.ToString().Equals(TXTDNI.Text))
                {
                    repetido = "SI";
                }

            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (TXTNOMBRE.Text == "")
                {
                    MessageBox.Show(this, "NECESITA INDICAR EL NOMBRE", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (TXTDNI.Text == "")
                {
                    MessageBox.Show(this, "NECESITA INDICAR EL DNI ", "GESTION INTERNA " + Application.ProductVersion, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if(repetido.Equals("SI"))
                {
                            MessageBox.Show("YA HAY UNA PERSONA CON ESTOS DATOS EN EL SISTEMA");
                }
                else
                {
                
                        dataGridView1.Rows.Add("VISITANTE", TXTNOMBRE.Text, TXTDNI.Text);
                        TXTNOMBRE.Clear();
                        TXTDNI.Clear();
                        TXTNOMBRE.Focus();
                    
                  


                }
            }
        }
    }
}
