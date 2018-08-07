
using System;
using System.Windows.Forms;
using LIBRERIA;
namespace ALFARO_CAJA
{
    public partial class Mantenimiento_Descargas_Visitas : Form
    {
        public Mantenimiento_Descargas_Visitas()
        {
            InitializeComponent();
        }
        CLSDESCARGAS ds = new CLSDESCARGAS();
        private void Mantenimiento_Descargas_Visitas_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
        }
        void buscar()
        {
            dataGridView1.DataSource = ds.llenar_descarga(dateTimePicke1.Value);
            dataGridView1.Columns["CODIGO"].Visible = false;
            dataGridView1.Columns["CANTIDADES"].Visible = false;
            //LBLREGISTROSDESCARGAS.Text = dataGridView1.RowCount + " REGISTROS";
        }
     

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Modifica_Descarga VEN = new Modifica_Descarga();
            VEN.LBLNUMERO.Text = dataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString();
            VEN.LINEA= dataGridView1.CurrentRow.Cells["LABORATORIO"].Value.ToString();
            VEN.TPT = dataGridView1.CurrentRow.Cells["OPERADOR LOGISTICO"].Value.ToString();
            VEN.dateTimePicker1.Value = dateTimePicke1.Value;
            VEN.TXTOBSER.Text= dataGridView1.CurrentRow.Cells["OBSERVACION"].Value.ToString();
            String[] totalcant=dataGridView1.CurrentRow.Cells["CANTIDADES"].Value.ToString().Split('|');

            if (Convert.ToInt32(totalcant[0].ToString()) > 0)
            {
                VEN.chktoneladas.Checked = true;
            }
            if (Convert.ToInt32(totalcant[1].ToString()) > 0)
            {
                VEN.chkcajas.Checked = true;
            }
            if (Convert.ToInt32(totalcant[2].ToString())>0)
            {
                VEN.chktermos.Checked = true;
            }
            VEN.nudtoneladas.Value = Convert.ToInt32(totalcant[0].ToString());
            VEN.nudcajas.Value = Convert.ToInt32(totalcant[1].ToString());
            VEN.nudtermos.Value = Convert.ToInt32(totalcant[2].ToString());

            VEN.dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["HORA"].Value);
            VEN.STCODIGO.Text = STCODIGO.Text;
            VEN.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
            VEN.STPERFIL.Text = STPERFIL.Text;
            VEN.MdiParent = this.ParentForm;
            VEN.FormClosed += VEN_FormClosed;
            VEN.Show();
           
        }

        private void VEN_FormClosed(object sender, FormClosedEventArgs e)
        {
            buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
