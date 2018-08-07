namespace ALFARO_CAJA
{
    partial class Nueva_Perdida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nueva_Perdida));
            this.NUMEROS = new System.Windows.Forms.NumericUpDown();
            this.DGVDATA = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.STNOMBRECOMPLETO = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPERFIL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STCODIGO = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LBLDNI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CMBARMADOR = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXTOBS = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CMBMOTIVO = new System.Windows.Forms.ComboBox();
            this.TXTMOTIVO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTLOTE = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTPROD = new System.Windows.Forms.TextBox();
            this.TXTCDALFA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUMEROS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDATA)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NUMEROS
            // 
            this.NUMEROS.Location = new System.Drawing.Point(419, 50);
            this.NUMEROS.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUMEROS.Name = "NUMEROS";
            this.NUMEROS.Size = new System.Drawing.Size(82, 22);
            this.NUMEROS.TabIndex = 8;
            this.NUMEROS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUMEROS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUMEROS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NUMEROS_KeyPress);
            // 
            // DGVDATA
            // 
            this.DGVDATA.AllowUserToAddRows = false;
            this.DGVDATA.AllowUserToDeleteRows = false;
            this.DGVDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDATA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.dni});
            this.DGVDATA.Location = new System.Drawing.Point(11, 65);
            this.DGVDATA.Name = "DGVDATA";
            this.DGVDATA.ReadOnly = true;
            this.DGVDATA.Size = new System.Drawing.Size(491, 102);
            this.DGVDATA.TabIndex = 27;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 80;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 52;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(555, 22);
            this.statusStrip1.TabIndex = 39;
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
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.DGVDATA);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.LBLDNI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CMBARMADOR);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 197);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL PERSONAL";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "&GUARDAR PERDIDA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(8, 170);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(46, 13);
            this.linkLabel3.TabIndex = 32;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "QUITAR";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(119, 47);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "AÑADE AL DETALLE";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // LBLDNI
            // 
            this.LBLDNI.AutoSize = true;
            this.LBLDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLDNI.Location = new System.Drawing.Point(48, 47);
            this.LBLDNI.Name = "LBLDNI";
            this.LBLDNI.Size = new System.Drawing.Size(41, 15);
            this.LBLDNI.TabIndex = 2;
            this.LBLDNI.Text = "--------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // CMBARMADOR
            // 
            this.CMBARMADOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBARMADOR.FormattingEnabled = true;
            this.CMBARMADOR.Location = new System.Drawing.Point(12, 21);
            this.CMBARMADOR.Name = "CMBARMADOR";
            this.CMBARMADOR.Size = new System.Drawing.Size(339, 21);
            this.CMBARMADOR.TabIndex = 0;
            this.CMBARMADOR.SelectionChangeCommitted += new System.EventHandler(this.CMBARMADOR_SelectionChangeCommitted);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(12, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(518, 51);
            this.panel4.TabIndex = 41;
            this.panel4.TabStop = false;
            this.panel4.Text = "DATOS DE PERDIDA";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ALMACEN",
            "ARMADO",
            "ASEGURAMIENTO",
            "CHEQUEO",
            "CONTROLADOS",
            "DESPACHO ",
            "DEVOLUCIONES",
            "FACTURACION",
            "INGRESOS",
            "OFICINA"});
            this.comboBox1.Location = new System.Drawing.Point(324, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 87;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "FECHA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AREA:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXTOBS);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.CMBMOTIVO);
            this.groupBox2.Controls.Add(this.TXTMOTIVO);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TXTLOTE);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TXTPROD);
            this.groupBox2.Controls.Add(this.TXTCDALFA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NUMEROS);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 144);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DEL PRODUCTO";
            // 
            // TXTOBS
            // 
            this.TXTOBS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTOBS.Location = new System.Drawing.Point(60, 113);
            this.TXTOBS.Name = "TXTOBS";
            this.TXTOBS.Size = new System.Drawing.Size(441, 22);
            this.TXTOBS.TabIndex = 27;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(483, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(35, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "...";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CMBMOTIVO
            // 
            this.CMBMOTIVO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBMOTIVO.FormattingEnabled = true;
            this.CMBMOTIVO.Items.AddRange(new object[] {
            "TRABAJADOR ROMPIO EL PRODUCTO",
            "TRABAJADOR NO ENCUENTRA EL PRODUCTO",
            "TRABAJADOR MANIPULO MAL EL PRODUCTO"});
            this.CMBMOTIVO.Location = new System.Drawing.Point(60, 83);
            this.CMBMOTIVO.Name = "CMBMOTIVO";
            this.CMBMOTIVO.Size = new System.Drawing.Size(417, 21);
            this.CMBMOTIVO.TabIndex = 25;
            // 
            // TXTMOTIVO
            // 
            this.TXTMOTIVO.Location = new System.Drawing.Point(60, 83);
            this.TXTMOTIVO.Name = "TXTMOTIVO";
            this.TXTMOTIVO.Size = new System.Drawing.Size(417, 22);
            this.TXTMOTIVO.TabIndex = 24;
            this.TXTMOTIVO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTMOTIVO_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "OBSERV:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "MOTIVO:";
            // 
            // TXTLOTE
            // 
            this.TXTLOTE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTLOTE.Location = new System.Drawing.Point(60, 54);
            this.TXTLOTE.Name = "TXTLOTE";
            this.TXTLOTE.Size = new System.Drawing.Size(89, 22);
            this.TXTLOTE.TabIndex = 4;
            this.TXTLOTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTLOTE_KeyPress);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(232, 54);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(84, 22);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "CANT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "FECHA VCTO:";
            // 
            // TXTPROD
            // 
            this.TXTPROD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTPROD.Location = new System.Drawing.Point(232, 26);
            this.TXTPROD.Name = "TXTPROD";
            this.TXTPROD.Size = new System.Drawing.Size(269, 22);
            this.TXTPROD.TabIndex = 4;
            this.TXTPROD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTPROD_KeyDown);
            this.TXTPROD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTPROD_KeyPress);
            // 
            // TXTCDALFA
            // 
            this.TXTCDALFA.Location = new System.Drawing.Point(60, 26);
            this.TXTCDALFA.Name = "TXTCDALFA";
            this.TXTCDALFA.Size = new System.Drawing.Size(89, 22);
            this.TXTCDALFA.TabIndex = 3;
            this.TXTCDALFA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCDALFA_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "LOTE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "PRODUCTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CODIGO:";
            // 
            // Nueva_Perdida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 445);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Nueva_Perdida";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NUEVA PERDIDA";
            this.Load += new System.EventHandler(this.Nueva_Perdida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUMEROS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDATA)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown NUMEROS;
        public System.Windows.Forms.DataGridView DGVDATA;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel STNOMBRECOMPLETO;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel STPERFIL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel STPC;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel STCODIGO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBLDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBARMADOR;
        private System.Windows.Forms.GroupBox panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTCDALFA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTLOTE;
        private System.Windows.Forms.TextBox TXTPROD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CMBMOTIVO;
        private System.Windows.Forms.TextBox TXTMOTIVO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TXTOBS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}