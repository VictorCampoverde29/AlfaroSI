
using System;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class DatosInventarioModificar : Form
    {
        public DatosInventarioModificar()
        {
            InitializeComponent();
        }
        CLSINV INV = new CLSINV();
        private void DatosInventarioModificar_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
           

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EST;
            if (cmbestado.Text == "APERTURADO")
            {
                EST = "APT";
            }
            else if (cmbestado.Text == "CERRADO")
            {
                EST = "CER";
            }
            else
            {
                EST = "ANL";
            }
            String MSJE = INV.MODIFICAR_INV(Convert.ToInt32(lblcod.Text), txtdescripcion.Text, EST, dtpfchainicio.Value, dtpcierre.Value);
            MessageBox.Show(this, MSJE, VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (MSJE== "INVENTARIO ACTUALIZADO")
            {
                this.Close();
            }
        }
    }
}
