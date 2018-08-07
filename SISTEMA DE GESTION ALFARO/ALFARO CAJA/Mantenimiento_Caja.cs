
using CrystalDecisions.CrystalReports.Engine;
using LIBRERIA;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Mantenimiento_Caja : Form
    {
        public Mantenimiento_Caja()
        {
            InitializeComponent();
        }
        ClsProveedor pv = new ClsProveedor();
        CLSREPORTES REP = new CLSREPORTES();
        Clscaja cj = new Clscaja();

       
        public int cod_caja;
        private void Mantenimiento_Caja_Load(object sender, EventArgs e)
        {
            STPC.Text = Environment.MachineName;
            CMBDOC.SelectedIndex = 0;
            llenar_cmbprov();
            CONTAR_REGISTROS();

        }


        void CONTAR_REGISTROS()
        {
            double MONTOS = 0;
            for (int i = 0; i < DGVDATA.RowCount; i++)
            {
                MONTOS = MONTOS + Convert.ToDouble(DGVDATA.Rows[i].Cells["MONTO"].Value);
            }
            LBLTOTALCONTEO.Text = "TOTAL DE ITEMS:" + DGVDATA.RowCount + " GASTO TOTAL:" + "S/." + MONTOS;
        }
        void llenar_cmbprov()
        {
            cmbprov.DataSource = pv.llenar_prov();
            cmbprov.DisplayMember = "RAZON_SOCIAL";
            cmbprov.ValueMember = "idprovedor";

        }
     
        void GENERAR_REPORTE()
        {
     
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            rpt.Load("C:/SI_Gestion/REPORTES/Caja_Chica.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB
            dt_c = REP.LISTAR_DETALLES_CAJAS_USUARIOS(Convert.ToInt32(LBLCODIGO.Text));
            ds.Tables.Add(dt_c);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.SetParameterValue("usu", STCODIGO.Text);
            rpt.SetParameterValue("numero", Convert.ToInt32(LBLCODIGO.Text));
            rpt.SetParameterValue("ap", LBLFECHA.Text);
            rpt.SetParameterValue("descrip", LBLNOMBRECAJA.Text);
            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "REPORTE DE CAJA CHICA";
            frm.MdiParent = this.ParentForm;
            frm.Show();

        }
        void AGREGAR()
        {
            char documento;
            if (CMBDOC.SelectedIndex == 0) { documento = 'F'; }
            else if (CMBDOC.SelectedIndex == 1) { documento = 'B'; }
            else if (CMBDOC.SelectedIndex == 2) { documento = 'R'; } else { documento = 'T'; }
            String msje = cj.Registrar_det_cajas(Convert.ToInt32(cmbprov.SelectedValue), Convert.ToInt32(LBLCODIGO.Text), TXTDESCRIPCION.Text,
                documento, Convert.ToDecimal(TXTMONTO.Text), TXTNUMERO.Text);
            MessageBox.Show(this,msje,VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGVDATA.DataSource = cj.Devolver_detalle_cajas_id(Convert.ToInt32(LBLCODIGO.Text));
            if (msje == "DETALLE REGISTRADO")
            {
                TXTMONTO.Clear();
                TXTDESCRIPCION.Clear();
                TXTNUMERO.Clear();
                CMBDOC.SelectedIndex = 0;
                cmbprov.SelectedIndex = 0;
                checkBox1.Checked = false;
                CONTAR_REGISTROS();
            }
        }
        private void TXTMONTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TXTMONTO.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (TXTMONTO.Text == "")
                { MessageBox.Show(this, "INGRESE PRECIO DEL GASTO",VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information); }
                else
                {
                    AGREGAR();
                }
            }
        }

        private void BTNCAMBIARESTADO_Click(object sender, EventArgs e)
        {
            String MSJ = cj.CAMBIAR_ESTADO(Convert.ToInt32(LBLCODIGO.Text));
            MessageBox.Show(this, MSJ, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            LBLESTADO.Text = "APERTURADA";
            BTNLIQUIDAR.Visible = true;
            BTNCAMBIARESTADO.Visible = false;
            TXTMONTO.Visible = true;
            linkLabel3.Visible = true;
        }

        private void BTNLIQUIDAR_Click(object sender, EventArgs e)
        {
            if (DGVDATA.RowCount == 0)
            {
                MessageBox.Show(this, "NO SE HA INGRESADO NINGUN DETALLE PARA ESTA CAJA", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                String MSJ = cj.LIQUIDAR(Convert.ToInt32(LBLCODIGO.Text));
                MessageBox.Show(this, MSJ, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                GENERAR_REPORTE();
                this.Hide();
            }
        }

        private void cmbprov_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CMBDOC.Focus();
            }
        }

        private void CMBDOC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTNUMERO.Focus();
            }
        }

        private void TXTNUMERO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTDESCRIPCION.Focus();
            }
        }

        private void TXTDESCRIPCION_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTMONTO.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TXTDESCRIPCION.Text = "MOVILIDAD PARA ENVIO DE PEDIDO A ";
            }
            else
            {
                TXTDESCRIPCION.Clear();
            }
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nuevo_Proveedor PROV = new Nuevo_Proveedor();
            PROV.STCODIGO.Text = STCODIGO.Text;
            PROV.MdiParent = this.ParentForm;
            PROV.STCODIGO.Text = STCODIGO.Text;
            PROV.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
            PROV.STPERFIL.Text = STPERFIL.Text;
            PROV.Show();
            PROV.FormClosed += PROV_FormClosed;
        }

        private void PROV_FormClosed(object sender, FormClosedEventArgs e)
        {
            llenar_cmbprov();
        }

        private void BTNREPORTE_Click(object sender, EventArgs e)
        {
            GENERAR_REPORTE();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DGVDATA.RowCount == 0) { MessageBox.Show("NO HAY REGISTROS PARA ELIMINAR", "GESADIV", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                try
                {
                    String MSJE = cj.QUITAR_DET(Convert.ToInt32(DGVDATA.CurrentRow.Cells["id_detalle"].Value));
                    MessageBox.Show(MSJE, VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGVDATA.DataSource = cj.Devolver_detalle_cajas_id(Convert.ToInt32(LBLCODIGO.Text));
                    CONTAR_REGISTROS();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SELECCIONE REGISTRO PARA ELIMINAR", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
