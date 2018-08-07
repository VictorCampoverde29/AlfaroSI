using LIBRERIA;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Descarga_de_Guia : Form
    {
        public Descarga_de_Guia()
        {
            InitializeComponent();
        }
        CLSDEVOLUCION DV = new CLSDEVOLUCION();
        CLSREPORTES RP = new CLSREPORTES();
        private void Descarga_de_Guia_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            if(lblclave.Text!="DESC")
            {
                this.Text = "ELEGIR GD PARA MODIFICAR:";
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (lblclave.Text == "DESC")
            {
                Detalle_de_Devolucion VEN = new Detalle_de_Devolucion();
                VEN.LBLTIPO.Text = "DESC";   
                VEN.Text = "GUIA NUMERO:" + dataGridView1.CurrentRow.Cells["NUMERO_GUIA"].Value.ToString();
                VEN.LBLESTADO.Text = dataGridView1.CurrentRow.Cells["ESTADO"].Value.ToString();
                VEN.LBLGUIA.Text = dataGridView1.CurrentRow.Cells["NUMERO_GUIA"].Value.ToString();
                VEN.LBLLINEA.Text = dataGridView1.CurrentRow.Cells["LINEA"].Value.ToString();
                VEN.LBLFECHA.Text = dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString().Substring(0,10);
                VEN.LBLFECHATRASLADO.Text = dataGridView1.CurrentRow.Cells["FECHA_TRASLADO"].Value.ToString();
                VEN.LBLREFERENCIA.Text ="FACTURA:"+ dataGridView1.CurrentRow.Cells["RFT"].Value.ToString()+
                   " GUIA:" + dataGridView1.CurrentRow.Cells["RGUIA"].Value.ToString();
                VEN.LBLTRANSPORTE.Text = dataGridView1.CurrentRow.Cells["TRANSPORTISTA"].Value.ToString();
                VEN.LBLCOD.Text = dataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString();
                VEN.dataGridView1.DataSource = RP.IMPR_GUIA_DEVOL_DETALLES(Convert.ToInt32(dataGridView1.CurrentRow.Cells["CODIGO"].Value));
                if (VEN.LBLESTADO.Text == "ANULADA") { VEN.PANELDESCARGAR.Visible = false; }
                else if (VEN.LBLESTADO.Text == "TRASLADADA") { VEN.PANELDESCARGAR.Visible = false; }
                else { VEN.PANELDESCARGAR.Visible = true; }
                VEN.MdiParent = this.ParentForm;
                VEN.Show();
                VEN.FormClosed += VEN_FormClosed;
            }
            else
            {
                Modificar_GD VEN2 = new Modificar_GD();
                VEN2.NUMERO = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CODIGO"].Value);
                VEN2.NUMERO_GUIA = dataGridView1.CurrentRow.Cells["NUMERO_GUIA"].Value.ToString();
                VEN2.MdiParent = this.ParentForm;
                VEN2.STCODIGO.Text = STCODIGO.Text;
                VEN2.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                VEN2.STPERFIL.Text = STPERFIL.Text;
                VEN2.Show();
                VEN2.FormClosed += VEN2_FormClosed;

            }
        }

        private void VEN2_FormClosed(object sender, FormClosedEventArgs e)
        {
            KP_PARA_BUSQ_X_NUM_PARA_MODIFICAR();
        }

        private void VEN_FormClosed(object sender, FormClosedEventArgs e)
        {
            LLENARBUSQUEDAD();
            label4.Text = dataGridView1.RowCount + " REGISTROS";

        }

        void LLENARBUSQUEDAD()
        {
            dataGridView1.DataSource = DV.REPORTE_BUSQ_X_ESTADO('A', dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.Columns["CODIGO"].Visible = false;
            label4.Text = dataGridView1.RowCount + " REGISTROS";
        }
      


        void LLENARBUSQUEDAD_PARA_MODIFICAR()
        {
            dataGridView1.DataSource = DV.REPORTE_BUSQ_X_FECHA(dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.Columns["CODIGO"].Visible = false;
            label4.Text = dataGridView1.RowCount + " REGISTRO(S)";

        }

        void KP_PARA_BUSQ_X_NUM_PARA_MODIFICAR()
        {
            dataGridView1.DataSource = DV.REPORTE_BUSQ_X_NUMERO(textBox2.Text);
            dataGridView1.Columns["CODIGO"].Visible = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (lblclave.Text == "DESC")
                {
                    dataGridView1.DataSource = DV.REPORTE_DESCARGA_X_NUMERO(textBox2.Text);
                    dataGridView1.Columns["CODIGO"].Visible = false;
                }
                else
                {
                    KP_PARA_BUSQ_X_NUM_PARA_MODIFICAR();
                }
             
            }
            label4.Text = dataGridView1.RowCount + " REGISTRO(S)";
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                label4.Visible = true;
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                label4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblclave.Text == "DESC")
            {
                LLENARBUSQUEDAD();

            }
            else
            {
                LLENARBUSQUEDAD_PARA_MODIFICAR();

            }
        }
    }
}
