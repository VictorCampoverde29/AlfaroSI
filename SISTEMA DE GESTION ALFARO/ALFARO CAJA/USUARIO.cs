using System;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class USUARIO : Form
    {
        public USUARIO()
        {
            InitializeComponent();
        }
        
        USUARIOS USU = new USUARIOS();
        private void USUARIO_PERSONAL_Load(object sender, EventArgs e)
        {
            CMBESTADOUSU.SelectedIndex = 0;
            CMBTIPOUSU.SelectedIndex = 0;
            LLENAR_DGV_USUARIO();
            STPC.Text = Environment.MachineName;
           
           
        }
        void LLENAR_DGV_USUARIO()
        {
            dataGridView2.DataSource = USU.llenar_USU_TOTAL();
        }
        
       

        private void TXTDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void DATOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                panel3.Enabled = true;
                button2.Text = "NUEVO REGISTRO";
                LBLCODUSU.Visible = false;
                TXTCODIGOUSUARIO.Visible = true;
            }
            else
            {
                button2.Text = "MODIFICAR";
                LBLCODUSU.Visible = true;
                TXTCODIGOUSUARIO.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "MODIFICAR")
            {
                if (LBLCODUSU.Text == "-----")
                {
                    MessageBox.Show(this, "CARGUE ALGUN USUARIO PARA MODIFICAR LOS DATOS",VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    int EST;
                    if (CMBESTADOUSU.SelectedIndex == 0) { EST = 1; }
                    else { EST = 0; }
                    MessageBox.Show(this, USU.MODIFICAR_USUARIO(LBLCODUSU.Text, textBox1.Text, EST, TXTCLAVE.Text, CMBTIPOUSU.Text.Substring(0, 2)), VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LLENAR_DGV_USUARIO();
                    TXTCODIGOUSUARIO.Clear();
                    textBox1.Clear();
                    TXTCLAVE.Clear();
                    panel3.Enabled = false;
                }
            }
            else
            {
                if (TXTCODIGOUSUARIO.Text == "" || TXTCLAVE.Text == "" || textBox1.Text == "")
                {

                    MessageBox.Show(this, "FALTAN DATOS",VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string MSJE = USU.NUEVO_USUARIO(TXTCODIGOUSUARIO.Text, textBox1.Text, TXTCLAVE.Text, CMBTIPOUSU.Text.Substring(0, 2));

                    MessageBox.Show(this, MSJE,VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MSJE == "USUARIO CREADO")
                    {
                        LLENAR_DGV_USUARIO();
                        TXTCODIGOUSUARIO.Clear();
                        textBox1.Clear();
                        TXTCLAVE.Clear();
                        panel3.Enabled = false;
                    }
                }
            }
        }

       

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Enabled = true;
            LBLCODUSU.Text = dataGridView2.CurrentRow.Cells["CODIGO"].Value.ToString();
            CMBESTADOUSU.Text = dataGridView2.CurrentRow.Cells["ESTADO"].Value.ToString();
            textBox1.Text = dataGridView2.CurrentRow.Cells["NOMBRE COMPLETO"].Value.ToString();
            TXTCLAVE.Text = dataGridView2.CurrentRow.Cells["CLAVE"].Value.ToString();
            String tipo = dataGridView2.CurrentRow.Cells["TIPO"].Value.ToString();
            int indice = 0;
            for (int i = 1; i < CMBTIPOUSU.Items.Count; i++)
            {
                String tipocombo = CMBTIPOUSU.Items[i].ToString().Substring(0, 2);
                if (tipo == tipocombo)
                {
                    indice = i;
                }
            }
            CMBTIPOUSU.SelectedIndex = indice;
        }
    }
}
    

