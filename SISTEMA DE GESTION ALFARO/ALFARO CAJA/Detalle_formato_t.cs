using System;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class Detalle_formato_t : Form
    {
        public Detalle_formato_t()
        {
            InitializeComponent();
        }

        private void Detalle_formato_t_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
        }
        CLSDESCARGAS DESC = new CLSDESCARGAS();
     
        private void Detalle_formato_t_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime horainicio = Convert.ToDateTime(txtfecha.Text + " " + txthoraini.Text);
            DateTime horafinal = dateTimePicker1.Value;
            if (horafinal < horainicio)
            {
                MessageBox.Show(this, "La hora final no puede ser menor a la hora inicial de la descarga", "AVISO");
            }
            else if(horafinal>Convert.ToDateTime("20:00:00"))
            {
                MessageBox.Show(this, "La hora final no puede ser mayor a las 8:00 p.m.", "AVISO");

            }
            else if (TXTPLACA.Text == "" || TXTPLACA.Text == "-----")
            {
                MessageBox.Show(this, "Faltan Datos..", "AVISO");
            }
            else
            {
                String MSJE = DESC.Confirma_t_ingresos(
                    Convert.ToInt32(lblcodigo.Text), "LIMA", horafinal, numbultos.Text, txtconductor.Text,
                    txtlicencia.Text, TXTPLACA.Text);
                if (MSJE == "DESCARGA MODIFICADA")
                {
                    MessageBox.Show(this, MSJE, "AVISO");
                    Close();
                }
                else
                {
                    MessageBox.Show(this, MSJE, "AVISO");
                }

            }
        }
    }
}
