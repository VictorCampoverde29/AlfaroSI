using LIBRERIA;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class ABRIR_CAJA : Form
    {
        public ABRIR_CAJA()
        {
            InitializeComponent();
        }
        Clscaja CJ = new Clscaja();
  
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void ABRIR_CAJA_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (TXTAPERTURACAJA.Text == "")
            {
                MessageBox.Show(this, "INDIQUE EL NOMBRE DE LA CAJA",VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string msje = CJ.Aperturar_Caja(DTPAPERTURA.Value, STCODIGO.Text, TXTAPERTURACAJA.Text);
                if (msje == "CAJA APERTURADA")
                {
                    MessageBox.Show(this, msje,VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, msje, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
