using System;

using System.Windows.Forms;
using LIBRERIA;
using Microsoft.Reporting.WinForms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data;

namespace ALFARO_CAJA
{
    public partial class IMPRIMIR_FORMATOS_INSPECCION : Form
    {
        public IMPRIMIR_FORMATOS_INSPECCION()
        {
            InitializeComponent();
        }
        ClsInspeccion insp = new ClsInspeccion();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = insp.VER_INSPECCION_X_CATEG(comboBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            IMPRESION_REPORTES VEN = new IMPRESION_REPORTES();
            ReportParameter[] parametros = new ReportParameter[2];
            if (comboBox1.Text.Equals("LIQUIDOS - JARABE"))
            {
 
                timer1.Start();
                VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                ReportDocument rpt = new ReportDocument();
                //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\LIQJARA.rpt");
                rpt.Load("C:/SI_Gestion/REPORTES/LIQJARA.rpt");
                DataSet ds = new DataSet();
                DataTable dt_c = new DataTable(); //ResultSet de DB
                dt_c = insp.VER_REPORTE_X_INSPECCION(Convert.ToInt32(dataGridView1.CurrentRow.Cells["COD"].Value));
                ds.Tables.Add(dt_c);
                rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                rpt.SetParameterValue("CODIGO", dataGridView1.CurrentRow.Cells["COD"].Value.ToString());
                rpt.SetParameterValue("FECHA", dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString());
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).EnableDrillDown = false;

                frm.Refresh();  //se refresca 
                timer1.Stop();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                frm.Text = "IMPRESION DE FORMATOS DE INSPECCION";
                frm.Show();
            }
            else if (comboBox1.Text.Equals("LIQUIDOS - AMPOLLA"))
            {
               
                    timer1.Start();
                    VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                    ReportDocument rpt = new ReportDocument();
                    //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\LIQAMPOLLAS.rpt");
                    rpt.Load("C:/SI_Gestion/REPORTES/LIQAMPOLLAS.rpt");
                DataSet ds = new DataSet();
                    DataTable dt_c = new DataTable(); //ResultSet de DB
                    dt_c = insp.VER_REPORTE_X_INSPECCION(Convert.ToInt32(dataGridView1.CurrentRow.Cells["COD"].Value));
                    ds.Tables.Add(dt_c);
                    rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                    rpt.SetParameterValue("CODIGO", dataGridView1.CurrentRow.Cells["COD"].Value.ToString());
                    rpt.SetParameterValue("FECHA", dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString());
                    ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                    ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).EnableDrillDown = false;

                    frm.Refresh();  //se refresca 
                    timer1.Stop();
                    progressBar1.Visible = false;
                    progressBar1.Value = 0;
                    //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                    //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                    frm.Text = "IMPRESION DE FORMATOS DE INSPECCION";
                   frm.Show();
                
            }

            else if (comboBox1.Text.Equals("LIQUIDOS - PRODUCTOS SANITARIOS"))
            {

                timer1.Start();
                VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                ReportDocument rpt = new ReportDocument();
                //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\LIQPROSANIT.rpt");
                rpt.Load("C:/SI_Gestion/REPORTES/LIQPROSANIT.rpt");
                DataSet ds = new DataSet();
                DataTable dt_c = new DataTable(); //ResultSet de DB
                dt_c = insp.VER_REPORTE_X_INSPECCION(Convert.ToInt32(dataGridView1.CurrentRow.Cells["COD"].Value));
                ds.Tables.Add(dt_c);
                rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                rpt.SetParameterValue("CODIGO", dataGridView1.CurrentRow.Cells["COD"].Value.ToString());
                rpt.SetParameterValue("FECHA", dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString());
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).EnableDrillDown = false;

                frm.Refresh();  //se refresca 
                timer1.Stop();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                frm.Text = "IMPRESION DE FORMATOS DE INSPECCION";
                frm.Show();

            }
            else if (comboBox1.Text.Equals("SOLIDOS - TABLETAS"))
            {
                timer1.Start();
                VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                ReportDocument rpt = new ReportDocument();
                //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\SOLTAB.rpt");
                rpt.Load("C:/SI_Gestion/REPORTES/SOLTAB.rpt");
                DataSet ds = new DataSet();
                DataTable dt_c = new DataTable(); //ResultSet de DB
                dt_c = insp.VER_REPORTE_X_INSPECCION(Convert.ToInt32(dataGridView1.CurrentRow.Cells["COD"].Value));
                ds.Tables.Add(dt_c);
                rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                rpt.SetParameterValue("CODIGO", dataGridView1.CurrentRow.Cells["COD"].Value.ToString());
                rpt.SetParameterValue("FECHA", dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString());
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).EnableDrillDown = false;

                frm.Refresh();  //se refresca 
                timer1.Stop();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                frm.Text = "IMPRESION DE FORMATOS DE INSPECCION";
                frm.Show();
            }
            else if (comboBox1.Text.Equals("SOLIDOS - OVULOS Y CREMAS"))
            {
                timer1.Start();
                VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                ReportDocument rpt = new ReportDocument();
                //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\SOLOVCREMA.rpt");
                rpt.Load("C:/SI_Gestion/REPORTES/SOLOVCREMA.rpt");
                DataSet ds = new DataSet();
                DataTable dt_c = new DataTable(); //ResultSet de DB
                dt_c = insp.VER_REPORTE_X_INSPECCION(Convert.ToInt32(dataGridView1.CurrentRow.Cells["COD"].Value));
                ds.Tables.Add(dt_c);
                rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                rpt.SetParameterValue("CODIGO", dataGridView1.CurrentRow.Cells["COD"].Value.ToString());
                rpt.SetParameterValue("FECHA", dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString());
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).EnableDrillDown = false;

                frm.Refresh();  //se refresca 
                timer1.Stop();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                frm.Text = "IMPRESION DE FORMATOS DE INSPECCION";
                frm.Show();
            }
            
                 else if (comboBox1.Text.Equals("SOLIDOS - VIALES"))
            {
                timer1.Start();
                VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                ReportDocument rpt = new ReportDocument();
                //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\SOLTVIALES.rpt");
                rpt.Load("C:/SI_Gestion/REPORTES/SOLTVIALES.rpt");
                DataSet ds = new DataSet();
                DataTable dt_c = new DataTable(); //ResultSet de DB
                dt_c = insp.VER_REPORTE_X_INSPECCION(Convert.ToInt32(dataGridView1.CurrentRow.Cells["COD"].Value));
                ds.Tables.Add(dt_c);
                rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                rpt.SetParameterValue("CODIGO", dataGridView1.CurrentRow.Cells["COD"].Value.ToString());
                rpt.SetParameterValue("FECHA", dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString());
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).EnableDrillDown = false;

                frm.Refresh();  //se refresca 
                timer1.Stop();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                frm.Text = "IMPRESION DE FORMATOS DE INSPECCION";
                frm.Show();
            }
            else
            {

                timer1.Start();
                VISRO frm = new VISRO(); //formulario con CrystalReportViewer
                ReportDocument rpt = new ReportDocument();
                //rpt.Load(@"C:\Users\costos\Desktop\SISTEMA DE GESTION ALFARO\ALFARO CAJA\REPORTES\SOLCAP.rpt");
                rpt.Load("C:/SI_Gestion/REPORTES/SOLCAP.rpt");
                DataSet ds = new DataSet();
                DataTable dt_c = new DataTable(); //ResultSet de DB
                dt_c = insp.VER_REPORTE_X_INSPECCION(Convert.ToInt32(dataGridView1.CurrentRow.Cells["COD"].Value));
                ds.Tables.Add(dt_c);
                rpt.Database.Tables[0].SetDataSource(ds.Tables[0]);
                rpt.SetParameterValue("CODIGO", dataGridView1.CurrentRow.Cells["COD"].Value.ToString());
                rpt.SetParameterValue("FECHA", dataGridView1.CurrentRow.Cells["FECHA"].Value.ToString());
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).ReportSource = rpt;
                ((CrystalDecisions.Windows.Forms.CrystalReportViewer)frm.Controls["crystalReportViewer1"]).EnableDrillDown = false;

                frm.Refresh();  //se refresca 
                timer1.Stop();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                //rpt.PrintOptions.PrinterName = "PRIMER_PISO";
                //rpt.PrintToPrinter(1, false, 0, 0);  //se imprime
                frm.Text = "IMPRESION DE FORMATOS DE INSPECCION";
                frm.Show();





               

            }


        }
    

        private void IMPRIMIR_FORMATOS_INSPECCION_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            STPC.Text = Environment.MachineName;
        }

       void MUESTRA_LIQUIDOS()
        {
            timer1.Start();
            progressBar1.Visible = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                IMPRESION_REPORTES VEN = new IMPRESION_REPORTES();
                ReportParameter[] parametros = new ReportParameter[2];
                VEN.Text = "IMPRESION DE FORMATOS DE INSPECCION";
                VEN.reportViewer1.LocalReport.ReportEmbeddedResource = @"ALFARO_CAJA.REPORTES.INSP_LIQUIDOS_JARABE.rdlc";
                parametros[0] = new ReportParameter("CODIGO", dataGridView1.Rows[i].Cells["COD"].Value.ToString());
                parametros[1] = new ReportParameter("FECHA", dataGridView1.Rows[i].Cells["FECHA"].Value.ToString());
                VEN.reportViewer1.LocalReport.SetParameters(parametros);
                VEN.reportViewer1.RefreshReport();
                ReportDataSource rds = new ReportDataSource("RPT_INSP_LIQ_JARABES", insp.VER_REPORTE_X_INSPECCION(Convert.ToInt32(dataGridView1.Rows[i].Cells["COD"].Value)));
                VEN.reportViewer1.LocalReport.DataSources.Add(rds);
                VEN.reportViewer1.RefreshReport();
                VEN.MdiParent = this.ParentForm;
                VEN.Show();
            }
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }

        void MUESTRA_LIQUIDOS_AMPOLLA()
        {
            timer1.Start();
            progressBar1.Visible = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                IMPRESION_REPORTES VEN = new IMPRESION_REPORTES();
                ReportParameter[] parametros = new ReportParameter[2];
                VEN.Text = "IMPRESION DE FORMATOS DE INSPECCION";
                VEN.reportViewer1.LocalReport.ReportEmbeddedResource = @"ALFARO_CAJA.REPORTES.INSP_LIQUIDOS_AMP.rdlc";
                parametros[0] = new ReportParameter("CODIGO", dataGridView1.Rows[i].Cells["COD"].Value.ToString());
                parametros[1] = new ReportParameter("FECHA", dataGridView1.Rows[i].Cells["FECHA"].Value.ToString());
                VEN.reportViewer1.LocalReport.SetParameters(parametros);
                VEN.reportViewer1.RefreshReport();
                ReportDataSource rds2 = new ReportDataSource("RPT_INSP_LIQ_AMP", insp.VER_REPORTE_X_INSPECCION(Convert.ToInt32(dataGridView1.Rows[i].Cells["COD"].Value)));
                VEN.reportViewer1.LocalReport.DataSources.Add(rds2);
                VEN.reportViewer1.RefreshReport();
                VEN.MdiParent = this.ParentForm;
                VEN.Show();
             
            }
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }

        void MUESTRA_SOLIDOS_TABLETAS()
        {
            timer1.Start();
            progressBar1.Visible = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                IMPRESION_REPORTES VEN = new IMPRESION_REPORTES();
                ReportParameter[] parametros = new ReportParameter[2];
                VEN.Text = "IMPRESION DE FORMATOS DE INSPECCION";
                VEN.reportViewer1.LocalReport.ReportEmbeddedResource = @"ALFARO_CAJA.REPORTES.INSP_SOLIDOS_TABLETAS.rdlc";
                parametros[0] = new ReportParameter("CODIGO", dataGridView1.Rows[i].Cells["COD"].Value.ToString());
                parametros[1] = new ReportParameter("FECHA", dataGridView1.Rows[i].Cells["FECHA"].Value.ToString());
                VEN.reportViewer1.LocalReport.SetParameters(parametros);
                VEN.reportViewer1.RefreshReport();
                ReportDataSource rds2 = new ReportDataSource("RPT_SOLIDOS", insp.VER_REPORTE_X_INSPECCION(Convert.ToInt32(dataGridView1.Rows[i].Cells["COD"].Value)));
                VEN.reportViewer1.LocalReport.DataSources.Add(rds2);
                VEN.reportViewer1.RefreshReport();
                VEN.MdiParent = this.ParentForm;
                VEN.Show();
            }
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }
        void MUESTRA_SOLIDOS_OVULOS()
        {
            timer1.Start();
            progressBar1.Visible = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                IMPRESION_REPORTES VEN = new IMPRESION_REPORTES();
                ReportParameter[] parametros = new ReportParameter[2];
                VEN.Text = "IMPRESION DE FORMATOS DE INSPECCION";
                VEN.reportViewer1.LocalReport.ReportEmbeddedResource = @"ALFARO_CAJA.REPORTES.INSP_SOLIDOS_OVCREMAS.rdlc";
                parametros[0] = new ReportParameter("CODIGO", dataGridView1.Rows[i].Cells["COD"].Value.ToString());
                parametros[1] = new ReportParameter("FECHA", dataGridView1.Rows[i].Cells["FECHA"].Value.ToString());
                VEN.reportViewer1.LocalReport.SetParameters(parametros);
                VEN.reportViewer1.RefreshReport();
                ReportDataSource rds2 = new ReportDataSource("RPT_SOLIDOS", insp.VER_REPORTE_X_INSPECCION(Convert.ToInt32(dataGridView1.Rows[i].Cells["COD"].Value)));
                VEN.reportViewer1.LocalReport.DataSources.Add(rds2);
                VEN.reportViewer1.RefreshReport();
                VEN.MdiParent = this.ParentForm;
                VEN.Show();          
            }
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }

        void MUESTRA_SOLIDOS_VIALES()
        {
            timer1.Start();
            progressBar1.Visible = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                IMPRESION_REPORTES VEN = new IMPRESION_REPORTES();
                ReportParameter[] parametros = new ReportParameter[2];
                VEN.Text = "IMPRESION DE FORMATOS DE INSPECCION";
                VEN.reportViewer1.LocalReport.ReportEmbeddedResource = @"ALFARO_CAJA.REPORTES.INSP_SOLIDOS_VIALES.rdlc";
                parametros[0] = new ReportParameter("CODIGO", dataGridView1.Rows[i].Cells["COD"].Value.ToString());
                parametros[1] = new ReportParameter("FECHA", dataGridView1.Rows[i].Cells["FECHA"].Value.ToString());
                VEN.reportViewer1.LocalReport.SetParameters(parametros);
                VEN.reportViewer1.RefreshReport();
                ReportDataSource rds2 = new ReportDataSource("RPT_SOLIDOS", insp.VER_REPORTE_X_INSPECCION(Convert.ToInt32(dataGridView1.Rows[i].Cells["COD"].Value)));
                VEN.reportViewer1.LocalReport.DataSources.Add(rds2);
                VEN.reportViewer1.RefreshReport();
                VEN.MdiParent = this.ParentForm;
                VEN.Show();
            }
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }
        void MUESTRA_SOLIDOS_CAPSULAS()
        {
            timer1.Start();
            progressBar1.Visible = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                IMPRESION_REPORTES VEN = new IMPRESION_REPORTES();
                ReportParameter[] parametros = new ReportParameter[2];
                VEN.Text = "IMPRESION DE FORMATOS DE INSPECCION";
                VEN.reportViewer1.LocalReport.ReportEmbeddedResource = @"ALFARO_CAJA.REPORTES.INSP_SOLIDOS_CAPSULAS.rdlc";
                parametros[0] = new ReportParameter("CODIGO", dataGridView1.Rows[i].Cells["COD"].Value.ToString());
                parametros[1] = new ReportParameter("FECHA", dataGridView1.Rows[i].Cells["FECHA"].Value.ToString());
                VEN.reportViewer1.LocalReport.SetParameters(parametros);
                VEN.reportViewer1.RefreshReport();
                ReportDataSource rds2 = new ReportDataSource("RPT_SOLIDOS", insp.VER_REPORTE_X_INSPECCION(Convert.ToInt32(dataGridView1.Rows[i].Cells["COD"].Value)));
                VEN.reportViewer1.LocalReport.DataSources.Add(rds2);
                VEN.reportViewer1.RefreshReport();
                VEN.MdiParent = this.ParentForm;
                VEN.Show();
            }
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }
        void imprimetodo()
        {
            if (comboBox1.Text.Equals("LIQUIDOS - JARABE"))
            {
                MUESTRA_LIQUIDOS();
            }
            else if (comboBox1.Text.Equals("LIQUIDOS - AMPOLLA"))
            {
                MUESTRA_LIQUIDOS_AMPOLLA();
            }
               
            else if (comboBox1.Text.Equals("SOLIDOS - TABLETAS"))
            {
                MUESTRA_SOLIDOS_TABLETAS();

            }
            else if (comboBox1.Text.Equals("SOLIDOS - OVULOS Y CREMAS"))
            {
                MUESTRA_SOLIDOS_OVULOS();             
               
            }

            else if (comboBox1.Text.Equals("SOLIDOS - VIALES"))
            {
                MUESTRA_SOLIDOS_VIALES();
            }
            else
            {
                MUESTRA_SOLIDOS_CAPSULAS();
            }
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            timer1.Start();
            imprimetodo();
            timer1.Stop();
            progressBar1.Visible = false;
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }
    }
    }

