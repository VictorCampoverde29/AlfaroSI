using System;
using System.Windows.Forms;
using LIBRERIA;
namespace ALFARO_CAJA
{
    public partial class Liquido_Jarabe : Form
    {
        public Liquido_Jarabe()
        {
            InitializeComponent();
        }
        
        private void Liquido_Jarabe_Load(object sender, EventArgs e)
        {
            LLENAR_LINEA();
            STPC.Text = Environment.MachineName;
        }
        ClsInspeccion isp = new ClsInspeccion();
        void LLENAR_LINEA()
        {
            cmbproveedor.DataSource = CLSLINEA.llenar_LINEAS();
            cmbproveedor.DisplayMember = "DESCRIPCION";
            cmbproveedor.ValueMember = "IDLINEA";


            // cargo la lista de items para el autocomplete dle combobox
            cmbproveedor.AutoCompleteCustomSource = CLSLINEA.Autocomplete();
            cmbproveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbproveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

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
            Int32 valor = isp.REGISTRAR_NUEVA_INSPECCION(txtnomprod.Text, Convert.ToInt32(nupcant.Value), txtforma.Text,
                txtfactura.Text, txtguia.Text, cmbproveedor.Text, txtconcentracion.Text, txtlote.Text, dtpvcto.Value, txtregsanitario.Text,
                Convert.ToInt32(nupmuestra.Value), Convert.ToInt32(npdcansoli.Value), lbltipo.Text,dtpfecha.Value,TXTCONDALMACENAMIENTO.Text,
                txtcondalmacenarecep.Text, txtobservacion.Text);
            MessageBox.Show(this, "INSPECCION N°:" + valor + " REGISTRADA" , VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtnomprod.Clear();
            txtforma.Clear();
            txtfactura.Clear();
            txtguia.Clear();
            txtconcentracion.Clear();
            txtlote.Clear();
            txtregsanitario.Clear();
            
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
    }
}
