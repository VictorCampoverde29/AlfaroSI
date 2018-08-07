using System;
using System.Windows.Forms;
using LIBRERIA;
namespace ALFARO_CAJA
{
    public partial class MantenimientoER : Form
    {
        public MantenimientoER()
        {
            InitializeComponent();
        }
        CLSER escremot = new CLSER();

        void llenarvalores()
        {
            dataGridView1.DataSource = escremot.VER_EQUIPOS();
        }

        private void MantenimientoER_Load(object sender, EventArgs e)
        {
            llenarvalores();
            STPC.Text = Environment.MachineName;
            CMBESTADO.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Text = "EDITAR";
            groupBox1.Text = "EDITAR EQUIPO";
            button1.Visible = true;
            TXTCODIGO.Text = dataGridView1.CurrentRow.Cells["COD"].Value.ToString();
            TXTDESCRI.Text= dataGridView1.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
            TXTCLAVE.Text= dataGridView1.CurrentRow.Cells["CLAVE"].Value.ToString();
            TXTSERVIDOR.Text= dataGridView1.CurrentRow.Cells["SERVIDOR"].Value.ToString();
            TXTUSUARIO.Text= dataGridView1.CurrentRow.Cells["USER"].Value.ToString();
            CMBESTADO.Text= dataGridView1.CurrentRow.Cells["ESTADO"].Value.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            button1.Visible = true;
            TXTCODIGO.Text = "-";
            TXTDESCRI.Focus();
            TXTCODIGO.Enabled = false;
            TXTDESCRI.Text = "";
            TXTSERVIDOR.Text = "";
            TXTUSUARIO.Text = "";
            TXTCLAVE.Text = "";
            CMBESTADO.SelectedIndex = 0;
            groupBox1.Text = "NUEVO REGISTRO";
            button1.Text = "REGISTRAR" ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="REGISTRAR")
            {
                if (TXTDESCRI.Text=="" || TXTSERVIDOR.Text=="" || TXTUSUARIO.Text==""||TXTCLAVE.Text=="")
                {
                    MessageBox.Show(this, "FALTAN DATOS PARA REGISTRAR", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show(this,escremot.Registro_Equipos(TXTDESCRI.Text,TXTSERVIDOR.Text,TXTUSUARIO.Text,TXTCLAVE.Text,CMBESTADO.Text), VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarvalores();
                }
            }
            else if (button1.Text == "EDITAR")
            {
                if (TXTDESCRI.Text == "" || TXTSERVIDOR.Text == "" || TXTUSUARIO.Text == "" || TXTCLAVE.Text == "")
                {
                    MessageBox.Show(this, "FALTAN DATOS PARA MODIFICAR", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show(this, escremot.Editar_Equipos(Convert.ToInt32(TXTCODIGO.Text),TXTDESCRI.Text, TXTSERVIDOR.Text, TXTUSUARIO.Text, TXTCLAVE.Text, CMBESTADO.Text), VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llenarvalores();
                }

            }
        }
    }
}
