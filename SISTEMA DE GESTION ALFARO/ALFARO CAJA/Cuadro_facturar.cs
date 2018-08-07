using LIBRERIA;
using System;
using System.Windows.Forms;

namespace ALFARO_CAJA
{
    public partial class Cuadro_facturar : Form
    {
        public Cuadro_facturar()
        {
            InitializeComponent();
        }
        Clsarmador A = new Clsarmador();
        USUARIOS U = new USUARIOS();
        Clsarmador ARMA = new Clsarmador();
        CLSPERDIDA P = new CLSPERDIDA();
        CLSREPORTES REP = new CLSREPORTES();
        public int numero;
        private void Cuadro_facturar_Load(object sender, EventArgs e)
        {
            LBLCOD.Text=numero+"";
            STPC.Text = Environment.MachineName;
            LISTAR_ARMADORES();
            DEVOLVERDET();
            LLENAR_DNI();
            
        }


        void DEVOLVERDET()
        {
            dataGridView1.DataSource =REP.REPORTE_DETALLE_CARGO_X_CODPERDIDA(numero);
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if (dataGridView2.RowCount == 0) { MessageBox.Show("NO HAY REGISTROS PARA ELIMINAR", "GESADIV", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //else
            //{
            //    try
            //    {
            //        String MSJE = P.QUITAR_DETALLES(Convert.ToInt32(dataGridView2.CurrentRow.Cells["CODIGO"].Value));
            //        MessageBox.Show(MSJE, "GESADIV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        DEVOLVERDET();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("SELECCIONE REGISTRO PARA ELIMINAR", "GESADIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXTCDALFA.Text == "")
            {
                MessageBox.Show(this, "INDIQUE EL CODIGO ALFA DEL PRODUCTO",VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else if (TXTPROD.Text == "")
            {
                MessageBox.Show(this, "INDIQUE EL NOMBRE PRODUCTO", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TXTLOTE.Text == "")
            {
                MessageBox.Show(this, "INDIQUE EL LOTE DEL PRODUCTO", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                String MSJE = P.MODIFICAR_PERDIDA(Convert.ToInt32(LBLCOD.Text),dateTimePicker1.Value,Convert.ToChar(comboBox3.Text.Substring(0,1)), TXTCDALFA.Text, TXTPROD.Text, TXTLOTE.Text, dateTimePicker2.Value, comboBox2.Text, Convert.ToInt32(NUMEROS.Value), TXTMOTIVO.Text
               , TXTOBS.Text);
                MessageBox.Show(this,MSJE,VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String MSJE = P.FACTURAR_TOTAL_PERDIDA(Convert.ToInt32(numero));
            MessageBox.Show(this,MSJE,VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        void LLENAR_DNI()
        {
            LBLDNI.Text = U.DEVUELVE_DNI(Convert.ToInt32(comboBox1.SelectedValue));
        }
        void LISTAR_ARMADORES()
        {
            comboBox1.DataSource = ARMA.llenar_ARMADOR_CORD_PARA_RECLAMOS();
            comboBox1.DisplayMember = "NOMBRE";
            comboBox1.ValueMember = "IDARMADOR";
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int sw = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (LBLDNI.Text.Equals(dataGridView1.Rows[i].Cells["DNI"].Value.ToString()))
                {
                    sw = sw + 1;
                }
            }
            if (sw==0)
            {
                String msje = P.Registrar_det_PERDIDA(Convert.ToInt32(LBLCOD.Text), comboBox1.Text, LBLDNI.Text);
                DEVOLVERDET();
            }
            else
            {
                MessageBox.Show(this,"ESTE TRABAJADOR YA ESTA INVOLUCRADO EN LA PERDIDA",VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
         
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LLENAR_DNI();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridView1.Rows.Count==1)
            {
                MessageBox.Show(this,"NO SE PUEDE DEJAR SIN INVOLUCRADOS A LA PERDIDA AGREGUE AL INVOLUCRADO PRINCIPAL Y LUEGO ELIMINE",VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                String msje = P.ELIMINAR_DETALLE_PERDIDA(Convert.ToInt32(LBLCOD.Text), comboBox1.Text, LBLDNI.Text);
                MessageBox.Show(this,msje,VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
                DEVOLVERDET();
            }
        }

     
    }
}
