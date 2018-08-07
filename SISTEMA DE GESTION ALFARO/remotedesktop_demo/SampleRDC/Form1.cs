using System;
using System.Windows.Forms;
using MSTSCLib;
using LIBRERIA;
namespace SampleRDC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CLSER escriremot = new CLSER();
        string CLAVE ="";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rdp.Server = txtServer.Text;
                rdp.UserName = txtUserName.Text;

                IMsTscNonScriptable secured = (IMsTscNonScriptable)rdp.GetOcx();
                secured.ClearTextPassword = txtPassword.Text;
                rdp.Connect();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error Connecting", "Error connecting to remote desktop " + txtServer.Text + " Error:  " + Ex.Message,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if connected before disconnecting
                if (rdp.Connected.ToString() == "1")
                    rdp.Disconnect();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error Disconnecting", "Error disconnecting from remote desktop " + txtServer.Text + " Error:  " + Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void conexiones_activas()
        {
            cmbconexion.DataSource = escriremot.llenar_ARMADOR_CORD_PARA_RECLAMOS();
            cmbconexion.DisplayMember = "nombre";
            cmbconexion.ValueMember = "VALORES";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conexiones_activas();
            DEVOLVIENDOVALORES();
        }

        void DEVOLVIENDOVALORES()
        {
            String RECUPERADO = cmbconexion.SelectedValue.ToString();
            String[] TODOS = RECUPERADO.Split('|');
            
            txtServer.Text = TODOS[0].ToString();
            txtUserName.Text = TODOS[1].ToString();
            txtPassword.Text = TODOS[2].ToString();
            CLAVE= TODOS[2].ToString();
        }
 

        private void cmbconexion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DEVOLVIENDOVALORES();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(CLAVE);
        }
    }
}