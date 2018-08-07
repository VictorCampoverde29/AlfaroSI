using CrystalDecisions.CrystalReports.Engine;
using LIBRERIA;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SampleRDC;

namespace ALFARO_CAJA
{
    public partial class M_PRINCIPAL : Form
    {
        public M_PRINCIPAL()
        {
            InitializeComponent();
        }
        public String TIPOUSUARIO;
        CLSMENU MN = new CLSMENU();
        CLSLLAMADAS LL = new CLSLLAMADAS();
        Clscaja cj = new Clscaja();
        CLSREPORTES REP = new CLSREPORTES();
        CLSPERDIDA PR = new CLSPERDIDA();
        USUARIOS U = new USUARIOS();

        private void M_PRINCIPAL_Load(object sender, EventArgs e)
        {
          
            STPC.Text = Environment.MachineName;
            switch (TIPOUSUARIO)
            {
                case "ST":
                    STPERFIL.Text = "SISTEMAS";
                    break;
                case "RC":
                    STPERFIL.Text = "RECEPCION";
                    break;
                case "IN":
                    STPERFIL.Text = "INGRESOS";
                    break;
                case "GR":
                    STPERFIL.Text = "GERENCIA";
                    break;
                case "TL":
                    STPERFIL.Text = "TELEMARKETING";
                    break;
                case "QF":
                    STPERFIL.Text = "QUIMICA F.";
                    break;
                case "AD":
                    STPERFIL.Text = "ADMINISTRADOR(A)";
                    break;
            }
            llenar_menu(0,null, barramenu);
        }

        

        private void llenar_menu(int codigopapa, ToolStripMenuItem papa,MenuStrip mst)
        {
            DataTable dt = new DataTable();
            dt = MN.Llenar_Menus(TIPOUSUARIO);
           
            //Creamos un Dataview apartir de los datos del DataTable
            DataView datos_hijos = new DataView(dt);
            //filtramos los datos y obtenemos los hijos del id = ?
            datos_hijos.RowFilter = dt.Columns["padre"].ColumnName + "=" + codigopapa;
            //Recorremos los datos filtrados 
            foreach (DataRowView fila in datos_hijos)
            {
                //Declaramos un nuevo item hijo
                ToolStripMenuItem menu_hijo = new ToolStripMenuItem();
                //Texto a mostrar en el Item
                menu_hijo.Text = fila["descripcion"].ToString();
                //Nombre a asignar al Item
                menu_hijo.Name = fila["idbarra_menu"].ToString();
                menu_hijo.Tag= fila["nombre"].ToString();
                if (fila["descripcion"].ToString().Equals("separador"))
                {
                    papa.DropDownItems.Add(new ToolStripSeparator());
                }
                else
                {


                    if (papa == null)
                    {

                        //Agregamos como item Raiz
                        mst.Items.Add(menu_hijo);


                    }
                    else
                    {


                        //Agregamos un item a otro item
                        papa.DropDownItems.Add(menu_hijo);
                    }
                    //Llamamos al metodo para verificar si tiene mas hijos
                    llenar_menu(Int32.Parse(fila["idbarra_menu"].ToString()), menu_hijo, barramenu);
                }
                menu_hijo.Click += new EventHandler(Listado_Eventos);
            }
        }

        public void Listado_Eventos(object sender, EventArgs e)//Evento Generico de Cada item
   {
       ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
       String Opcion=clickedItem.Tag.ToString();
            switch (Opcion)
            {
                case "Salir":
                                this.Close();
                   break;
                case "Series y Correlativos":
                    SERIES VEN = new SERIES();
                    VEN.MdiParent = this;
                    VEN.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    VEN.STPERFIL.Text = STPERFIL.Text;
                    VEN.STCODIGO.Text = STCODIGO.Text;
                    VEN.Show();
                    break;
                case "Asigna Permisos":
                    Asignar_Permisos AP = new Asignar_Permisos();
                    AP.MdiParent = this;
                    AP.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    AP.STPERFIL.Text = STPERFIL.Text;
                    AP.STCODIGO.Text = STCODIGO.Text;
                    AP.Show();
                    break;
                case "Usuarios":
                    USUARIO usu = new USUARIO();
                    usu.MdiParent = this;
                    usu.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    usu.STPERFIL.Text = STPERFIL.Text;
                    usu.STCODIGO.Text = STCODIGO.Text;
                    usu.Show();
                    break;
                case "Personal":
                    MANT_PERSONAL PER = new MANT_PERSONAL();
                    PER.MdiParent = this;
                    PER.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    PER.STPERFIL.Text = STPERFIL.Text;
                    PER.STCODIGO.Text = STCODIGO.Text;
                    PER.Show();
                    break;

                case "Cambio de Usuario":
                    LOGIN CU = new LOGIN();
                    this.Hide();
                    CU.Show();
                    break;

                case "Cliente":
                    NUEVO_DIRECTORIO ND = new NUEVO_DIRECTORIO();
                    ND.MdiParent = this;
                    ND.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    ND.STPERFIL.Text = STPERFIL.Text;
                    ND.STCODIGO.Text = STCODIGO.Text;
                    ND.Show();
                    break;

                case "Contacto":
                    NUEVO_CONTACTO NC = new NUEVO_CONTACTO();
                    NC.MdiParent = this;
                    NC.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    NC.STPERFIL.Text = STPERFIL.Text;
                    NC.STCODIGO.Text = STCODIGO.Text;
                    NC.Show();
                    break;

                case "Consultar Directorio":
                    CONSULTA_DIRcs CD = new CONSULTA_DIRcs();
                    CD.MdiParent = this;
                    CD.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    CD.STPERFIL.Text = STPERFIL.Text;
                    CD.STCODIGO.Text = STCODIGO.Text;
                    CD.Show();
                    break;

                case "Nueva Actividad":
                    Nueva_Actividad NAC = new Nueva_Actividad();
                    NAC.MdiParent = this;
                    NAC.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    NAC.STPERFIL.Text = STPERFIL.Text;
                    NAC.STCODIGO.Text = STCODIGO.Text;
                    NAC.Show();
                    break;

                case "Editar Actividad":
                    Modificar_actividades MA = new Modificar_actividades();
                    MA.MdiParent = this;
                    MA.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    MA.STPERFIL.Text = STPERFIL.Text;
                    MA.STCODIGO.Text = STCODIGO.Text;
                    MA.Show();
                    break;

                case "Consultar Actividades Pendiente":
                    Consulta_Actividades CAP = new Consulta_Actividades();
                    CAP.MdiParent = this;
                    CAP.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    CAP.STPERFIL.Text = STPERFIL.Text;
                    CAP.STCODIGO.Text = STCODIGO.Text;
                    CAP.Show();
                    break;

                case "Generar Reporte de Terminadas":
                    GenerarReporteActiv GRPT = new GenerarReporteActiv();
                    GRPT.MdiParent = this;
                    GRPT.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    GRPT.STPERFIL.Text = STPERFIL.Text;
                    GRPT.STCODIGO.Text = STCODIGO.Text;
                    GRPT.Show();
                    break;

                case "Registrar Visita":
                    Nueva_Visita NV = new Nueva_Visita();
                    NV.MdiParent = this;
                    NV.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    NV.STPERFIL.Text = STPERFIL.Text;
                    NV.STCODIGO.Text = STCODIGO.Text;
                    NV.Show();
                    break;

                case "Registrar Descarga":
                    Nueva_Descarga RD = new Nueva_Descarga();
                    RD.MdiParent = this;
                    RD.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    RD.STPERFIL.Text = STPERFIL.Text;
                    RD.STCODIGO.Text = STCODIGO.Text;
                    RD.Show();
                    break;

                case "Editar Visita":
                    Mantenimiento_Visitas MV = new Mantenimiento_Visitas();
                    MV.MdiParent = this;
                    MV.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    MV.STPERFIL.Text = STPERFIL.Text;
                    MV.STCODIGO.Text = STCODIGO.Text;
                    MV.Show();
                    break;

                case "Editar Descarga":
                    Mantenimiento_Descargas_Visitas MDS = new Mantenimiento_Descargas_Visitas();
                    MDS.MdiParent = this;
                    MDS.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    MDS.STPERFIL.Text = STPERFIL.Text;
                    MDS.STCODIGO.Text = STCODIGO.Text;
                    MDS.Show();
                    break;

                case "Consulta Descargas y Visitas":
                    CONSULTA_RECEPCION CR = new CONSULTA_RECEPCION();
                    CR.MdiParent = this;
                    CR.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    CR.STPERFIL.Text = STPERFIL.Text;
                    CR.STCODIGO.Text = STCODIGO.Text;
                    CR.Show();
                    break;

                case "Registrar Dia":
                    Cuadro_de_Menu CM = new Cuadro_de_Menu();
                    CM.MdiParent = this;
                    CM.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    CM.STPERFIL.Text = STPERFIL.Text;
                    CM.STCODIGO.Text = STCODIGO.Text;
                    CM.Show();
                    break;

                case "Editar Dia":
                    Modifica_menu MM = new Modifica_menu();
                    MM.MdiParent = this;
                    MM.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    MM.STPERFIL.Text = STPERFIL.Text;
                    MM.STCODIGO.Text = STCODIGO.Text;
                    MM.Show();
                    break;

                case "Reporte de Menu":
                    Generar_Reporte_de_Comida GRM = new Generar_Reporte_de_Comida();
                    GRM.MdiParent = this;
                    GRM.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    GRM.STPERFIL.Text = STPERFIL.Text;
                    GRM.STCODIGO.Text = STCODIGO.Text;
                    GRM.Show();
                    break;

                case "Registrar Memorandum":
                    NUEVO_MEMORANDUN NM = new NUEVO_MEMORANDUN();
                    NM.MdiParent = this;
                    NM.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    NM.STPERFIL.Text = STPERFIL.Text;
                    NM.STCODIGO.Text = STCODIGO.Text;
                    NM.Show();
                    break;

                case "Modificar Memorandum":
                    MOIFICAR_MEMORANDUM MFM = new MOIFICAR_MEMORANDUM();
                    MFM.MdiParent = this;
                    MFM.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    MFM.STPERFIL.Text = STPERFIL.Text;
                    MFM.STCODIGO.Text = STCODIGO.Text;
                    MFM.Show();
                    break;

                case "Reporte Memorandum":
                    REPORTE_DE_MEMORANDUM_POR_FECHA RPM = new REPORTE_DE_MEMORANDUM_POR_FECHA();
                    RPM.MdiParent = this;
                    RPM.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    RPM.STPERFIL.Text = STPERFIL.Text;
                    RPM.STCODIGO.Text = STCODIGO.Text;
                    RPM.Show();
                    break;

                case "Cuadro de Llamadas":
                    Llamadas_Telemarketing M = new Llamadas_Telemarketing();
                    M.MdiParent = this;
                    M.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    M.STPERFIL.Text = STPERFIL.Text;
                    M.STCODIGO.Text = STCODIGO.Text;
                    M.Show();
                    break;

                case "Seguimiento de Llamadas":
                    Seguimiento_de_Llamadas SLL = new Seguimiento_de_Llamadas();
                    SLL.MdiParent = this;
                    SLL.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    SLL.STPERFIL.Text = STPERFIL.Text;
                    SLL.STCODIGO.Text = STCODIGO.Text;
                    SLL.Show();
                    break;

                case "Sistemas Caja":
                    SistemasCaja SC = new SistemasCaja();
                    SC.MdiParent = this;
                    SC.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    SC.STPERFIL.Text = STPERFIL.Text;
                    SC.STCODIGO.Text = STCODIGO.Text;
                    SC.Show();
                    break;

                case "Reporte Torta":
                    SELECCION_TORTA ST = new SELECCION_TORTA();
                    ST.MdiParent = this;
                    ST.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    ST.STPERFIL.Text = STPERFIL.Text;
                    ST.STCODIGO.Text = STCODIGO.Text;
                    ST.Show();
                    break;

                case "Reporte Estadistico":
                    GASTOS_POR_CATEGORIA_PROVEEDOR GEPC = new GASTOS_POR_CATEGORIA_PROVEEDOR();
                    GEPC.MdiParent = this;
                    GEPC.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    GEPC.STPERFIL.Text = STPERFIL.Text;
                    GEPC.STCODIGO.Text = STCODIGO.Text;
                    GEPC.Show();
                    break;

                case "Reporte de Caja":
                    GENERA_RPT_CAJA_CHICA RPTCCH = new GENERA_RPT_CAJA_CHICA();
                    RPTCCH.MdiParent = this;
                    RPTCCH.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    RPTCCH.STPERFIL.Text = STPERFIL.Text;
                    RPTCCH.STCODIGO.Text = STCODIGO.Text;
                    RPTCCH.Show();
                    break;

                case "Aperturar Caja":
                    ABRIR_CAJA APC = new ABRIR_CAJA();
                    APC.MdiParent = this;
                    APC.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    APC.STPERFIL.Text = STPERFIL.Text;
                    APC.STCODIGO.Text = STCODIGO.Text;
                    APC.Show();
                    break;

                case "Consultar Caja":
                    Consulta_de_Caja CONC = new Consulta_de_Caja();
                    CONC.MdiParent = this;
                    CONC.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    CONC.STPERFIL.Text = STPERFIL.Text;
                    CONC.STCODIGO.Text = STCODIGO.Text;
                    CONC.Show();
                    break;

                case "Mantenimiento Caja":
                    Elije_Caja EC = new Elije_Caja();
                    EC.MdiParent = this;
                    EC.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    EC.STPERFIL.Text = STPERFIL.Text;
                    EC.STCODIGO.Text = STCODIGO.Text;
                    EC.Show();
                    EC.STCODIGO.Text = STCODIGO.Text;
                    EC.DGVDATA.DataSource = cj.Devolver_cajas_usuario(STCODIGO.Text);
                    EC.DGVDATA.Columns["CODIGO"].Visible = false;
                    break;

                case "Nueva Guia Devolucion":
                   
                        NUEVA_DEVOLUCION NDV = new NUEVA_DEVOLUCION();
                        NDV.MdiParent = this;
                        NDV.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                        NDV.STPERFIL.Text = STPERFIL.Text;
                        NDV.STCODIGO.Text = STCODIGO.Text;
                        NDV.Show();
                    
                    break;

                case "Modificar Guia Devolucion":
                    Descarga_de_Guia MGD = new Descarga_de_Guia();
                    MGD.MdiParent = this;
                    MGD.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    MGD.STPERFIL.Text = STPERFIL.Text;
                    MGD.STCODIGO.Text = STCODIGO.Text;
                    MGD.lblclave.Text = "MODI";
                    MGD.Show();
                    break;

                case "Consultas Devoluciones":
                    Consulta_Devoluciones CDV = new Consulta_Devoluciones();
                    CDV.MdiParent = this;
                    CDV.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    CDV.STPERFIL.Text = STPERFIL.Text;
                    CDV.STCODIGO.Text = STCODIGO.Text;
                    CDV.Show();
                    break;

                case "Anular Guia Devolucion":
                    Anula_GD AGD = new Anula_GD();
                    AGD.MdiParent = this;
                    AGD.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    AGD.STPERFIL.Text = STPERFIL.Text;
                    AGD.STCODIGO.Text = STCODIGO.Text;
                    AGD.Show();
                    break;

                case "Generar Actas":
                    GENERAR_ACTAS_DE_ASEGURAMIENTO GRA = new GENERAR_ACTAS_DE_ASEGURAMIENTO();
                    GRA.MdiParent = this;
                    GRA.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    GRA.STPERFIL.Text = STPERFIL.Text;
                    GRA.STCODIGO.Text = STCODIGO.Text;
                    GRA.Show();
                    break;

                case "Anular BD":
                    Anula_Sistemas_GD ANBD = new Anula_Sistemas_GD();
                    ANBD.MdiParent = this;
                    ANBD.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    ANBD.STPERFIL.Text = STPERFIL.Text;
                    ANBD.STCODIGO.Text = STCODIGO.Text;
                    ANBD.Show();
                    break;

                case "Descargar Guias":
                    Descarga_de_Guia DGUIA = new Descarga_de_Guia();
                    DGUIA.Text = "DESCARGA DE GUIAS";
                    DGUIA.MdiParent = this;
                    DGUIA.lblclave.Text = "DESC";
                    DGUIA.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    DGUIA.STPERFIL.Text = STPERFIL.Text;
                    DGUIA.STCODIGO.Text = STCODIGO.Text;
                    DGUIA.Show();
                    break;


                case "Reportes Devoluciones":
                    Consulta_Devoluciones REPDV = new Consulta_Devoluciones();
                    REPDV.checkBox1.Text = "RPT. GENERAL";
                    REPDV.Text = "REPORTES PARA GUIAS DE DEVOLUCION"; REPDV.LBLVALOR.Text = "REPORTE";
                    REPDV.Size = new Size(831, 268);
                    REPDV.groupBox7.Visible = false;
                    REPDV.MdiParent = this;
                    REPDV.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    REPDV.STPERFIL.Text = STPERFIL.Text;
                    REPDV.STCODIGO.Text = STCODIGO.Text;
                    REPDV.Show();
                    break;

                case "Mantenimiento Laboratorio":
                    Nuevo_Laboratorio NLAB = new Nuevo_Laboratorio();
                    NLAB.MdiParent = this;
                    NLAB.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    NLAB.STPERFIL.Text = STPERFIL.Text;
                    NLAB.STCODIGO.Text = STCODIGO.Text;
                    NLAB.Show();
                    break;

                case "Mantenimiento Transportista":
                    Mantenimiento_de_Transporte MTR = new Mantenimiento_de_Transporte();
                    MTR.MdiParent = this;
                    MTR.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    MTR.STPERFIL.Text = STPERFIL.Text;
                    MTR.STCODIGO.Text = STCODIGO.Text;
                    MTR.Show();
                    break;

                case "Re-Impresion de Guias":
                    Re_Imprimir_Guias rig = new Re_Imprimir_Guias();
                    rig.PERFIL = STPERFIL.Text;
                    rig.MdiParent = this;
                    rig.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    rig.STPERFIL.Text = STPERFIL.Text;
                    rig.STCODIGO.Text = STCODIGO.Text;
                    rig.Show();
                    break;

                case "Formato Transporte":
                    Formato_Transportista FTP = new Formato_Transportista();
                    FTP.MdiParent = this;
                    FTP.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    FTP.STPERFIL.Text = STPERFIL.Text;
                    FTP.STCODIGO.Text = STCODIGO.Text;
                    FTP.Show();
                    break;

                case "Registrar Perdida":
                    Nueva_Perdida NP = new Nueva_Perdida();
                    NP.MdiParent = this;
                    NP.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    NP.STPERFIL.Text = STPERFIL.Text;
                    NP.STCODIGO.Text = STCODIGO.Text;
                    NP.Show();
                    break;


                case "Mantenimiento Perdida":
                    FACTURAR_X_TRABAJADOR MP = new FACTURAR_X_TRABAJADOR();
                    MP.MdiParent = this;
                    MP.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    MP.STPERFIL.Text = STPERFIL.Text;
                    MP.STCODIGO.Text = STCODIGO.Text;
                    MP.Show();
                    break;

                case "Re-Impresion de Cargo":
                    CONSUL_IMPRESION_CARGO REIC = new CONSUL_IMPRESION_CARGO();
                    REIC.MdiParent = this;
                    REIC.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    REIC.STPERFIL.Text = STPERFIL.Text;
                    REIC.STCODIGO.Text = STCODIGO.Text;
                    REIC.Show();
                    break;

                case "Consultar Perdida":
                    CONSULTA_ARMADOR CP = new CONSULTA_ARMADOR();
                    CP.MdiParent = this;
                    CP.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    CP.STPERFIL.Text = STPERFIL.Text;
                    CP.STCODIGO.Text = STCODIGO.Text;
                    CP.Show();
                    break;

                case "Acceso Equipos":
                    SampleRDC.Form1 AEQ = new SampleRDC.Form1();
                    AEQ.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    AEQ.STPERFIL.Text = STPERFIL.Text;
                    AEQ.STCODIGO.Text = STCODIGO.Text;
                    AEQ.Show();
                    break;

                case "Valorado":
                    VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                    ReportDocument rpt = new ReportDocument();
                    //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\RptValorado.rpt");
                    rpt.Load("C:/SI_Gestion/REPORTES/RptValorado.rpt");
                    DataSet ds = new DataSet();
                    DataTable dt_c = new DataTable(); //ResultSet de DB
                    DataTable dt_c2 = new DataTable(); //ResultSet de DB

                    dt_c = REP.REPORTE_GENERADO();
                    dt_c2 = REP.REPORTE_GENERADO2();
                    ds.Tables.Add(dt_c);
                    ds.Tables.Add(dt_c2);
                    rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                    rpt.Database.Tables[1].SetDataSource(ds.Tables[1]);
                    rpt.SetParameterValue("usu", STCODIGO.Text);
                    ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                    frm.Refresh();  //se refresca 
                    timer1.Stop();

                    //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                    //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                    frm.Text = "REPORTE DE VALORADO DE PERDIDAS";
                    frm.MdiParent = this;
                    frm.Show();
                    break;

                case "Generar Valorado":
                    if (U.DEVUELVE_TIPO(STCODIGO.Text) == "ST")
                    {

                        DialogResult result = MessageBox.Show(this, "¿DESEA GENERAR EL VALORADO DE PRODUCTOS?", "REPORTE DE VALORADOS", MessageBoxButtons.YesNo);


                        if (result == DialogResult.Yes)
                        {
                            String MSJE = PR.FACTURAR();
                            MessageBox.Show(this, MSJE);

                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "NO TIENE PERMISOS");
                    }
                    break;

                case "Nuevo Inventario":
                    REGISTRO_INVENTARIO_PARCIAL NI = new REGISTRO_INVENTARIO_PARCIAL();
                    NI.MdiParent = this;
                    NI.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    NI.STPERFIL.Text = STPERFIL.Text;
                    NI.STCODIGO.Text = STCODIGO.Text;
                    NI.Show();                    
                    break;

                case "Mantenimiento Inventario":
                    Prod_Inventario_Sistemas PIS = new Prod_Inventario_Sistemas();
                    PIS.MdiParent = this;
                    PIS.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    PIS.STPERFIL.Text = STPERFIL.Text;
                    PIS.STCODIGO.Text = STCODIGO.Text;
                    PIS.Show();
                    break;

                case "Reportes de Inventario":
                    Reportes_Inventario RIV = new Reportes_Inventario();
                    RIV.MdiParent = this;
                    RIV.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    RIV.STPERFIL.Text = STPERFIL.Text;
                    RIV.STCODIGO.Text = STCODIGO.Text;
                    RIV.Show();
                    break;

                case "Modificar Inventario":
                    Modificar_Inventario MIV = new Modificar_Inventario();
                    MIV.MdiParent = this;
                    MIV.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    MIV.STPERFIL.Text = STPERFIL.Text;
                    MIV.STCODIGO.Text = STCODIGO.Text;
                    MIV.Show();
                    break;

                case "Mantenimiento Equipos":
                    MantenimientoER MER = new MantenimientoER();
                    MER.MdiParent = this;
                    MER.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    MER.STPERFIL.Text = STPERFIL.Text;
                    MER.STCODIGO.Text = STCODIGO.Text;
                    MER.Show();
                    break;

                case "Productos Sanitarios":
                    Liquido_Jarabe LPS = new Liquido_Jarabe();
                    LPS.MdiParent = this;
                    LPS.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    LPS.STPERFIL.Text = STPERFIL.Text;
                    LPS.STCODIGO.Text = STCODIGO.Text;
                    LPS.lbltipo.Text = "LIQUIDOS - PRODUCTOS SANITARIOS";
                    LPS.Text = "INSPECCION LIQUIDOS";
                    LPS.Show();
                    break;

                case "Jarabes":
                    Liquido_Jarabe LJ = new Liquido_Jarabe();
                    LJ.MdiParent = this;
                    LJ.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    LJ.STPERFIL.Text = STPERFIL.Text;
                    LJ.STCODIGO.Text = STCODIGO.Text;
                    LJ.lbltipo.Text = "LIQUIDOS - JARABE";
                    LJ.Text = "INSPECCION LIQUIDOS";
                    LJ.Show();
                    break;

                case "Ampollas":
                    Liquido_Jarabe LA = new Liquido_Jarabe();
                    LA.MdiParent = this;
                    LA.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    LA.STPERFIL.Text = STPERFIL.Text;
                    LA.STCODIGO.Text = STCODIGO.Text;
                    LA.lbltipo.Text = "LIQUIDOS - AMPOLLA";
                    LA.Text = "INSPECCION AMPOLLAS";
                    LA.Show();
                    break;

                case "Capsulas":
                    Liquido_Jarabe CAPS = new Liquido_Jarabe();
                    CAPS.MdiParent = this;
                    CAPS.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    CAPS.STPERFIL.Text = STPERFIL.Text;
                    CAPS.STCODIGO.Text = STCODIGO.Text;
                    CAPS.lbltipo.Text = "SOLIDOS - CAPSULAS";
                    CAPS.Text = "SOLIDOS CAPSULAS";
                    CAPS.lblcondicion.Visible = true;
                    CAPS.TXTCONDALMACENAMIENTO.Visible = true;
                    CAPS.Show();
                    break;

                case "Tabletas":
                    Liquido_Jarabe TAB = new Liquido_Jarabe();
                    TAB.MdiParent = this;
                    TAB.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    TAB.STPERFIL.Text = STPERFIL.Text;
                    TAB.STCODIGO.Text = STCODIGO.Text;
                    TAB.lbltipo.Text = "SOLIDOS - TABLETAS";
                    TAB.Text = "SOLIDOS TABLETAS";
                    TAB.lblcondicion.Visible = true;
                    TAB.TXTCONDALMACENAMIENTO.Visible = true;
                    TAB.Show();
                    break;


                case "Ovulos y cremas":
                    Liquido_Jarabe OVC = new Liquido_Jarabe();
                    OVC.MdiParent = this;
                    OVC.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    OVC.STPERFIL.Text = STPERFIL.Text;
                    OVC.STCODIGO.Text = STCODIGO.Text;
                    OVC.lbltipo.Text = "SOLIDOS - OVULOS Y CREMAS";
                    OVC.Text = "SOLIDOS OVULOS Y CREMAS";
                    OVC.lblcondicion.Visible = true;
                    OVC.TXTCONDALMACENAMIENTO.Visible = true;
                    OVC.Show();
                    break;

                case "Viales":
                    Liquido_Jarabe SVI = new Liquido_Jarabe();
                    SVI.MdiParent = this;
                    SVI.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    SVI.STPERFIL.Text = STPERFIL.Text;
                    SVI.STCODIGO.Text = STCODIGO.Text;
                    SVI.lbltipo.Text = "SOLIDOS - VIALES";
                    SVI.Text = "SOLIDOS - VIALES";
                    SVI.lblcondicion.Visible = true;
                    SVI.TXTCONDALMACENAMIENTO.Visible = true;
                    SVI.Show();
                    break;


                case "Imprimir Formatos de Inspeccion":
                    IMPRIMIR_FORMATOS_INSPECCION IFI = new IMPRIMIR_FORMATOS_INSPECCION();
                    IFI.MdiParent = this;
                    IFI.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    IFI.STPERFIL.Text = STPERFIL.Text;
                    IFI.STCODIGO.Text = STCODIGO.Text;                   
                    IFI.Show();
                    break;

                case "Editar Formatos de Inspeccion":
                    SELEC_EDITAR_FINSP SET = new SELEC_EDITAR_FINSP();
                    SET.MdiParent = this;
                    SET.STNOMBRECOMPLETO.Text = STNOMBRECOMPLETO.Text;
                    SET.STPERFIL.Text = STPERFIL.Text;
                    SET.STCODIGO.Text = STCODIGO.Text;
                    SET.Show();
                    break;


            }
          
        }

      

        private void M_PRINCIPAL_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      
    }
}
