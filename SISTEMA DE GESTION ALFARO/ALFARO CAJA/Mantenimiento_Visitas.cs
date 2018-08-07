using System;
using System.Windows.Forms;
using LIBRERIA;

namespace ALFARO_CAJA
{
    public partial class Mantenimiento_Visitas : Form
    {
        public Mantenimiento_Visitas()
        {
            InitializeComponent();
        }
        CLSDESCARGAS ds = new CLSDESCARGAS();
        void buscar()
        {
          
            //LBLREGISTROSDESCARGAS.Text = dataGridView1.RowCount + " REGISTROS";
            dataGridView2.DataSource = ds.llenar_VISITA(dateTimePicke1.Value);
            dataGridView2.Columns["CODIGO"].Visible = false;
            //LBLVISITASRG.Text= dataGridView2.RowCount + " REGISTROS";
        }
        private void Mantenimiento_Visitas_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Modifica_dv_detallecs VEN = new Modifica_dv_detallecs();
            VEN.LBLNUMERO.Text = dataGridView2.CurrentRow.Cells["CODIGO"].Value.ToString();
            VEN.dateTimePicker1.Value = dateTimePicke1.Value;
            VEN.textBox1.Text = dataGridView2.CurrentRow.Cells["EMPRESA"].Value.ToString();
            VEN.STCODIGO.Text = STCODIGO.Text;
            VEN.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
            VEN.STPERFIL.Text = STPERFIL.Text;
            VEN.dateTimePicker2.Value = Convert.ToDateTime(dataGridView2.CurrentRow.Cells["HORA"].Value);
            VEN.TXTOBSER.Text = dataGridView2.CurrentRow.Cells["OBSERVACION"].Value.ToString();
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
