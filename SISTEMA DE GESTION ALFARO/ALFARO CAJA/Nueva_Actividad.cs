
using System;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class Nueva_Actividad : Form
    {
        CLSACTIVIDAD acti = new CLSACTIVIDAD();
        String ESTADO = "REG";
        public Nueva_Actividad()
        {
            InitializeComponent();
        }

        private void Nueva_Actividad_Load(object sender, EventArgs e)
        {
            cmbarea.SelectedIndex = 0;
            STPC.Text = Environment.MachineName;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                dtptermino.Enabled = true;
                horatermino.Enabled = true;
                porcentaje.Value = 100;
                porcentaje.Enabled = false;
                ESTADO = "TER";
            }
            else
            {
                dtptermino.Enabled = false;
                horatermino.Enabled = false;
                porcentaje.Value = 1;
                porcentaje.Enabled = true;
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msje = acti.Nueva_Actividad(actividad.Text, ESTADO, dtpinicio.Value, dtptermino.Value,
               horainicio.Value, horatermino.Value, cmbarea.Text, Convert.ToInt32(porcentaje.Value),
               STCODIGO.Text);
            if (msje == "ACTIVIDAD REGISTRADA")
            {
                MessageBox.Show(this, msje, VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
                actividad.Clear();
                ESTADO = "REG";
                cmbarea.SelectedIndex = 0;
                porcentaje.Value = 1;
                checkBox1.Checked = false;

            }
            else
            {
                MessageBox.Show(this, msje, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
