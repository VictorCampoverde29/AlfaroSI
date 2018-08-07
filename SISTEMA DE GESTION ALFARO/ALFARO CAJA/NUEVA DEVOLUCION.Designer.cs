namespace ALFARO_CAJA
{
    partial class NUEVA_DEVOLUCION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NUEVA_DEVOLUCION));
            this.DGVDATA = new System.Windows.Forms.DataGridView();
            this.UNIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTFAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.TXTMOTIVO = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.STNOMBRECOMPLETO = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPERFIL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STCODIGO = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBLDIRECCION = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBLRUC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LBLNUMERO = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TXTGUIA = new System.Windows.Forms.TextBox();
            this.TXTFACTURA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXTCAN = new System.Windows.Forms.TextBox();
            this.TXTCANF = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CMBUM = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTLOTE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTPROD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LBLRUCTRANSPORTE = new System.Windows.Forms.Label();
            this.CMBTRANSPORTISTA = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDATA)).BeginInit();
            this.panel6.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDATA
            // 
            this.DGVDATA.AllowUserToAddRows = false;
            this.DGVDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGVDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDATA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UNIDAD,
            this.PRODUCTO,
            this.LOTE,
            this.CANTFAC,
            this.CANTIDAD,
            this.CANTSI,
            this.MFC,
            this.MMT,
            this.MOTIVO,
            this.OB});
            this.DGVDATA.Location = new System.Drawing.Point(4, 247);
            this.DGVDATA.Name = "DGVDATA";
            this.DGVDATA.ReadOnly = true;
            this.DGVDATA.Size = new System.Drawing.Size(739, 182);
            this.DGVDATA.TabIndex = 21;
            this.DGVDATA.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGVDATA_RowsAdded);
            this.DGVDATA.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGVDATA_RowsRemoved);
            // 
            // UNIDAD
            // 
            this.UNIDAD.HeaderText = "UND.";
            this.UNIDAD.Name = "UNIDAD";
            this.UNIDAD.ReadOnly = true;
            this.UNIDAD.Width = 59;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.HeaderText = "PRODUCTO";
            this.PRODUCTO.Name = "PRODUCTO";
            this.PRODUCTO.ReadOnly = true;
            this.PRODUCTO.Width = 91;
            // 
            // LOTE
            // 
            this.LOTE.HeaderText = "LOTE";
            this.LOTE.Name = "LOTE";
            this.LOTE.ReadOnly = true;
            this.LOTE.Width = 57;
            // 
            // CANTFAC
            // 
            this.CANTFAC.HeaderText = "CANT. FACT.";
            this.CANTFAC.Name = "CANTFAC";
            this.CANTFAC.ReadOnly = true;
            this.CANTFAC.Width = 93;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANT. DEV.";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Width = 89;
            // 
            // CANTSI
            // 
            this.CANTSI.HeaderText = "CANT. ING.";
            this.CANTSI.Name = "CANTSI";
            this.CANTSI.ReadOnly = true;
            this.CANTSI.Width = 87;
            // 
            // MFC
            // 
            this.MFC.HeaderText = "MFC";
            this.MFC.Name = "MFC";
            this.MFC.ReadOnly = true;
            this.MFC.Width = 55;
            // 
            // MMT
            // 
            this.MMT.HeaderText = "MMT";
            this.MMT.Name = "MMT";
            this.MMT.ReadOnly = true;
            this.MMT.Width = 57;
            // 
            // MOTIVO
            // 
            this.MOTIVO.HeaderText = "MOTIVO";
            this.MOTIVO.Name = "MOTIVO";
            this.MOTIVO.ReadOnly = true;
            this.MOTIVO.Width = 75;
            // 
            // OB
            // 
            this.OB.HeaderText = "OB";
            this.OB.Name = "OB";
            this.OB.ReadOnly = true;
            this.OB.Width = 48;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "FALLA DE CALIDAD",
            "MALTRATADO"});
            this.comboBox2.Location = new System.Drawing.Point(534, 10);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 21);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // TXTMOTIVO
            // 
            this.TXTMOTIVO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTMOTIVO.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTMOTIVO.Location = new System.Drawing.Point(317, -12);
            this.TXTMOTIVO.Name = "TXTMOTIVO";
            this.TXTMOTIVO.Size = new System.Drawing.Size(42, 22);
            this.TXTMOTIVO.TabIndex = 25;
            this.TXTMOTIVO.Visible = false;
            this.TXTMOTIVO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTMOTIVO_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 22);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 67;
            this.button1.Text = "A&GREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(633, 85);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(92, 13);
            this.linkLabel2.TabIndex = 26;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "SALTO DE LINEA";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.linkLabel1);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(739, 107);
            this.panel6.TabIndex = 26;
            this.panel6.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(86, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(561, 22);
            this.textBox2.TabIndex = 68;
            this.textBox2.Text = "-";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 15);
            this.label14.TabIndex = 67;
            this.label14.Text = "TEXTO:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 19);
            this.label13.TabIndex = 66;
            this.label13.Text = "SALTO DE LINEA:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(718, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(14, 13);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(748, 22);
            this.statusStrip1.TabIndex = 64;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBLDIRECCION);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LBLRUC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXTMOTIVO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 116);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL LABORATORIO";
            // 
            // LBLDIRECCION
            // 
            this.LBLDIRECCION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLDIRECCION.Location = new System.Drawing.Point(72, 68);
            this.LBLDIRECCION.Name = "LBLDIRECCION";
            this.LBLDIRECCION.Size = new System.Drawing.Size(328, 38);
            this.LBLDIRECCION.TabIndex = 71;
            this.LBLDIRECCION.Text = "-----------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "DIRECCION:";
            // 
            // LBLRUC
            // 
            this.LBLRUC.AutoSize = true;
            this.LBLRUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLRUC.Location = new System.Drawing.Point(72, 45);
            this.LBLRUC.Name = "LBLRUC";
            this.LBLRUC.Size = new System.Drawing.Size(53, 15);
            this.LBLRUC.TabIndex = 71;
            this.LBLRUC.Text = "-----------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "RUC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "LINEA:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ANULADA",
            "REGISTRADA",
            "TRASLADADA"});
            this.comboBox1.Location = new System.Drawing.Point(72, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(328, 21);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // LBLNUMERO
            // 
            this.LBLNUMERO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLNUMERO.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNUMERO.Location = new System.Drawing.Point(567, 9);
            this.LBLNUMERO.Name = "LBLNUMERO";
            this.LBLNUMERO.Size = new System.Drawing.Size(170, 31);
            this.LBLNUMERO.TabIndex = 0;
            this.LBLNUMERO.Text = "---/------";
            this.LBLNUMERO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TXTGUIA);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.TXTFACTURA);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(416, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 94);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATOS DE REFERENCIA";
            // 
            // TXTGUIA
            // 
            this.TXTGUIA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTGUIA.Location = new System.Drawing.Point(82, 70);
            this.TXTGUIA.Name = "TXTGUIA";
            this.TXTGUIA.Size = new System.Drawing.Size(239, 22);
            this.TXTGUIA.TabIndex = 3;
            // 
            // TXTFACTURA
            // 
            this.TXTFACTURA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTFACTURA.Location = new System.Drawing.Point(82, 19);
            this.TXTFACTURA.Name = "TXTFACTURA";
            this.TXTFACTURA.Size = new System.Drawing.Size(239, 22);
            this.TXTFACTURA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "GUIA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESO DE MERCADERIA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURA:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.CMBUM);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TXTLOTE);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TXTPROD);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 107);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETALLES DEL PRODUCTO";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.TXTCAN);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.TXTCANF);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(10, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(722, 38);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DETALLE DE CANTIDADES";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(472, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "MOTIVO:";
            // 
            // TXTCAN
            // 
            this.TXTCAN.Location = new System.Drawing.Point(349, 13);
            this.TXTCAN.Name = "TXTCAN";
            this.TXTCAN.Size = new System.Drawing.Size(100, 22);
            this.TXTCAN.TabIndex = 1;
            this.TXTCAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCAN_KeyPress);
            // 
            // TXTCANF
            // 
            this.TXTCANF.Location = new System.Drawing.Point(116, 13);
            this.TXTCANF.Name = "TXTCANF";
            this.TXTCANF.Size = new System.Drawing.Size(100, 22);
            this.TXTCANF.TabIndex = 1;
            this.TXTCANF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCANF_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "CANT. DEVOLVER:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "CANT. FACTURADA:";
            // 
            // CMBUM
            // 
            this.CMBUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBUM.FormattingEnabled = true;
            this.CMBUM.Items.AddRange(new object[] {
            "UND",
            "LTA",
            "FCO",
            "TUB",
            "CJA",
            "DISP",
            "PQTE"});
            this.CMBUM.Location = new System.Drawing.Point(664, 14);
            this.CMBUM.Name = "CMBUM";
            this.CMBUM.Size = new System.Drawing.Size(61, 21);
            this.CMBUM.TabIndex = 3;
            this.CMBUM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMBUM_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(623, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "UND:";
            // 
            // TXTLOTE
            // 
            this.TXTLOTE.AcceptsTab = true;
            this.TXTLOTE.Location = new System.Drawing.Point(479, 14);
            this.TXTLOTE.Name = "TXTLOTE";
            this.TXTLOTE.Size = new System.Drawing.Size(137, 22);
            this.TXTLOTE.TabIndex = 1;
            this.TXTLOTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTLOTE_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "LOTE:";
            // 
            // TXTPROD
            // 
            this.TXTPROD.Location = new System.Drawing.Point(78, 14);
            this.TXTPROD.Name = "TXTPROD";
            this.TXTPROD.Size = new System.Drawing.Size(353, 22);
            this.TXTPROD.TabIndex = 1;
            this.TXTPROD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTPROD_KeyDown);
            this.TXTPROD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTPROD_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "PRODUCTO:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LBLRUCTRANSPORTE);
            this.groupBox5.Controls.Add(this.CMBTRANSPORTISTA);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(4, 436);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(546, 70);
            this.groupBox5.TabIndex = 71;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DATOS DEL TRANSPORTE";
            // 
            // LBLRUCTRANSPORTE
            // 
            this.LBLRUCTRANSPORTE.AutoSize = true;
            this.LBLRUCTRANSPORTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLRUCTRANSPORTE.Location = new System.Drawing.Point(118, 45);
            this.LBLRUCTRANSPORTE.Name = "LBLRUCTRANSPORTE";
            this.LBLRUCTRANSPORTE.Size = new System.Drawing.Size(46, 15);
            this.LBLRUCTRANSPORTE.TabIndex = 2;
            this.LBLRUCTRANSPORTE.Text = "label17";
            // 
            // CMBTRANSPORTISTA
            // 
            this.CMBTRANSPORTISTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBTRANSPORTISTA.FormattingEnabled = true;
            this.CMBTRANSPORTISTA.Location = new System.Drawing.Point(118, 14);
            this.CMBTRANSPORTISTA.Name = "CMBTRANSPORTISTA";
            this.CMBTRANSPORTISTA.Size = new System.Drawing.Size(417, 21);
            this.CMBTRANSPORTISTA.TabIndex = 1;
            this.CMBTRANSPORTISTA.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.CMBTRANSPORTISTA.SelectionChangeCommitted += new System.EventHandler(this.CMBTRANSPORTISTA_SelectionChangeCommitted);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(80, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "RUC:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "TRANSPORTE:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(668, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 69);
            this.button2.TabIndex = 72;
            this.button2.Text = "&GUARDAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // NUEVA_DEVOLUCION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 534);
            this.Controls.Add(this.LBLNUMERO);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.DGVDATA);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NUEVA_DEVOLUCION";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NUEVA DEVOLUCION";
            this.Load += new System.EventHandler(this.NUEVA_DEVOLUCION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDATA)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVDATA;
        private System.Windows.Forms.TextBox TXTMOTIVO;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTFAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OB;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel STNOMBRECOMPLETO;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel STPERFIL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel STPC;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel STCODIGO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBLDIRECCION;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBLRUC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LBLNUMERO;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TXTFACTURA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTGUIA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox CMBUM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTLOTE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXTCAN;
        private System.Windows.Forms.TextBox TXTCANF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label LBLRUCTRANSPORTE;
        private System.Windows.Forms.ComboBox CMBTRANSPORTISTA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox TXTPROD;
    }
}