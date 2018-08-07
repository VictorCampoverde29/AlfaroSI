
using System;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class Terminar_acti : Form
    {
        public Terminar_acti()
        {
            InitializeComponent();
        }
        CLSACTIVIDAD acti = new CLSACTIVIDAD();
        private void Terminar_acti_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
        }

       
        private void Terminar_acti_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msje = acti.Terminar_Actividad(Convert.ToInt32(lblcod.Text),
           dtptermino.Value, horatermino.Value, Convert.ToInt32(porcentaje.Value));
           MessageBox.Show(this, msje, "SISTEMA DE GESTION INTERNA " + Application.ProductVersion,MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (msje == "ACTIVIDAD TERMINADA")
            {
                this.Close();
            }
        }
    }
}
