using CrystalDecisions.CrystalReports.Engine;
using LIBRERIA;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Nueva_Perdida : Form
    {
        public Nueva_Perdida()
        {
            InitializeComponent();
        }
        Clsarmador ARMA = new Clsarmador();
       
        CLSPERDIDA P = new CLSPERDIDA();
        USUARIOS U = new USUARIOS();
        CLSREPORTES REP = new CLSREPORTES();
        ClsArticulo arti = new ClsArticulo();
        private void Nueva_Perdida_Load(object sender, EventArgs e)
        {
            CMBMOTIVO.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            TXTMOTIVO.Text = CMBMOTIVO.Text;
            STPC.Text = Environment.MachineName;
            TXTCDALFA.Focus();
            LISTAR_ARMADORES();
            LLENAR_DNI();
            
        }
        private void TXTPROD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Consulta_Articulos cons = new Consulta_Articulos();
                cons.MdiParent = this.ParentForm;
                cons.Show();
                cons.FormClosed += Cons_FormClosed;

            }
        }

        private void Cons_FormClosed(object sender, FormClosedEventArgs e)
        {
            Consulta_Articulos cons = new Consulta_Articulos();
            TXTPROD.Text = VariablesGlobales.Nombreprod;
            TXTCDALFA.Text = VariablesGlobales.CodAlfa;

        }
        void GENERAR_REPORTE(Int32 CODIGO)
        {
            VISRO frm = new VISRO(); //formulario con CrystalReportViewer
            ReportDocument rpt = new ReportDocument();
            rpt.Load("C:/SI_Gestion/REPORTES/Cargo_Perdida.rpt");
            DataSet ds = new DataSet();
            DataTable dt_c = new DataTable(); //ResultSet de DB 
            DataTable dt_c2 = new DataTable(); 
            dt_c = REP.REPORTE_CARGO_X_CODPERDIDA(CODIGO);
            dt_c2 =REP.REPORTE_DETALLE_CARGO_X_CODPERDIDA(CODIGO);
            ds.Tables.Add(dt_c);
            ds.Tables.Add(dt_c2);
            rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
            rpt.Database.Tables[1].SetDataSource(ds.Tables[1]);

            ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
            frm.Refresh();  //se refresca 
                            //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                            //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
            frm.Text = "CARGO DE PERDIDA";
            frm.Show();

        }



       
        void LLENAR_DNI()
        {
            LBLDNI.Text = U.DEVUELVE_DNI(Convert.ToInt32(CMBARMADOR.SelectedValue));
        }
       

        void limpiatodo()
        {
            TXTCDALFA.Clear();
            TXTPROD.Clear();
            TXTLOTE.Clear();
            comboBox1.SelectedIndex = 0;
            CMBMOTIVO.SelectedIndex = 0;
            TXTOBS.Clear();
            DGVDATA.Rows.Clear();
    
        }
        void FORMALIZAR()
        {

            String MSJE = P.REGISTRAR_PERDIDA(dateTimePicker1.Value,TXTCDALFA.Text,TXTPROD.Text,TXTLOTE.Text,dateTimePicker2.Value,comboBox1.Text,Convert.ToInt32(NUMEROS.Value),CMBMOTIVO.Text
                ,TXTOBS.Text);
            String[] PALABRAS = MSJE.Split('|');
            for (int i = 0; i < DGVDATA.RowCount; i++)
            {
                P.Registrar_det_PERDIDA(Convert.ToInt32(PALABRAS[0].ToString()), DGVDATA.Rows[i].Cells["NOMBRE"].Value.ToString(), DGVDATA.Rows[i].Cells["DNI"].Value.ToString());
            }
            MessageBox.Show(PALABRAS[1].ToString(), "GESADIV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (PALABRAS[1].ToString() == "PERDIDA REGISTRADA")
            {
                limpiatodo();
                GENERAR_REPORTE(Convert.ToInt32(PALABRAS[0].ToString()));
            }
        }
        void LISTAR_ARMADORES()
        {
            CMBARMADOR.DataSource = ARMA.llenar_ARMADOR_CORD_PARA_RECLAMOS();
            CMBARMADOR.DisplayMember = "NOMBRE";
            CMBARMADOR.ValueMember = "IDARMADOR";
        }
      

       

      

        private void CMBMOTIVO_SelectedIndexChanged(object sender, EventArgs e)
        {
            TXTMOTIVO.Text = CMBMOTIVO.Text;
        }
       

        private void CMBARMADOR_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LLENAR_DNI();
        }

       
        private void TXTCDALFA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (TXTCDALFA.Text == "") { MessageBox.Show(this,"INGRESE CODIGO ALFA", "GESADIV", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    String msje = arti.Devuelve_Datos_Por_Cod('C', TXTCDALFA.Text);
                    if (msje == "no hay")
                    {
                        TXTPROD.Focus();
                    }
                    else
                    {
                        String[] sep = msje.Split('|');
                        TXTPROD.Text = sep[1];
                        
                    }

                
                }
            }
        }

        private void TXTPROD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (TXTPROD.Text == "") { MessageBox.Show(this,"INGRESE PRODUCTO", "GESADIV", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    TXTLOTE.Focus();
                }
            }
        }

        private void TXTLOTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (TXTLOTE.Text == "") { MessageBox.Show(this,"INGRESE LOTE", "GESADIV", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    dateTimePicker2.Focus();
                }
            }
        }

        private void dateTimePicker2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                NUMEROS.Focus();
            }
        }

        private void NUMEROS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TXTMOTIVO.Focus();
            }
        }

        private void TXTMOTIVO_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

       

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DGVDATA.RowCount==0)
            {
                DGVDATA.Rows.Add(CMBARMADOR.Text, LBLDNI.Text);
            }
            else
            {
                int valor = 0;
                for (int i = 0; i < DGVDATA.RowCount; i++)
                {
                    if (DGVDATA.Rows[i].Cells["nombre"].Value.ToString().Equals(CMBARMADOR.Text))
                    {
                        valor = valor + 1;
                    }
                }
                if (valor==0)
                {
                    DGVDATA.Rows.Add(CMBARMADOR.Text, LBLDNI.Text);
                }
                else
                {
                    MessageBox.Show("YA ESTA AGREGADO ESTE PERSONAL AL DETALLE", VariablesGlobales.Titulo);

                }
            }
           
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { CMBMOTIVO.Visible = false; TXTMOTIVO.Clear(); }
            if (checkBox1.Checked == false) { CMBMOTIVO.Visible = true; TXTMOTIVO.Text = CMBMOTIVO.Text; TXTMOTIVO.Visible = true; }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DGVDATA.RowCount == 0) { MessageBox.Show(this, "NO HAY REGISTROS PARA ELIMINAR", "GESADIV", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                
                DGVDATA.Rows.RemoveAt(DGVDATA.CurrentRow.Index );
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            if (DGVDATA.RowCount == 0) { MessageBox.Show(this, "NO SE AGREGADO NINGUN DETALLE"); }
            else
            {
                if (TXTCDALFA.Text == "")
                {
                    MessageBox.Show(this, "INDIQUE EL CODIGO ALFA DEL PRODUCTO");

                }
                else if (TXTPROD.Text == "")
                {
                    MessageBox.Show(this, "INDIQUE EL NOMBRE PRODUCTO");
                }
                else if (TXTLOTE.Text == "")
                {
                    MessageBox.Show(this, "INDIQUE EL LOTE DEL PRODUCTO");
                }
                else
                {
                    FORMALIZAR();

                }
            }
        }
    }
}
