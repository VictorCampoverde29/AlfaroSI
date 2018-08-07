using LIBRERIA;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Anula_GD : Form
    {
        public Anula_GD()
        {
            InitializeComponent();
        }
        CLSDEVOLUCION dv = new CLSDEVOLUCION();
        CLSREPORTES rp = new CLSREPORTES();
       
        CLSTRANSPORTE T = new CLSTRANSPORTE();
        private void Anula_GD_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            STPC.Text = Environment.MachineName;
            LLENAR_LINEA(); LLENAR_TRANSPORTISTA();
        }
        void LLENAR_LINEA()
        {
            CMBLINEA.DataSource =CLSLINEA.llenar_LINEAS();
            CMBLINEA.DisplayMember = "DESCRIPCION";
            CMBLINEA.ValueMember = "IDLINEA";
        }
        void LLENAR_TRANSPORTISTA()
        {
            CMBTRANSPORTISTA.DataSource = CLSTRANSPORTE.llenar_TRANSPORTISTA();
            CMBTRANSPORTISTA.DisplayMember = "NOMBRE";
            CMBTRANSPORTISTA.ValueMember = "IDTRANSPORTE";
        }
        void TRAER_DETALLES(Int32 numero)
        {
            dataGridView1.DataSource = dv.llenar_Detalles_Modificar(numero);
            dataGridView1.Columns["CODIGO"].Visible = false;
            dataGridView1.Columns["MOTIVO_FC"].Visible = false;
            dataGridView1.Columns["MOTIVO_M"].Visible = false;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dataGridView2.DataSource = dv.REPORTE_BUSQ_X_NUMERO(textBox1.Text);
                if (dataGridView2.RowCount == 0)
                {
                    MessageBox.Show(this,"NO EXISTE NINGUN REGISTRO CON ESE NUMERO",VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LBLESTADO.Text = "";
                    LBLCODIGODEV.Text = "0";
                    LBLGUIA.Text = "";
                    LBLFECHA.Text = "";
                    LBLFECHATRASLADO.Text = "";
                    CMBLINEA.SelectedIndex = 0;
                    CMBTRANSPORTISTA.SelectedIndex = 0;
                }
                else
                {
                    lblfchaigm.Text= dataGridView2.Rows[0].Cells["FECHA_INGRESO_MERCADERIA"].Value.ToString();
                    LBLGUIA.Text = dataGridView2.Rows[0].Cells["NUMERO_GUIA"].Value.ToString();
                    LBLCODIGODEV.Text = dataGridView2.Rows[0].Cells["CODIGO"].Value.ToString();
                    LBLESTADO.Text = dataGridView2.Rows[0].Cells["ESTADO"].Value.ToString();
                    LBLFECHA.Text = dataGridView2.Rows[0].Cells["FECHA"].Value.ToString().Substring(0,8);
                    if (dataGridView2.Rows[0].Cells["FECHA_TRASLADO"].Value.ToString().Equals(""))
                    {
                        LBLFECHATRASLADO.Text = "--/--/--";
                    }
                    else
                    {
                        LBLFECHATRASLADO.Text = dataGridView2.Rows[0].Cells["FECHA_TRASLADO"].Value.ToString().Substring(0, 8);
                    }
                    CMBLINEA.Text = dataGridView2.Rows[0].Cells["LINEA"].Value.ToString();
                    CMBTRANSPORTISTA.Text = dataGridView2.Rows[0].Cells["TRANSPORTISTA"].Value.ToString();
                    LBLREFFT.Text = dataGridView2.Rows[0].Cells["RFT"].Value.ToString();
                    LBLREFGUIA.Text = dataGridView2.Rows[0].Cells["RGUIA"].Value.ToString();
                }
            }
        }

        private void LBLGUIA_Click(object sender, EventArgs e)
        {

        }
        void REGISTRO_DETALLE(String UM, String DES, String CA, String LT, String CNTF, String MTFC, String MM, int CODIGO,String OB)
        {
            dv.REGISTRO_DETALLE("",UM, DES, CA, LT,"",CNTF,MTFC,MM, CODIGO,OB);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ERROR IMPRESION")
            {
                LBLNUMEROCORR.Text = dv.Devolver_numero("CHRC2", "ALFCHI021");
                DialogResult result = MessageBox.Show(this, "¿DESEA GENERAR NUEVAMENTE LA GUIA?" + Environment.NewLine + "NUEVO CORRELATIVO:" + LBLNUMEROCORR.Text, VariablesGlobales.Titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    int MSJE = dv.REGISTRO_DEV(LBLREFFT.Text, LBLREFGUIA.Text, Convert.ToInt32(CMBTRANSPORTISTA.SelectedValue), Convert.ToInt32(CMBLINEA.SelectedValue), STCODIGO.Text, LBLNUMEROCORR.Text, "----", Convert.ToDateTime(lblfchaigm.Text));
                    if (MSJE == 0)
                    {
                        MessageBox.Show(this, "HUBO UN ERROR NO SE PUEDE REGISTRAR COMUNIQUESE CON EL AREA DE SISTEMAS",VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(this, dv.ANULAR_GUIA(Convert.ToInt32(LBLCODIGODEV.Text), comboBox1.Text),VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            REGISTRO_DETALLE(dataGridView1.Rows[i].Cells["UNDM"].Value.ToString(),
                                dataGridView1.Rows[i].Cells["DESCRIPCION"].Value.ToString(),
                                dataGridView1.Rows[i].Cells["CANT.DEV"].Value.ToString(),
                                dataGridView1.Rows[i].Cells["LOTE"].Value.ToString(),
                                dataGridView1.Rows[i].Cells["CANT_FAC"].Value.ToString(),
                                dataGridView1.Rows[i].Cells["MOTIVO_FC"].Value.ToString(),
                                dataGridView1.Rows[i].Cells["MOTIVO_M"].Value.ToString(),
                                MSJE, dataGridView1.Rows[i].Cells["OBSV"].Value.ToString());
                        }

                        MessageBox.Show(this, "SE GENERO LA NUEVA GUIA",VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);

                        IMPRESION_REPORTES VEN = new IMPRESION_REPORTES();
                        VEN.Text = "RE-IMPRESION GUIA DEVOLUCION";
                        VEN.reportViewer1.LocalReport.ReportEmbeddedResource = @"ALFARO_CAJA.REPORTES.G_Devolucion.rdlc";
                        ReportParameter[] parametros = new ReportParameter[1];
                        parametros[0] = new ReportParameter("USU", STCODIGO.Text);
                        VEN.reportViewer1.LocalReport.SetParameters(parametros);
                        VEN.reportViewer1.RefreshReport();
                        ReportDataSource rds = new ReportDataSource("DATOS_DEVO", rp.IMPR_GUIA_D(MSJE));
                        ReportDataSource rds1 = new ReportDataSource("Detalles_devo", rp.IMPR_GUIA_DEVOL_DETALLES(MSJE));
                        VEN.reportViewer1.LocalReport.DataSources.Clear();
                        VEN.reportViewer1.LocalReport.DataSources.Add(rds);
                        VEN.reportViewer1.LocalReport.DataSources.Add(rds1);
                        VEN.reportViewer1.RefreshReport();
                        VEN.Show();
                        this.Hide();

                    }
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("DESEA ANULAR LA GUIA N°:" + LBLGUIA.Text, "ANULAR GUIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {

                        MessageBox.Show(this, dv.ANULAR_GUIA(Convert.ToInt32(LBLCODIGODEV.Text), comboBox1.Text),VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LBLESTADO.Text = "";
                        LBLCODIGODEV.Text = "0";
                        LBLGUIA.Text = "";
                        LBLFECHA.Text = "";
                        LBLFECHATRASLADO.Text = "";
                        CMBLINEA.Text = "";
                        CMBTRANSPORTISTA.Text = "";
                    }
                }
            }

        


    }

        private void LBLCODIGODEV_TextChanged(object sender, EventArgs e)
        {
            TRAER_DETALLES(Convert.ToInt32(LBLCODIGODEV.Text));
        }

        private void LBLESTADO_TextChanged(object sender, EventArgs e)
        {
            if (LBLESTADO.Text == "--------") { button1.Visible = false; }
            if (LBLESTADO.Text == "ANULADA") { button1.Visible = false; }
            if (LBLESTADO.Text == "REGISTRADA") { button1.Visible = true; }
            if (LBLESTADO.Text == "TRANSLADADA") { button1.Visible = true; }
        }

     
    }
}
