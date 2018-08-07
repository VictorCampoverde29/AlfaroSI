using System;
using System.Data;
using System.Windows.Forms;
using LIBRERIA;
namespace ALFARO_CAJA
{
    public partial class Asignar_Permisos : Form
    {
        public Asignar_Permisos()
        {
            InitializeComponent();
        }
        USUARIOS usu = new USUARIOS();
        CLSMENU MN = new CLSMENU();

        private void CrearNodosDelPadre(int indicePadre, TreeNode nodePadre)
        {

            DataTable dt = new DataTable();
            dt = MN.Llenar_Menus_ACTIVAR(CMBTIPOUSU.Text.Substring(0,2));
            //Creamos un Dataview apartir de los datos del DataTable
            DataView datos_hijos = new DataView(dt);
            //filtramos los datos y obtenemos los hijos del id = ?
            datos_hijos.RowFilter = dt.Columns["padre"].ColumnName + "=" + indicePadre;
            //Recorremos los datos filtrados 
            foreach (DataRowView dataRowCurrent in datos_hijos)
            {
                TreeNode nuevoNodo = new TreeNode();
                nuevoNodo.Text = dataRowCurrent["nombre"].ToString().Trim();
                nuevoNodo.Name = dataRowCurrent["idbarra_menu"].ToString().Trim();
                if (dataRowCurrent["nombre"].ToString().Trim() == "separador")
                {

                }
                else
                {
                    if (dataRowCurrent["ACCESO"].ToString().Trim() == "SI")
                    {
                        nuevoNodo.Checked = true;
                    }
                    else
                    {
                        nuevoNodo.Checked = false;
                    }
                    // si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
                    // del primer nivel que no dependen de otro nodo.
                    if (nodePadre == null)
                    {
                        treeView1.Nodes.Add(nuevoNodo);
                    }
                    // se añade el nuevo nodo al nodo padre.
                    else
                    {
                        nodePadre.Nodes.Add(nuevoNodo);
                    }

                    // Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.

                    CrearNodosDelPadre(Int32.Parse(dataRowCurrent["idbarra_menu"].ToString()), nuevoNodo);
                }
            }
        
        }

      
        private void Asignar_Permisos_Load(object sender, EventArgs e)
        {
            llena_combo();
            llenacombo_usuarios_sin_barra();
           // CMBTIPOUSU.SelectedIndex = 0;
            treeView1.ExpandAll();

        }
        void llenacombo_usuarios_sin_barra()
        {
            comboBox1.DataSource = usu.llenar_USARIOS_PDT_PERMISOS();
            comboBox1.DisplayMember = "VALORES";
            dataGridView1.DataSource = MN.Llenar_Menus("ST");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
           
        }


        private void CMBTIPOUSU_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

     



        private void check_nodos_padre(TreeNode pNode)
        {
            TreeNode NodoPadre = pNode.Parent;            
            if (NodoPadre != null) //si el nodo padre no es nulo
            {
                if (pNode.Checked == true) // si el nodo esta activado
                {
                    if (pNode.Parent != null) // si tiene padre
                    {
                        if (pNode.Checked != NodoPadre.Checked) //si el padre esta activado
                        {
                            NodoPadre.Checked = pNode.Checked;
                            //check_nodos_padre(NodoPadre);
                        }
                    }
                }
                else
                {
                    var cont = 0; //para acumular cuantos nodos hijos estan activos o desactivados
                    foreach (TreeNode node in NodoPadre.Nodes) //Recorrer todos los nodos del mismo nivel
                    {
                        cont = cont + ((node.Checked == pNode.Checked) ? 1 : 0);
                    }
                    if (cont == NodoPadre.Nodes.Count) //si el numero total de nodos hijos estan activos o desactivados
                        NodoPadre.Checked = pNode.Checked;
                    //establece el mismo estado al padre
                }
                treeView1.SelectedNode = NodoPadre;
                if (NodoPadre.Parent != null) // si el nodo padre no es nulo
                {
                    check_nodos_padre(NodoPadre.Parent);
                    // realizamos la recursividad
                }
                if (NodoPadre != null)
                {
                    NodoPadre = NodoPadre.Parent;
                }
            }
            treeView1.SelectedNode = pNode;
        }

        private void check_nodos_hijos(TreeNode pNode)

        {



            if (pNode.Nodes.Count > 0)

            {



                for (int i = 0; i < pNode.Nodes.Count; i++)

                {

                    treeView1.SelectedNode = pNode;

                    pNode.Nodes[i].Checked = pNode.Checked;



                    if (pNode.Nodes[i].Nodes.Count > 0) //el nodo tiene subnodos


                    {

                        check_nodos_hijos(pNode.Nodes[i]);

                    }

                }

            }

            treeView1.SelectedNode = pNode;

        }
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            treeView1.AfterCheck -= treeView1_AfterCheck;

            check_nodos_padre(e.Node);

            check_nodos_hijos(e.Node);

            treeView1.AfterCheck += treeView1_AfterCheck;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (TreeNode Node in treeView1.Nodes)
                {
                     Node.Checked = (checkBox1.Checked ==true) ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            treeView1.SelectedNode = treeView1.Nodes[0];
        }


        private void RecorrerNodos(TreeNode treeNode)
        {
            try
            {
                foreach (TreeNode tn in treeNode.Nodes)
                {
                    MN.ACTUALIZA_ACCESO(Convert.ToInt32(tn.Name), tn.Checked);
                    RecorrerNodos(tn);
                }
            }
            catch (Exception ex)

            {
                throw;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            int resul;
            try
            {
                foreach (TreeNode Node in treeView1.Nodes)
                {    
                    MN.ACTUALIZA_ACCESO(Convert.ToInt32(Node.Name), Node.Checked);
                    RecorrerNodos(Node);
                }
            }
            catch (Exception ex)
            {
                throw;
            }



            MessageBox.Show(this,"DATOS ACTUALIZADOS", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        void llena_combo()
        {
            CMBTIPOUSU.DataSource = usu.llenar_USARIOS_PERMISOS_ASIGNADOS();
            CMBTIPOUSU.DisplayMember = "VALORES";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CMBTIPOUSU.Items.Count == 0)
            {
                MessageBox.Show(this,"ACTIVE PERFILES",VariablesGlobales.Titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            { 
            treeView1.Nodes.Clear();
            CrearNodosDelPadre(0, null);
            DataTable dt = new DataTable();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


       
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Visible = true;
            String MSJE = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                MSJE = MN.CONFIGURACION_BASE(dataGridView1.Rows[i].Cells["descripcion"].Value.ToString(),
                                      dataGridView1.Rows[i].Cells["nombre"].Value.ToString(),
                                      Convert.ToInt32(dataGridView1.Rows[i].Cells["padre"].Value),
                                      comboBox1.Text.Substring(0, 2));

            }
            if (MSJE == "REGISTRADO")
            {
                llenacombo_usuarios_sin_barra();
             
                progressBar1.Value = 0;
                timer1.Stop();
                progressBar1.Visible = false;
                tabPage1.Select();
                MessageBox.Show(this, "CONFIGURACION BASE CARGADA,EDITE LOS PERMISOS", VariablesGlobales.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

            llenacombo_usuarios_sin_barra();
            llena_combo();
        }
    }

}


