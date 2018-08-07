using System;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class MOIFICAR_MEMORANDUM : Form
    {
        public MOIFICAR_MEMORANDUM()
        {
            InitializeComponent();
        }
        CLSMEMORANDUM MEMO = new CLSMEMORANDUM();
        Clsarmador ARMA = new Clsarmador();
        private void MOIFICAR_MEMORANDUM_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            LISTAR_ARMADORES();
        }
        void LISTAR_ARMADORES()
        {
            CMBARMADOR.DataSource = ARMA.llenar_ARMADOR();
            CMBARMADOR.DisplayMember = "NOMBRE";
            CMBARMADOR.ValueMember = "IDARMADOR";
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
       
        private void DGVDATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult RSP = new DialogResult();
            MODIFICARMEMO VEN = new MODIFICARMEMO();
            VEN.Text = "MODIFICAR MEMORANDUM NUMERO:" + DGVDATA.CurrentRow.Cells["CODIGO"].Value;
            VEN.STCODIGO.Text = STCODIGO.Text;
            VEN.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
            VEN.STPERFIL.Text = STPERFIL.Text;
            VEN.LBLCOD.Text = DGVDATA.CurrentRow.Cells["CODIGO"].Value.ToString();
            VEN.TXTCP1.Text = DGVDATA.CurrentRow.Cells["CUERPO1"].Value.ToString();
            VEN.TXTCP2.Text = DGVDATA.CurrentRow.Cells["CUERPO2"].Value.ToString();
            VEN.TXTCP3.Text = DGVDATA.CurrentRow.Cells["CUERPO3"].Value.ToString();
            VEN.NOMBRE_TRABAJADOR = DGVDATA.CurrentRow.Cells["APLICADO_A"].Value.ToString();
            VEN.NOMBRE_USUARIO_QUE_REGISTRO = DGVDATA.CurrentRow.Cells["USUARIO"].Value.ToString();
            VEN.CMBASUNTO.Text = DGVDATA.CurrentRow.Cells["ASUNTO"].Value.ToString();
            VEN.CMBTIPO.Text = DGVDATA.CurrentRow.Cells["TIPO"].Value.ToString();
            RSP = VEN.ShowDialog();
            if (RSP == DialogResult.OK)
            {
                DGVDATA.DataSource = MEMO.VER_MEMOS_MODIFICAR_FECHAS(DTPDELGRL.Value, DTPALGRL.Value);
                DGVDATA.Columns["CUERPO1"].Visible = false;
                DGVDATA.Columns["CUERPO2"].Visible = false;
                DGVDATA.Columns["CUERPO3"].Visible = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                DGVDATA.DataSource = MEMO.VER_MEMO_CODIGO(Convert.ToInt32(TXTCOD.Text));
                DGVDATA.Columns["CUERPO1"].Visible = false;
                DGVDATA.Columns["CUERPO2"].Visible = false;
                DGVDATA.Columns["CUERPO3"].Visible = false;
            }
        }


       

       

        private void button1_Click(object sender, EventArgs e)
        {
            DGVDATA.DataSource = MEMO.VER_MEMOS_FECHAS_USUARIO(DTPDEL.Value, DTPAL.Value, Convert.ToInt32(CMBARMADOR.SelectedValue));
            DGVDATA.Columns["CUERPO1"].Visible = false;
            DGVDATA.Columns["CUERPO2"].Visible = false;
            DGVDATA.Columns["CUERPO3"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVDATA.DataSource = MEMO.VER_MEMOS_MODIFICAR_FECHAS(DTPDELGRL.Value, DTPALGRL.Value);
            DGVDATA.Columns["CUERPO1"].Visible = false;
            DGVDATA.Columns["CUERPO2"].Visible = false;
            DGVDATA.Columns["CUERPO3"].Visible = false;
        }
    }
}
