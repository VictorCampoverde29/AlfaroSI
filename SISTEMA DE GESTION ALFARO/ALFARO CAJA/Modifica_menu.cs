
using System;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class Modifica_menu : Form
    {
        public Modifica_menu()
        {
            InitializeComponent();
        }
        CLSREPORTES REP = new CLSREPORTES();
        CLSCONTROLM menu = new CLSCONTROLM();
        ClsProveedor PV = new ClsProveedor();
        private void Modifica_menu_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            cmbdescripcion.SelectedIndex = 0;
            LLENARPV();
        }
        void LLENARPV()
        {

            cmbprovedorcomida.DataSource = PV.llenar_pv_control_menu();
            cmbprovedorcomida.DisplayMember = "RAZON_SOCIAL";
            cmbprovedorcomida.ValueMember = "CODGIO";

        }

        void VER_X_FECHAS()
        {
            DGVDATA.DataSource = REP.REPORTE_COMIDA_RANGO_MODIFICAR(DTPDEL.Value, DTPAL.Value);
            DGVDATA.Columns["RAZON_SOCIAL"].Visible = false;
            DGVDATA.Columns["idcontrol_menu"].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            VER_X_FECHAS();
        }

        private void DGVDATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbprovedorcomida.Text = DGVDATA.CurrentRow.Cells["RAZON_SOCIAL"].Value.ToString();
            LBLIDMENU.Text= DGVDATA.CurrentRow.Cells["idcontrol_menu"].Value.ToString();
            cmbdescripcion.Text=DGVDATA.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
            LBLFECHA.Text = DGVDATA.CurrentRow.Cells["FECHA"].Value.ToString().Substring(0,10);
            numeros.Value = Convert.ToInt32(DGVDATA.CurrentRow.Cells["CANTIDAD"].Value);
        }

        private void cmbprovedorcomida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LBLIDMENU.Text == "---")
            {
                MessageBox.Show(this, "Seleccione un Registro para modificar", "SISTEMA DE GESTION");
            }
            else
            {
                String msje = menu.MODIFICAR_MENU(cmbdescripcion.Text, Convert.ToInt32(numeros.Value), Convert.ToInt32(cmbprovedorcomida.SelectedValue), Convert.ToInt32(LBLIDMENU.Text));

                if (msje == "Control de Menú Modificado")
                {
                    MessageBox.Show(this, msje, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VER_X_FECHAS();
                    LBLIDMENU.Text = "---";
                    LBLFECHA.Text = "--/--/----";
                }
                else
                {
                    MessageBox.Show(this, msje, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cmbprovedorcomida_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
