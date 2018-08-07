using System;

using System.Windows.Forms;
using LIBRERIA;

namespace ALFARO_CAJA
{
    public partial class REGISTRO_INVENTARIO_PARCIAL : Form
    {
        public REGISTRO_INVENTARIO_PARCIAL()
        {
            InitializeComponent();
        }
        CLSINV INVEN = new CLSINV();
        private void REGISTRO_INVENTARIO_PARCIAL_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show(this, "INGRESE EL NOMBRE DEL INVENTARIO", "AVISO");
            }
            else
            {
                string MSJE = INVEN.NUEVO_INV(textBox1.Text, STCODIGO.Text, DTPDEL.Value, DTPAL.Value, "SISTEMAS");
                MessageBox.Show(this, MSJE, "AVISO");
            }
        }
    }
}
