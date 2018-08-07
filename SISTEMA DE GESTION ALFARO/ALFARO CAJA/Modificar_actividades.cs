using System;
using System.Windows.Forms;
using LIBRERIA;
namespace ALFARO_CAJA
{
    public partial class Modificar_actividades : Form
    {
        public Modificar_actividades()
        {
            InitializeComponent();
        }
        CLSACTIVIDAD acti = new CLSACTIVIDAD();
        private void Modificar_actividades_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
        }
        void ver_datos()
        {
            dataGridView1.DataSource = acti.Ver_actividades_total(f1.Value);
            dataGridView1.Columns["CODIGO"].Visible = false;
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Edicion_actividad ven = new Edicion_actividad();
            ven.STCODIGO.Text = STCODIGO.Text;
            ven.actividad.Text = dataGridView1.CurrentRow.Cells["TAREA"].Value.ToString();
            ven.cmbarea.Text= dataGridView1.CurrentRow.Cells["AREA"].Value.ToString();
            ven.dtpinicio.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["FECHA_INICIO"].Value);
            ven.horainicio.Text = dataGridView1.CurrentRow.Cells["HORA_INICIO"].Value.ToString();
            ven.porcentaje.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PORCENTAJE"].Value);
            ven.txtusuario.Text= dataGridView1.CurrentRow.Cells["USUARIO"].Value.ToString();
            ven.comboBox1.Text= dataGridView1.CurrentRow.Cells["ESTADO"].Value.ToString();
            ven.lblcod.Text= dataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString();
            ven.MdiParent = this.ParentForm;
            ven.Show();

            ven.FormClosed += Ven_FormClosed;
            
         
        }

        private void Ven_FormClosed(object sender, FormClosedEventArgs e)
        {
            ver_datos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ver_datos();
        }
    }
}
