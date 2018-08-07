
using System;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class Consulta_Actividades : Form
    {
        public Consulta_Actividades()
        {
            InitializeComponent();
        }
        CLSACTIVIDAD acti = new CLSACTIVIDAD();
        DateTime F1, F2;
        void llenar_pendientes_mes()
        {
            dataGridView1.DataSource = acti.llenar_pendientes_mes();
        }
        private void Consulta_Actividades_Load(object sender, EventArgs e)
        {
            llenar_pendientes_mes();
            STPC.Text = Environment.MachineName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount>0)
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 0)
                {
                    Terminar_acti tac = new Terminar_acti();
                    tac.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    tac.STPERFIL.Text = STPERFIL.Text;
                    tac.lblcod.Text = dataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString();
                    tac.cmbarea.Text = dataGridView1.CurrentRow.Cells["AREA"].Value.ToString();
                    tac.actividad.Text = dataGridView1.CurrentRow.Cells["TAREA"].Value.ToString();
                    tac.horainicio.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["HORA INICIO"].Value.ToString());
                    tac.dtpinicio.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["FECHA INICIO"].Value.ToString());
                    tac.porcentaje.Minimum = Convert.ToInt32(dataGridView1.CurrentRow.Cells["%"].Value);
                    tac.porcentaje.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["%"].Value);
                    tac.STCODIGO.Text = STCODIGO.Text;
                    tac.MdiParent = this.ParentForm;
                    tac.Show();
                    tac.FormClosed += Tac_FormClosed;

                  
                }
                else if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    String msj = acti.Eliminar_Actividad(Convert.ToInt32(
                        dataGridView1.CurrentRow.Cells["CODIGO"].Value));


                    MessageBox.Show(this, msj,VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    llenar_pendientes_mes();

                }
                else
                {

                }
            }

           
        }

        private void Tac_FormClosed(object sender, FormClosedEventArgs e)
        {
            llenar_pendientes_mes();
        }
    }
}
