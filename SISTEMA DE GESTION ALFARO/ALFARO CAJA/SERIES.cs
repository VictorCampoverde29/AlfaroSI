using LIBRERIA;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class SERIES : Form
    {
        public SERIES()
        {
            InitializeComponent();
        }
        CLSSERIES SR = new CLSSERIES();
        private void SERIES_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            STPC.Text = Environment.MachineName;
            LLENAR_SERIES();
        }
        void LLENAR_SERIES()
        {
            DATOS.DataSource = SR.llenar_SERIES();
            DATOS.Columns["IDSERIES_CONFIGURACION"].Visible = false;
        }
        private void DATOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            LBLCOD.Text = DATOS.CurrentRow.Cells["IDSERIES_CONFIGURACION"].Value.ToString();
            TXTUSUARIO.Text = DATOS.CurrentRow.Cells["USUARIO"].Value.ToString();
            TXTPC.Text = DATOS.CurrentRow.Cells["PC"].Value.ToString();
            TXTTIP.Text = DATOS.CurrentRow.Cells["TIPO"].Value.ToString();
            TXTSERIE.Text = DATOS.CurrentRow.Cells["SERIE"].Value.ToString();
            TXTCOR.Text = DATOS.CurrentRow.Cells["CORRELATIVO"].Value.ToString();
            comboBox1.Text = DATOS.CurrentRow.Cells["ESTADO"].Value.ToString();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
          
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TXTUSUARIO.Text == "" || TXTCOR.Text == "" || TXTPC.Text == "" || TXTSERIE.Text == "" || TXTTIP.Text == "")
            {
                MessageBox.Show(this, "FALTAN DATOS", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show(this, SR.REG_SERIE(TXTTIP.Text, TXTPC.Text, TXTUSUARIO.Text, Convert.ToInt32(TXTSERIE.Text), Convert.ToInt32(TXTCOR.Text)), VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                LLENAR_SERIES();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LBLCOD.Text == "---")
            {
                MessageBox.Show(this, "NO SE HA ELEGIDO NINGUNA SERIE", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (TXTUSUARIO.Text == "" || TXTCOR.Text == "" || TXTPC.Text == "" || TXTSERIE.Text == "" || TXTTIP.Text == "")
                {
                    MessageBox.Show(this, "FALTAN DATOS",VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    MessageBox.Show(this, SR.MODIFICAR_SERIE(Convert.ToInt32(LBLCOD.Text), comboBox1.Text.Substring(0, 1), TXTTIP.Text, TXTPC.Text, TXTUSUARIO.Text, Convert.ToInt32(TXTSERIE.Text), Convert.ToInt32(TXTCOR.Text)), VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LLENAR_SERIES();
                }
            }
        }
    }
}
