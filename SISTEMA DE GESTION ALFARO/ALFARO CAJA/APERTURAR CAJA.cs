using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBRERIA;
namespace ALFARO_CAJA
{
    public partial class APERTURAR_CAJA : Form
    {
        public APERTURAR_CAJA()
        {
            InitializeComponent();
        }
        Clscaja CJ = new Clscaja();
        double ACUMULADOR = 0;
        private void APERTURAR_CAJA_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = Environment.MachineName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msje = CJ.Aperturar_Caja(DTPAPERTURA.Value, TSUSUARIO.Text, TXTAPERTURACAJA.Text);
            if (msje == "CAJA APERTURADA") {
                MessageBox.Show(msje, "GESADIV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else {
                MessageBox.Show(msje, "GESADIV", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
     
        }
    }
}
