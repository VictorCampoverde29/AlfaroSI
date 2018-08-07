
using System;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class Modifica_dv_detallecs : Form
    {
        public Modifica_dv_detallecs()
        {
            InitializeComponent();
        }
        CLSDESCARGAS ds = new CLSDESCARGAS();
        void CARGAR_DETALLES()
        {
            dataGridView1.DataSource = ds.llenar_PERSOnal_x_codigo(Convert.ToInt32(LBLNUMERO.Text));

        }
        private void Modifica_dv_detallecs_Load(object sender, EventArgs e)
        {
            CARGAR_DETALLES();
            STPC.Text = Environment.MachineName;
        }
        private void TXTNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                
                    if (TXTNOMBRE.Text == "")
                    {
                        MessageBox.Show(this, "NECESITA INDICAR EL NOMBRE",VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (TXTDNI.Text == "")
                    {
                        MessageBox.Show(this, "NECESITA INDICAR EL DNI O LICENCIA ", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        ds.REGISTRAR_DETALLE_VISITA(TXTNOMBRE.Text, TXTDNI.Text, Convert.ToInt32(LBLNUMERO.Text));

                        TXTNOMBRE.Clear();
                        TXTDNI.Clear();
                        TXTNOMBRE.Focus();
                        CARGAR_DETALLES();

                    }
                }
               
            
        }
      

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                if (dataGridView1.RowCount == 0)
                {

                }
                else
                {
                    ds.ELIMINAR_DETALLE_DESCARGA(dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString(),
                        Convert.ToInt32(LBLNUMERO.Text));
                    CARGAR_DETALLES();
                }
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
           

        }

        private void Modifica_dv_detallecs_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count==0)
            {
                MessageBox.Show(this, "NO PUEDE MODIFICAR SIN PERSONAL EN LA VISITA",VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TXTOBSER.Text == "")
            {
                MessageBox.Show(this, "INDIQUE MOTIVO",VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show(this, "INDIQUE EMPRESA", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String msje = ds.MODIFICAR_VISITA(Convert.ToInt32(LBLNUMERO.Text),
                    TXTOBSER.Text, textBox1.Text, dateTimePicker1.Value,
                    dateTimePicker2.Value, textBox1.Text);
                MessageBox.Show(this, msje, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
                dateTimePicker2.Focus();
            }
        }

        private void dateTimePicker2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TXTDNI_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTNOMBRE.Focus();
            }
        }
    }
}
    
    

