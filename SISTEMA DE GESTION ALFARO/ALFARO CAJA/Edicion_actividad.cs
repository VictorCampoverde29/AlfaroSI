using System;
using System.Windows.Forms;
using LIBRERIA;
namespace ALFARO_CAJA
{
    public partial class Edicion_actividad : Form
    {

        CLSACTIVIDAD acti = new CLSACTIVIDAD();
        public Edicion_actividad()
        {
            InitializeComponent();
        }
 
        private void Edicion_actividad_Load(object sender, EventArgs e)
        {
          
            STPC.Text = Environment.MachineName;
        }

     

        private void Edicion_actividad_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msje = acti.Editar_Actividad(
               Convert.ToInt32(lblcod.Text),
               actividad.Text,
               comboBox1.Text.Substring(0, 3), dtpinicio.Value,
               dtptermino.Value, horainicio.Value, horatermino.Value,
               cmbarea.Text, Convert.ToInt32(porcentaje.Value), txtusuario.Text);


            if (msje == "ACTIVIDAD MODIFICADA")
            {
                MessageBox.Show(this,msje,VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
