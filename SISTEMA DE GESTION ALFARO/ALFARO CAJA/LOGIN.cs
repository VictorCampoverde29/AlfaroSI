using System;
using System.Windows.Forms;
using LIBRERIA;


namespace ALFARO_CAJA
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        Modulos mod = new Modulos();
        USUARIOS usu = new USUARIOS();
        CLSLLAMADAS LL = new CLSLLAMADAS();
        void llenarusuarios()
        {
            cmbusuario.DataSource = usu.llenar_USARIOS_LOGIN();
            cmbusuario.DisplayMember = "IDUSUARIO";
            cmbusuario.ValueMember = "CLAVE";
        }
        private void LOGIN_Load(object sender, EventArgs e)
        {
            timer1.Start();
            llenarusuarios();
            lblversion.Text = "VERSION:"+ Application.ProductVersion;
            txtclave.Focus();
        }

        private void cmbusuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtclave.Focus();
            txtclave.Clear();
        }

        

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
   

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOGIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    String CLAVE = cmbusuario.SelectedValue.ToString();
                    if (txtclave.Text == "")
                    {
                        MessageBox.Show(this, "INGRESE CLAVE PARA CONTINUAR", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtclave.Focus();
                    }
                    else if (txtclave.Text != CLAVE)
                    {
                        MessageBox.Show(this, "CLAVE INCORRECTA",VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtclave.Focus();
                    }
                    else
                    {


                        if (txtclave.Text == CLAVE)
                        {

                            M_PRINCIPAL M = new M_PRINCIPAL();
                            M.STNOMBRECOMPLETO.Text = "PERSONAL:"+usu.DEVUELVE_NOMBRE_COMPLETO(cmbusuario.Text);
                            M.TIPOUSUARIO = usu.DEVUELVE_TIPO(cmbusuario.Text);
                            M.STCODIGO.Text= cmbusuario.Text;
                            M.Show();

                            this.Hide(); M.Text = "SISTEMA DE GESTION-SUCURSAL CHICLAYO " + Application.ProductVersion+" AÑO DE GESTION:"+"2018";

                        }
                    }
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message.ToString());

                }
            }
        }

    
    }
}
