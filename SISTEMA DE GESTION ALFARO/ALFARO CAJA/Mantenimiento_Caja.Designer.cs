namespace ALFARO_CAJA
{
    partial class Mantenimiento_Caja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento_Caja));
            this.DGVDATA = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.STNOMBRECOMPLETO = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPERFIL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STCODIGO = new System.Windows.Forms.ToolStripStatusLabel();
            this.LBLCODIGO = new System.Windows.Forms.Label();
            this.LBLNOMBRECAJA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLESTADO = new System.Windows.Forms.Label();
            this.LBLFECHA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLAPERTURADO = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTMONTO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TXTDESCRIPCION = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTNUMERO = new System.Windows.Forms.TextBox();
            this.CMBDOC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbprov = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNCAMBIARESTADO = new System.Windows.Forms.Button();
            this.BTNLIQUIDAR = new System.Windows.Forms.Button();
            this.BTNREPORTE = new System.Windows.Forms.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.LBLTOTALCONTEO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDATA)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDATA
            // 
            this.DGVDATA.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDATA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDATA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDATA.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVDATA.Location = new System.Drawing.Point(3, 173);
            this.DGVDATA.Name = "DGVDATA";
            this.DGVDATA.ReadOnly = true;
            this.DGVDATA.Size = new System.Drawing.Size(862, 298);
            this.DGVDATA.TabIndex = 18;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STNOMBRECOMPLETO,
            this.toolStripStatusLabel1,
            this.STPERFIL,
            this.toolStripStatusLabel2,
            this.STPC,
            this.toolStripStatusLabel3,
            this.STCODIGO});
            this.statusStrip1.Location = new System.Drawing.Point(0, 520);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(871, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // STNOMBRECOMPLETO
            // 
            this.STNOMBRECOMPLETO.Name = "STNOMBRECOMPLETO";
            this.STNOMBRECOMPLETO.Size = new System.Drawing.Size(118, 17);
            this.STNOMBRECOMPLETO.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(4, 17);
            // 
            // STPERFIL
            // 
            this.STPERFIL.Name = "STPERFIL";
            this.STPERFIL.Size = new System.Drawing.Size(118, 17);
            this.STPERFIL.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(4, 17);
            // 
            // STPC
            // 
            this.STPC.Name = "STPC";
            this.STPC.Size = new System.Drawing.Size(118, 17);
            this.STPC.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(4, 17);
            // 
            // STCODIGO
            // 
            this.STCODIGO.Name = "STCODIGO";
            this.STCODIGO.Size = new System.Drawing.Size(118, 17);
            this.STCODIGO.Text = "toolStripStatusLabel4";
            this.STCODIGO.Visible = false;
            // 
            // LBLCODIGO
            // 
            this.LBLCODIGO.AutoSize = true;
            this.LBLCODIGO.Location = new System.Drawing.Point(225, 23);
            this.LBLCODIGO.Name = "LBLCODIGO";
            this.LBLCODIGO.Size = new System.Drawing.Size(25, 13);
            this.LBLCODIGO.TabIndex = 28;
            this.LBLCODIGO.Text = "------";
            this.LBLCODIGO.Visible = false;
            // 
            // LBLNOMBRECAJA
            // 
            this.LBLNOMBRECAJA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLNOMBRECAJA.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNOMBRECAJA.Location = new System.Drawing.Point(0, 0);
            this.LBLNOMBRECAJA.Name = "LBLNOMBRECAJA";
            this.LBLNOMBRECAJA.Size = new System.Drawing.Size(871, 23);
            this.LBLNOMBRECAJA.TabIndex = 29;
            this.LBLNOMBRECAJA.Text = "label1";
            this.LBLNOMBRECAJA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ESTADO:";
            // 
            // LBLESTADO
            // 
            this.LBLESTADO.AutoSize = true;
            this.LBLESTADO.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLESTADO.Location = new System.Drawing.Point(53, 23);
            this.LBLESTADO.Name = "LBLESTADO";
            this.LBLESTADO.Size = new System.Drawing.Size(31, 13);
            this.LBLESTADO.TabIndex = 28;
            this.LBLESTADO.Text = "------";
            // 
            // LBLFECHA
            // 
            this.LBLFECHA.AutoSize = true;
            this.LBLFECHA.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLFECHA.Location = new System.Drawing.Point(528, 23);
            this.LBLFECHA.Name = "LBLFECHA";
            this.LBLFECHA.Size = new System.Drawing.Size(31, 13);
            this.LBLFECHA.TabIndex = 28;
            this.LBLFECHA.Text = "------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "FECHA APERTURA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(743, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "USUARIO:";
            // 
            // LBLAPERTURADO
            // 
            this.LBLAPERTURADO.AutoSize = true;
            this.LBLAPERTURADO.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLAPERTURADO.Location = new System.Drawing.Point(808, 23);
            this.LBLAPERTURADO.Name = "LBLAPERTURADO";
            this.LBLAPERTURADO.Size = new System.Drawing.Size(31, 13);
            this.LBLAPERTURADO.TabIndex = 28;
            this.LBLAPERTURADO.Text = "------";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXTMONTO);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.TXTDESCRIPCION);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TXTNUMERO);
            this.groupBox1.Controls.Add(this.CMBDOC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.cmbprov);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 128);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL GASTO";
            // 
            // TXTMONTO
            // 
            this.TXTMONTO.Location = new System.Drawing.Point(88, 102);
            this.TXTMONTO.Name = "TXTMONTO";
            this.TXTMONTO.Size = new System.Drawing.Size(100, 22);
            this.TXTMONTO.TabIndex = 10;
            this.TXTMONTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTMONTO_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "MONTO:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(617, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(35, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "...";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TXTDESCRIPCION
            // 
            this.TXTDESCRIPCION.Location = new System.Drawing.Point(90, 70);
            this.TXTDESCRIPCION.Name = "TXTDESCRIPCION";
            this.TXTDESCRIPCION.Size = new System.Drawing.Size(521, 22);
            this.TXTDESCRIPCION.TabIndex = 7;
            this.TXTDESCRIPCION.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTDESCRIPCION_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "DESCRIPCION:";
            // 
            // TXTNUMERO
            // 
            this.TXTNUMERO.Location = new System.Drawing.Point(180, 46);
            this.TXTNUMERO.Name = "TXTNUMERO";
            this.TXTNUMERO.Size = new System.Drawing.Size(100, 22);
            this.TXTNUMERO.TabIndex = 5;
            this.TXTNUMERO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNUMERO_KeyPress);
            // 
            // CMBDOC
            // 
            this.CMBDOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBDOC.FormattingEnabled = true;
            this.CMBDOC.Items.AddRange(new object[] {
            "FACTURA",
            "BOLETA ",
            "RECIBO ",
            "TICKET"});
            this.CMBDOC.Location = new System.Drawing.Point(88, 46);
            this.CMBDOC.Name = "CMBDOC";
            this.CMBDOC.Size = new System.Drawing.Size(86, 21);
            this.CMBDOC.TabIndex = 4;
            this.CMBDOC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMBDOC_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TIPO DOC:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(384, 24);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(112, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "NUEVO PROVEEDOR";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cmbprov
            // 
            this.cmbprov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprov.FormattingEnabled = true;
            this.cmbprov.Location = new System.Drawing.Point(88, 21);
            this.cmbprov.Name = "cmbprov";
            this.cmbprov.Size = new System.Drawing.Size(290, 21);
            this.cmbprov.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "PROVEEDOR:";
            // 
            // BTNCAMBIARESTADO
            // 
            this.BTNCAMBIARESTADO.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCAMBIARESTADO.Location = new System.Drawing.Point(679, 129);
            this.BTNCAMBIARESTADO.Name = "BTNCAMBIARESTADO";
            this.BTNCAMBIARESTADO.Size = new System.Drawing.Size(186, 23);
            this.BTNCAMBIARESTADO.TabIndex = 33;
            this.BTNCAMBIARESTADO.Text = "&APERTURA CAJA";
            this.BTNCAMBIARESTADO.UseVisualStyleBackColor = true;
            this.BTNCAMBIARESTADO.Visible = false;
            this.BTNCAMBIARESTADO.Click += new System.EventHandler(this.BTNCAMBIARESTADO_Click);
            // 
            // BTNLIQUIDAR
            // 
            this.BTNLIQUIDAR.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLIQUIDAR.Location = new System.Drawing.Point(679, 100);
            this.BTNLIQUIDAR.Name = "BTNLIQUIDAR";
            this.BTNLIQUIDAR.Size = new System.Drawing.Size(186, 23);
            this.BTNLIQUIDAR.TabIndex = 33;
            this.BTNLIQUIDAR.Text = "&LIQUIDAR CAJA";
            this.BTNLIQUIDAR.UseVisualStyleBackColor = true;
            this.BTNLIQUIDAR.Visible = false;
            this.BTNLIQUIDAR.Click += new System.EventHandler(this.BTNLIQUIDAR_Click);
            // 
            // BTNREPORTE
            // 
            this.BTNREPORTE.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNREPORTE.Location = new System.Drawing.Point(679, 71);
            this.BTNREPORTE.Name = "BTNREPORTE";
            this.BTNREPORTE.Size = new System.Drawing.Size(186, 23);
            this.BTNREPORTE.TabIndex = 33;
            this.BTNREPORTE.Text = "&REPORTE";
            this.BTNREPORTE.UseVisualStyleBackColor = true;
            this.BTNREPORTE.Click += new System.EventHandler(this.BTNREPORTE_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(-3, 474);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(46, 13);
            this.linkLabel3.TabIndex = 34;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "QUITAR";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // LBLTOTALCONTEO
            // 
            this.LBLTOTALCONTEO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLTOTALCONTEO.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTOTALCONTEO.Location = new System.Drawing.Point(0, 496);
            this.LBLTOTALCONTEO.Name = "LBLTOTALCONTEO";
            this.LBLTOTALCONTEO.Size = new System.Drawing.Size(871, 24);
            this.LBLTOTALCONTEO.TabIndex = 35;
            this.LBLTOTALCONTEO.Text = "label8";
            this.LBLTOTALCONTEO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Mantenimiento_Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 542);
            this.Controls.Add(this.LBLTOTALCONTEO);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.BTNREPORTE);
            this.Controls.Add(this.BTNLIQUIDAR);
            this.Controls.Add(this.BTNCAMBIARESTADO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLAPERTURADO);
            this.Controls.Add(this.LBLFECHA);
            this.Controls.Add(this.LBLNOMBRECAJA);
            this.Controls.Add(this.LBLESTADO);
            this.Controls.Add(this.LBLCODIGO);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DGVDATA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mantenimiento_Caja";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MANTENIMIENTO DE CAJA";
            this.Load += new System.EventHandler(this.Mantenimiento_Caja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDATA)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView DGVDATA;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel STNOMBRECOMPLETO;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel STPERFIL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel STPC;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel STCODIGO;
        public System.Windows.Forms.Label LBLNOMBRECAJA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LBLCODIGO;
        public System.Windows.Forms.Label LBLESTADO;
        public System.Windows.Forms.Label LBLAPERTURADO;
        public System.Windows.Forms.Label LBLFECHA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbprov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox TXTNUMERO;
        private System.Windows.Forms.ComboBox CMBDOC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox TXTDESCRIPCION;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button BTNCAMBIARESTADO;
        public System.Windows.Forms.Button BTNLIQUIDAR;
        public System.Windows.Forms.Button BTNREPORTE;
        public System.Windows.Forms.TextBox TXTMONTO;
        public System.Windows.Forms.LinkLabel linkLabel3;
        public System.Windows.Forms.Label LBLTOTALCONTEO;
    }
}