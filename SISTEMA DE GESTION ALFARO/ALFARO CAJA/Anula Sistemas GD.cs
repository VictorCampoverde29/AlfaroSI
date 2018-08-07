using LIBRERIA;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Anula_Sistemas_GD : Form
    {
        public Anula_Sistemas_GD()
        {
            InitializeComponent();
        }

        private void Anula_Sistemas_GD_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
        }
        CLSDEVOLUCION DV = new CLSDEVOLUCION();
        CLSREPORTES RP = new CLSREPORTES();
        private void metroLink1_Click(object sender, EventArgs e)
        {
           
        }
        void LLENARBUSQUEDAD()
        {
            dataGridView1.DataSource = DV.REPORTE_BUSQ_X_ESTADO('A', dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.Columns["CODIGO"].Visible = false;
            dataGridView1.Columns["ESTADO"].Visible = false;
            dataGridView1.Columns["FECHA_TRASLADO"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Detalle_de_Devolucion VEN = new Detalle_de_Devolucion();
            VEN.Text = "GUIA NUMERO:" + dataGridView1.CurrentRow.Cells["NUMERO_GUIA"].Value.ToString();
            VEN.LBLESTADO.Text = dataGridView1.CurrentRow.Cells["ESTADO"].Value.ToString();
            VEN.LBLGUIA.Text = dataGridView1.CurrentRow.Cells["NUMERO_GUIA"].Value.ToString();
            VEN.LBLLINEA.Text = dataGridView1.CurrentRow.Cells["LINEA"].Value.ToString();
            VEN.LBLFECHA.Text = dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString();
            VEN.LBLFECHATRASLADO.Text = dataGridView1.CurrentRow.Cells["FECHA_TRASLADO"].Value.ToString();
            VEN.LBLREFERENCIA.Text = dataGridView1.CurrentRow.Cells["MOTIVO"].Value.ToString();
            VEN.LBLTRANSPORTE.Text = dataGridView1.CurrentRow.Cells["TRANSPORTISTA"].Value.ToString();
            VEN.LBLCOD.Text = dataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString();
            VEN.dataGridView1.DataSource = RP.IMPR_GUIA_DEVOL_DETALLES(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CODIGO"].Value));
            VEN.PANELDESCARGAR.Visible = false;
            VEN.MdiParent = this.ParentForm;
            VEN.Show(this);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dataGridView1.DataSource = DV.REPORTE_BUSQ_X_NUMERO(textBox1.Text);
                dataGridView1.Columns["CODIGO"].Visible = false;
                dataGridView1.Columns["ESTADO"].Visible = false;
                dataGridView1.Columns["FECHA_TRASLADO"].Visible = false;
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView1.RowCount == 0 || STCODIGO.Text != "ADM01")
            { }
            else
            {
                if ((int)e.KeyChar == (int)Keys.E)
                {
                    DialogResult result = MessageBox.Show(this,"GS:" + dataGridView1.CurrentRow.Cells["NUMERO_GUIA"].Value.ToString() + Environment.NewLine + "LINEA:" + dataGridView1.CurrentRow.Cells["LINEA"].Value.ToString() + Environment.NewLine + "TRANSPORTE:" + dataGridView1.CurrentRow.Cells["TRANSPORTISTA"].Value.ToString() + Environment.NewLine + "¿DESEA ELIMINAR LA DEVOLUCION?",VariablesGlobales.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show(this,DV.ANULAR_GUIA_SISTEMAS(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString())), VariablesGlobales.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        LLENARBUSQUEDAD();
                    }
                    else
                    {

                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LLENARBUSQUEDAD();
        }
    }
}
