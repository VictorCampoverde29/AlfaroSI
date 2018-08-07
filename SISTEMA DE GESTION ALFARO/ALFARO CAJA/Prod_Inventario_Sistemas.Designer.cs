namespace ALFARO_CAJA
{
    partial class Prod_Inventario_Sistemas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prod_Inventario_Sistemas));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.NPDCANTIDAD = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblquitar = new System.Windows.Forms.LinkLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.STNOMBRECOMPLETO = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPERFIL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STCODIGO = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CMBINVENTARIO = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXTOBSV = new System.Windows.Forms.TextBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.CMBAREA = new System.Windows.Forms.ComboBox();
            this.TXTMARCA = new System.Windows.Forms.TextBox();
            this.TXTSERIE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTPRODUCTO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CMBCATEGORIA = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LBLTOTALREGISTROS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NPDCANTIDAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(249, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(43, 17);
            this.checkBox1.TabIndex = 62;
            this.checkBox1.Text = "S/S";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(548, 121);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(59, 13);
            this.linkLabel2.TabIndex = 57;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "AGREGAR";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // NPDCANTIDAD
            // 
            this.NPDCANTIDAD.Location = new System.Drawing.Point(333, 94);
            this.NPDCANTIDAD.Name = "NPDCANTIDAD";
            this.NPDCANTIDAD.Size = new System.Drawing.Size(44, 22);
            this.NPDCANTIDAD.TabIndex = 8;
            this.NPDCANTIDAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NPDCANTIDAD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NPDCANTIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NPDCANTIDAD_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(613, 234);
            this.dataGridView1.TabIndex = 57;
            // 
            // lblquitar
            // 
            this.lblquitar.AutoSize = true;
            this.lblquitar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquitar.Location = new System.Drawing.Point(12, 449);
            this.lblquitar.Name = "lblquitar";
            this.lblquitar.Size = new System.Drawing.Size(131, 13);
            this.lblquitar.TabIndex = 64;
            this.lblquitar.TabStop = true;
            this.lblquitar.Text = "QUITAR SELECCIONADO";
            this.lblquitar.Visible = false;
            this.lblquitar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblquitar_LinkClicked);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(631, 22);
            this.statusStrip1.TabIndex = 65;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(416, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 47);
            this.button1.TabIndex = 66;
            this.button1.Text = "&CONSULTAR REGISTROS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CMBINVENTARIO);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 44);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INVENTARIO ACTIVO";
            // 
            // CMBINVENTARIO
            // 
            this.CMBINVENTARIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBINVENTARIO.FormattingEnabled = true;
            this.CMBINVENTARIO.Location = new System.Drawing.Point(11, 17);
            this.CMBINVENTARIO.Name = "CMBINVENTARIO";
            this.CMBINVENTARIO.Size = new System.Drawing.Size(379, 21);
            this.CMBINVENTARIO.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXTOBSV);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.cmbestado);
            this.groupBox2.Controls.Add(this.CMBAREA);
            this.groupBox2.Controls.Add(this.TXTMARCA);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.TXTSERIE);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.NPDCANTIDAD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TXTPRODUCTO);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CMBCATEGORIA);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 143);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DEL PRODUCTO";
            // 
            // TXTOBSV
            // 
            this.TXTOBSV.Location = new System.Drawing.Point(87, 118);
            this.TXTOBSV.Name = "TXTOBSV";
            this.TXTOBSV.Size = new System.Drawing.Size(455, 22);
            this.TXTOBSV.TabIndex = 66;
            this.TXTOBSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTOBSV_KeyPress);
            // 
            // cmbestado
            // 
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "OPERATIVO",
            "INOPERATIVO",
            "POR MANTENIMIENTO"});
            this.cmbestado.Location = new System.Drawing.Point(440, 93);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(167, 21);
            this.cmbestado.TabIndex = 65;
            this.cmbestado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbestado_KeyPress);
            // 
            // CMBAREA
            // 
            this.CMBAREA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBAREA.FormattingEnabled = true;
            this.CMBAREA.Location = new System.Drawing.Point(87, 95);
            this.CMBAREA.Name = "CMBAREA";
            this.CMBAREA.Size = new System.Drawing.Size(156, 21);
            this.CMBAREA.TabIndex = 64;
            this.CMBAREA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMBAREA_KeyPress);
            // 
            // TXTMARCA
            // 
            this.TXTMARCA.Location = new System.Drawing.Point(507, 66);
            this.TXTMARCA.Name = "TXTMARCA";
            this.TXTMARCA.Size = new System.Drawing.Size(100, 22);
            this.TXTMARCA.TabIndex = 63;
            this.TXTMARCA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTMARCA_KeyPress);
            // 
            // TXTSERIE
            // 
            this.TXTSERIE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTSERIE.Location = new System.Drawing.Point(87, 66);
            this.TXTSERIE.Name = "TXTSERIE";
            this.TXTSERIE.Size = new System.Drawing.Size(156, 22);
            this.TXTSERIE.TabIndex = 2;
            this.TXTSERIE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTSERIE_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ESTADO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "CANTIDAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "MARCA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "AREA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SERIE:";
            // 
            // TXTPRODUCTO
            // 
            this.TXTPRODUCTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTPRODUCTO.Location = new System.Drawing.Point(87, 41);
            this.TXTPRODUCTO.Name = "TXTPRODUCTO";
            this.TXTPRODUCTO.Size = new System.Drawing.Size(520, 22);
            this.TXTPRODUCTO.TabIndex = 2;
            this.TXTPRODUCTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTPRODUCTO_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRODUCTO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CATEGORIA:";
            // 
            // CMBCATEGORIA
            // 
            this.CMBCATEGORIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBCATEGORIA.FormattingEnabled = true;
            this.CMBCATEGORIA.Items.AddRange(new object[] {
            "CPU",
            "DISPOSITIVOS DE PROTECCION ",
            "DISPOSITIVOS DE ALIMENTACION",
            "DISPOSITIVOS DE IMAGEN",
            "DISPOSITIVOS DE IMPRESION",
            "DISPOSITIVOS DE RED",
            "DISPOSITIVOS DE TELEFONIA",
            "DISPOSITIVOS DE VIGILANCIA",
            "DISPOSITIVOS USB EXTERNOS",
            "OTROS"});
            this.CMBCATEGORIA.Location = new System.Drawing.Point(87, 14);
            this.CMBCATEGORIA.Name = "CMBCATEGORIA";
            this.CMBCATEGORIA.Size = new System.Drawing.Size(233, 21);
            this.CMBCATEGORIA.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "OBSERVACION:";
            // 
            // LBLTOTALREGISTROS
            // 
            this.LBLTOTALREGISTROS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLTOTALREGISTROS.Location = new System.Drawing.Point(-3, 472);
            this.LBLTOTALREGISTROS.Name = "LBLTOTALREGISTROS";
            this.LBLTOTALREGISTROS.Size = new System.Drawing.Size(705, 23);
            this.LBLTOTALREGISTROS.TabIndex = 69;
            this.LBLTOTALREGISTROS.Text = "label9";
            this.LBLTOTALREGISTROS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prod_Inventario_Sistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 520);
            this.Controls.Add(this.LBLTOTALREGISTROS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblquitar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prod_Inventario_Sistemas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "INVENTARIO SISTEMAS";
            this.Load += new System.EventHandler(this.Prod_Inventario_Sistemas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NPDCANTIDAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown NPDCANTIDAD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel lblquitar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel STNOMBRECOMPLETO;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel STPERFIL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel STPC;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel STCODIGO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CMBINVENTARIO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTSERIE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTPRODUCTO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBCATEGORIA;
        private System.Windows.Forms.ComboBox CMBAREA;
        private System.Windows.Forms.TextBox TXTMARCA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTOBSV;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LBLTOTALREGISTROS;
    }
}