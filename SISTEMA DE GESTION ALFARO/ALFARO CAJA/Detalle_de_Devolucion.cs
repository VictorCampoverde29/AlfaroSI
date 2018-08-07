using LIBRERIA;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Detalle_de_Devolucion : Form
    {
        public Detalle_de_Devolucion()
        {
            InitializeComponent();
        }
        CLSDEVOLUCION DV = new CLSDEVOLUCION();
        private void Detalle_de_Devolucion_Load(object sender, EventArgs e)
        {
            if(LBLTIPO.Text=="CONS")
            {
                PANELDESCARGAR.Visible = false;
            }
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            String MSJE = DV.TRASLADO_GUIA(Convert.ToInt32(LBLCOD.Text), dateTimePicker1.Value);
            if (MSJE== "SE REGISTRO LA FECHA TRANSLADO DE LA GUIA")
            {
                MessageBox.Show(this, MSJE,VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
