using System;
using System.Windows.Forms;
using LIBRERIA;
namespace ALFARO_CAJA
{
    public partial class Editar_Inspeccion : Form
    {
        public Editar_Inspeccion()
        {
            InitializeComponent();
        }
        ClsInspeccion insp = new ClsInspeccion();
        private void txtnomprod_TextChanged(object sender, EventArgs e)
        {
            lblnomprod.Text = txtnomprod.Text;
        }

        private void txtforma_TextChanged(object sender, EventArgs e)
        {
            lblforma.Text = txtforma.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String msje = insp.EDITAR_INSPECCION(Convert.ToInt32(lblcod.Text), dtpfecha.Value, txtnomprod.Text, Convert.ToInt32(nupcant.Value),
              txtforma.Text, txtfactura.Text, txtguia.Text, txtproveedor.Text, txtconcentracion.Text, txtlote.Text,
              Convert.ToDateTime(dtpvcto.Value), txtregsanitario.Text, Convert.ToInt32(nupcant.Value), Convert.ToInt32(npdcansoli.Value),
              Convert.ToInt32(nupmuestra.Value),TXTCONDALMACENAMIENTO.Text,txtcondalmacenarecep.Text,txtobservacion.Text);
                if (msje== "INSPECCION MODIFICADA")
                {
                    MessageBox.Show(this, msje, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                
            }
          

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Filtrado_Insp fil = new Filtrado_Insp();
            fil.lblcate.Text = lbltipo.Text;
            fil.MdiParent = this.ParentForm;
            fil.Show();
            fil.FormClosed += Fil_FormClosed;
        }

        private void Fil_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                txtnomprod.Text = VariablesGlobales.PRODUCTO;
                txtlote.Text = VariablesGlobales.LOTE;
                dtpvcto.Value = Convert.ToDateTime(VariablesGlobales.VTO);
                txtregsanitario.Text = VariablesGlobales.REG_SANITARIO;
                txtconcentracion.Text = VariablesGlobales.CONCENTRACION;
                txtforma.Text = VariablesGlobales.FPRESENT;
            }
            catch (Exception)
            {

            }


        }

        private void Editar_Inspeccion_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
        }
    }
}
