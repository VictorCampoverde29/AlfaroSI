﻿namespace ALFARO_CAJA
{
    partial class MOIFICAR_MEMORANDUM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MOIFICAR_MEMORANDUM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TXTCOD = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DTPALGRL = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPDELGRL = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DGVDATA = new System.Windows.Forms.DataGridView();
            this.VER = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CMBARMADOR = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DTPAL = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPDEL = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.STNOMBRECOMPLETO = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPERFIL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STCODIGO = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDATA)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DGVDATA);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 377);
            this.panel1.TabIndex = 53;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TXTCOD);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(347, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 97);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BUSQUEDAD X NUMERO";
            // 
            // TXTCOD
            // 
            this.TXTCOD.Location = new System.Drawing.Point(38, 42);
            this.TXTCOD.Mask = "9999";
            this.TXTCOD.Name = "TXTCOD";
            this.TXTCOD.Size = new System.Drawing.Size(81, 22);
            this.TXTCOD.TabIndex = 1;
            this.TXTCOD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.DTPALGRL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DTPDELGRL);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 97);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSQUEDAD X PERSONAL Y RANGO DE FECHAS";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "&VER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DTPALGRL
            // 
            this.DTPALGRL.Location = new System.Drawing.Point(46, 45);
            this.DTPALGRL.Name = "DTPALGRL";
            this.DTPALGRL.Size = new System.Drawing.Size(285, 22);
            this.DTPALGRL.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "AL:";
            // 
            // DTPDELGRL
            // 
            this.DTPDELGRL.Location = new System.Drawing.Point(46, 21);
            this.DTPDELGRL.Name = "DTPDELGRL";
            this.DTPDELGRL.Size = new System.Drawing.Size(285, 22);
            this.DTPDELGRL.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "DEL:";
            // 
            // DGVDATA
            // 
            this.DGVDATA.AllowUserToAddRows = false;
            this.DGVDATA.AllowUserToDeleteRows = false;
            this.DGVDATA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDATA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDATA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VER});
            this.DGVDATA.Location = new System.Drawing.Point(2, 209);
            this.DGVDATA.Name = "DGVDATA";
            this.DGVDATA.ReadOnly = true;
            this.DGVDATA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDATA.Size = new System.Drawing.Size(485, 161);
            this.DGVDATA.TabIndex = 60;
            this.DGVDATA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDATA_CellContentClick);
            // 
            // VER
            // 
            this.VER.HeaderText = "";
            this.VER.Name = "VER";
            this.VER.ReadOnly = true;
            this.VER.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VER.Text = "VER";
            this.VER.ToolTipText = "VER";
            this.VER.UseColumnTextForButtonValue = true;
            this.VER.Width = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CMBARMADOR);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.DTPAL);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DTPDEL);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 97);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REPORTE INDIVIDUAL";
            // 
            // CMBARMADOR
            // 
            this.CMBARMADOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBARMADOR.FormattingEnabled = true;
            this.CMBARMADOR.Location = new System.Drawing.Point(85, 13);
            this.CMBARMADOR.Name = "CMBARMADOR";
            this.CMBARMADOR.Size = new System.Drawing.Size(286, 21);
            this.CMBARMADOR.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "ARMADOR:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&VER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DTPAL
            // 
            this.DTPAL.Location = new System.Drawing.Point(44, 64);
            this.DTPAL.Name = "DTPAL";
            this.DTPAL.Size = new System.Drawing.Size(327, 22);
            this.DTPAL.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "AL:";
            // 
            // DTPDEL
            // 
            this.DTPDEL.Location = new System.Drawing.Point(44, 40);
            this.DTPDEL.Name = "DTPDEL";
            this.DTPDEL.Size = new System.Drawing.Size(327, 22);
            this.DTPDEL.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "DEL:";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(501, 22);
            this.statusStrip1.TabIndex = 58;
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
            // MOIFICAR_MEMORANDUM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 402);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MOIFICAR_MEMORANDUM";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MODIFICAR MEMORANDUM";
            this.Load += new System.EventHandler(this.MOIFICAR_MEMORANDUM_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDATA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox TXTCOD;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel STNOMBRECOMPLETO;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel STPERFIL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel STPC;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel STCODIGO;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CMBARMADOR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DTPAL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPDEL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker DTPALGRL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPDELGRL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGVDATA;
        private System.Windows.Forms.DataGridViewButtonColumn VER;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}