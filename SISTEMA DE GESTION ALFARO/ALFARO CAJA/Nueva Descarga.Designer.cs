namespace ALFARO_CAJA
{
    partial class Nueva_Descarga
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nueva_Descarga));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TXTOBSER = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbletibultos = new System.Windows.Forms.Label();
            this.nudtermos = new System.Windows.Forms.NumericUpDown();
            this.nudtoneladas = new System.Windows.Forms.NumericUpDown();
            this.nudcajas = new System.Windows.Forms.NumericUpDown();
            this.chkcajas = new System.Windows.Forms.CheckBox();
            this.chktermos = new System.Windows.Forms.CheckBox();
            this.chktoneladas = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLNUMERO = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblnumerocant = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtfiltrarpersonal = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblcodpers = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.TXTLICDNI = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.STNOMBRECOMPLETO = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPERFIL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STCODIGO = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudtermos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtoneladas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcajas)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.TIPO,
            this.NOMBRE,
            this.DOCUMENTO});
            this.dataGridView1.Location = new System.Drawing.Point(10, 269);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(569, 111);
            this.dataGridView1.TabIndex = 63;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Visible = false;
            this.CODIGO.Width = 74;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.Width = 56;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 80;
            // 
            // DOCUMENTO
            // 
            this.DOCUMENTO.HeaderText = "DNI";
            this.DOCUMENTO.Name = "DOCUMENTO";
            this.DOCUMENTO.Width = 52;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LBLNUMERO);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.lblnumerocant);
            this.panel2.Controls.Add(this.TXTOBSER);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 399);
            this.panel2.TabIndex = 70;
            // 
            // TXTOBSER
            // 
            this.TXTOBSER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTOBSER.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTOBSER.Location = new System.Drawing.Point(106, 153);
            this.TXTOBSER.Name = "TXTOBSER";
            this.TXTOBSER.Size = new System.Drawing.Size(527, 22);
            this.TXTOBSER.TabIndex = 7;
            this.TXTOBSER.Text = "CD CON DOCUMENTOS";
            this.TXTOBSER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTOBSER_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbletibultos);
            this.groupBox1.Controls.Add(this.nudtermos);
            this.groupBox1.Controls.Add(this.nudtoneladas);
            this.groupBox1.Controls.Add(this.nudcajas);
            this.groupBox1.Controls.Add(this.chkcajas);
            this.groupBox1.Controls.Add(this.chktermos);
            this.groupBox1.Controls.Add(this.chktoneladas);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 62);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETALLE DE CARGA";
            // 
            // lbletibultos
            // 
            this.lbletibultos.Location = new System.Drawing.Point(6, 41);
            this.lbletibultos.Name = "lbletibultos";
            this.lbletibultos.Size = new System.Drawing.Size(618, 18);
            this.lbletibultos.TabIndex = 2;
            this.lbletibultos.Text = "0 CAJAS";
            this.lbletibultos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudtermos
            // 
            this.nudtermos.Enabled = false;
            this.nudtermos.Location = new System.Drawing.Point(559, 16);
            this.nudtermos.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudtermos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudtermos.Name = "nudtermos";
            this.nudtermos.Size = new System.Drawing.Size(65, 22);
            this.nudtermos.TabIndex = 899;
            this.nudtermos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudtermos.ValueChanged += new System.EventHandler(this.nudtermos_ValueChanged);
            // 
            // nudtoneladas
            // 
            this.nudtoneladas.Enabled = false;
            this.nudtoneladas.Location = new System.Drawing.Point(146, 16);
            this.nudtoneladas.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudtoneladas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudtoneladas.Name = "nudtoneladas";
            this.nudtoneladas.Size = new System.Drawing.Size(65, 22);
            this.nudtoneladas.TabIndex = 899;
            this.nudtoneladas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudtoneladas.ValueChanged += new System.EventHandler(this.nudtoneladas_ValueChanged);
            // 
            // nudcajas
            // 
            this.nudcajas.Location = new System.Drawing.Point(351, 16);
            this.nudcajas.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudcajas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudcajas.Name = "nudcajas";
            this.nudcajas.Size = new System.Drawing.Size(62, 22);
            this.nudcajas.TabIndex = 899;
            this.nudcajas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudcajas.ValueChanged += new System.EventHandler(this.nudcajas_ValueChanged);
            // 
            // chkcajas
            // 
            this.chkcajas.AutoSize = true;
            this.chkcajas.Checked = true;
            this.chkcajas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkcajas.Location = new System.Drawing.Point(282, 21);
            this.chkcajas.Name = "chkcajas";
            this.chkcajas.Size = new System.Drawing.Size(63, 17);
            this.chkcajas.TabIndex = 5;
            this.chkcajas.Text = "CAJAS:";
            this.chkcajas.UseVisualStyleBackColor = true;
            this.chkcajas.CheckedChanged += new System.EventHandler(this.chkcajas_CheckedChanged);
            // 
            // chktermos
            // 
            this.chktermos.AutoSize = true;
            this.chktermos.Location = new System.Drawing.Point(486, 19);
            this.chktermos.Name = "chktermos";
            this.chktermos.Size = new System.Drawing.Size(73, 17);
            this.chktermos.TabIndex = 6;
            this.chktermos.Text = "TERMOS:";
            this.chktermos.UseVisualStyleBackColor = true;
            this.chktermos.CheckedChanged += new System.EventHandler(this.chktermos_CheckedChanged);
            // 
            // chktoneladas
            // 
            this.chktoneladas.AutoSize = true;
            this.chktoneladas.Location = new System.Drawing.Point(55, 19);
            this.chktoneladas.Name = "chktoneladas";
            this.chktoneladas.Size = new System.Drawing.Size(94, 17);
            this.chktoneladas.TabIndex = 4;
            this.chktoneladas.Text = "TONELADAS:";
            this.chktoneladas.UseVisualStyleBackColor = true;
            this.chktoneladas.CheckedChanged += new System.EventHandler(this.chktoneladas_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(109, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(527, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "OBSERVACION:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "EMP. TRANSPORTE:";
            // 
            // LBLNUMERO
            // 
            this.LBLNUMERO.AutoSize = true;
            this.LBLNUMERO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLNUMERO.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNUMERO.Location = new System.Drawing.Point(555, 11);
            this.LBLNUMERO.Name = "LBLNUMERO";
            this.LBLNUMERO.Size = new System.Drawing.Size(40, 15);
            this.LBLNUMERO.TabIndex = 69;
            this.LBLNUMERO.Text = "label3";
            this.LBLNUMERO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(555, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(81, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(504, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "FECHA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "N°:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(425, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // lblnumerocant
            // 
            this.lblnumerocant.AutoSize = true;
            this.lblnumerocant.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumerocant.Location = new System.Drawing.Point(232, 13);
            this.lblnumerocant.Name = "lblnumerocant";
            this.lblnumerocant.Size = new System.Drawing.Size(42, 13);
            this.lblnumerocant.TabIndex = 67;
            this.lblnumerocant.Text = "LINEA:";
            this.lblnumerocant.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "LINEA:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtfiltrarpersonal);
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Location = new System.Drawing.Point(6, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(646, 212);
            this.panel4.TabIndex = 70;
            this.panel4.Visible = false;
            // 
            // txtfiltrarpersonal
            // 
            this.txtfiltrarpersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfiltrarpersonal.Location = new System.Drawing.Point(7, 19);
            this.txtfiltrarpersonal.Name = "txtfiltrarpersonal";
            this.txtfiltrarpersonal.Size = new System.Drawing.Size(634, 20);
            this.txtfiltrarpersonal.TabIndex = 64;
            this.txtfiltrarpersonal.TextChanged += new System.EventHandler(this.txtfiltrarpersonal_TextChanged);
            this.txtfiltrarpersonal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfiltrarpersonal_KeyPress);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(627, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(14, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(7, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(634, 162);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "ELEGIR";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblcodpers);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.TXTNOMBRE);
            this.groupBox2.Controls.Add(this.TXTLICDNI);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 82);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DEL PERSONAL DE TRANSPORTE";
            // 
            // lblcodpers
            // 
            this.lblcodpers.AutoSize = true;
            this.lblcodpers.Location = new System.Drawing.Point(319, 15);
            this.lblcodpers.Name = "lblcodpers";
            this.lblcodpers.Size = new System.Drawing.Size(16, 13);
            this.lblcodpers.TabIndex = 64;
            this.lblcodpers.Text = "N";
            this.lblcodpers.Visible = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(202, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 30);
            this.button2.TabIndex = 9;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "CHOFER ",
            "ESTIBADOR"});
            this.comboBox3.Location = new System.Drawing.Point(503, 22);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNOMBRE.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNOMBRE.Location = new System.Drawing.Point(96, 51);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(528, 22);
            this.TXTNOMBRE.TabIndex = 11;
            this.TXTNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNOMBRE_KeyPress);
            // 
            // TXTLICDNI
            // 
            this.TXTLICDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTLICDNI.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTLICDNI.Location = new System.Drawing.Point(96, 21);
            this.TXTLICDNI.Name = "TXTLICDNI";
            this.TXTLICDNI.Size = new System.Drawing.Size(100, 22);
            this.TXTLICDNI.TabIndex = 8;
            this.TXTLICDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTLICDNI_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "FUNCION:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "NOMBRE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "DNI/LICENCIA:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(581, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 61);
            this.button1.TabIndex = 12;
            this.button1.Text = "&GUARDAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(661, 22);
            this.statusStrip1.TabIndex = 73;
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
            // Nueva_Descarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 436);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Nueva_Descarga";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NUEVA DESCARGA";
            this.Load += new System.EventHandler(this.Nueva_Descarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudtermos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtoneladas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudcajas)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TXTOBSER;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudtoneladas;
        private System.Windows.Forms.NumericUpDown nudcajas;
        private System.Windows.Forms.CheckBox chkcajas;
        private System.Windows.Forms.CheckBox chktoneladas;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLNUMERO;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbletibultos;
        private System.Windows.Forms.NumericUpDown nudtermos;
        private System.Windows.Forms.CheckBox chktermos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.TextBox TXTLICDNI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel STNOMBRECOMPLETO;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel STPERFIL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel STPC;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel STCODIGO;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.TextBox txtfiltrarpersonal;
        private System.Windows.Forms.Label lblcodpers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO;
        private System.Windows.Forms.Label lblnumerocant;
    }
}