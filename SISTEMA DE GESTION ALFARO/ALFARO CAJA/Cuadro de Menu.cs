using LIBRERIA;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Cuadro_de_Menu : Form
    {
        public Cuadro_de_Menu()
        {
            InitializeComponent();
        }
        ClsProveedor PV = new ClsProveedor();
        CLSCONTROLM menu = new CLSCONTROLM();
        private void Cuadro_de_Menu_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            LLENARPV();
            cmbdescripcion.SelectedIndex = 1;
        }
        void LLENARPV()
        {

            cmbprovedorcomida.DataSource = PV.llenar_pv_control_menu();
            cmbprovedorcomida.DisplayMember = "RAZON_SOCIAL";
            cmbprovedorcomida.ValueMember = "CODGIO";
           
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msje = menu.REGISTRAR_MENU(DTPAPERTURA.Value, cmbdescripcion.Text, Convert.ToInt32(numeros.Value), Convert.ToInt32(cmbprovedorcomida.SelectedValue));
            MessageBox.Show(this, msje, VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
