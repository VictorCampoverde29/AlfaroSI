using System;
using System.Windows.Forms;
using LIBRERIA;
namespace ALFARO_CAJA
{
    public partial class Modificar_Inventario : Form
    {
        public Modificar_Inventario()
        {
            InitializeComponent();
        }
        CLSINV INV = new CLSINV();
        private void Modificar_Inventario_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            DatosInventarioModificar dt = new DatosInventarioModificar();
            dt.lblcod.Text = dataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString();
            dt.txtdescripcion.Text = dataGridView1.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
            dt.lblaperturado.Text = dataGridView1.CurrentRow.Cells["APERTURADO POR"].Value.ToString();
            dt.dtpfchainicio.Value = Convert.ToDateTime( dataGridView1.CurrentRow.Cells["FECHA INICIO"].Value);
            dt.dtpcierre.Value= Convert.ToDateTime(dataGridView1.CurrentRow.Cells["FECHA FIN"].Value);
            dt.cmbestado.Text= dataGridView1.CurrentRow.Cells["ESTADO"].Value.ToString();
            dt.MdiParent = this.ParentForm;
            dt.Show();
            dt.FormClosed += Dt_FormClosed;
           
        }

        private void Dt_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.DataSource = INV.VER_INVENTARIOS_SEGUN_FECHA(metroDateTime1.Value, metroDateTime2.Value);

        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
  
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1.DataSource = INV.VER_INVENTARIOS_SEGUN_FECHA(metroDateTime1.Value, metroDateTime2.Value);
        }
    }
}
