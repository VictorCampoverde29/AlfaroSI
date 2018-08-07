namespace ALFARO_CAJA
{
    partial class NUEVO_MEMORANDUN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NUEVO_MEMORANDUN));
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBLCOD = new System.Windows.Forms.Label();
            this.CMBTIPO = new System.Windows.Forms.ComboBox();
            this.CLAVE = new System.Windows.Forms.Label();
            this.CMBASUNTO = new System.Windows.Forms.ComboBox();
            this.CMBARMADOR = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.STNOMBRECOMPLETO = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPERFIL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STCODIGO = new System.Windows.Forms.ToolStripStatusLabel();
            this.TXTCP1 = new System.Windows.Forms.TextBox();
            this.TXTCP2 = new System.Windows.Forms.TextBox();
            this.TXTCP3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.TXTCP3);
            this.panel3.Controls.Add(this.TXTCP2);
            this.panel3.Controls.Add(this.TXTCP1);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(566, 510);
            this.panel3.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBLCOD);
            this.groupBox1.Controls.Add(this.CMBTIPO);
            this.groupBox1.Controls.Add(this.CLAVE);
            this.groupBox1.Controls.Add(this.CMBASUNTO);
            this.groupBox1.Controls.Add(this.CMBARMADOR);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 150);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUERPO DEL MEMORANDUM";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LBLCOD
            // 
            this.LBLCOD.AutoSize = true;
            this.LBLCOD.Location = new System.Drawing.Point(407, 30);
            this.LBLCOD.Name = "LBLCOD";
            this.LBLCOD.Size = new System.Drawing.Size(38, 13);
            this.LBLCOD.TabIndex = 3;
            this.LBLCOD.Text = "label8";
            this.LBLCOD.Visible = false;
            // 
            // CMBTIPO
            // 
            this.CMBTIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBTIPO.FormattingEnabled = true;
            this.CMBTIPO.Items.AddRange(new object[] {
            "COMUNICADO",
            "LLAMADA DE ATENCION"});
            this.CMBTIPO.Location = new System.Drawing.Point(375, 120);
            this.CMBTIPO.Name = "CMBTIPO";
            this.CMBTIPO.Size = new System.Drawing.Size(167, 21);
            this.CMBTIPO.TabIndex = 2;
            this.CMBTIPO.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // CLAVE
            // 
            this.CLAVE.AutoSize = true;
            this.CLAVE.Location = new System.Drawing.Point(394, 52);
            this.CLAVE.Name = "CLAVE";
            this.CLAVE.Size = new System.Drawing.Size(65, 13);
            this.CLAVE.TabIndex = 34;
            this.CLAVE.Text = "REGISTRAR";
            this.CLAVE.Visible = false;
            this.CLAVE.Click += new System.EventHandler(this.CLAVE_Click);
            // 
            // CMBASUNTO
            // 
            this.CMBASUNTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBASUNTO.FormattingEnabled = true;
            this.CMBASUNTO.Items.AddRange(new object[] {
            "COMUNICADO",
            "LLAMADA DE ATENCION",
            "TARDANZA"});
            this.CMBASUNTO.Location = new System.Drawing.Point(75, 123);
            this.CMBASUNTO.Name = "CMBASUNTO";
            this.CMBASUNTO.Size = new System.Drawing.Size(254, 21);
            this.CMBASUNTO.TabIndex = 2;
            this.CMBASUNTO.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // CMBARMADOR
            // 
            this.CMBARMADOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBARMADOR.FormattingEnabled = true;
            this.CMBARMADOR.Location = new System.Drawing.Point(75, 96);
            this.CMBARMADOR.Name = "CMBARMADOR";
            this.CMBARMADOR.Size = new System.Drawing.Size(254, 21);
            this.CMBARMADOR.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "SRA. Maria Jose Diaz Alfaro\r\nJefa de Recursos Humanos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "TIPO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ASUNTO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FECHA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "_________________________________________________________________________________" +
    "___________";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 521);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(572, 22);
            this.statusStrip1.TabIndex = 36;
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
            // TXTCP1
            // 
            this.TXTCP1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCP1.Location = new System.Drawing.Point(17, 189);
            this.TXTCP1.Multiline = true;
            this.TXTCP1.Name = "TXTCP1";
            this.TXTCP1.Size = new System.Drawing.Size(538, 76);
            this.TXTCP1.TabIndex = 47;
            // 
            // TXTCP2
            // 
            this.TXTCP2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCP2.Location = new System.Drawing.Point(17, 271);
            this.TXTCP2.Multiline = true;
            this.TXTCP2.Name = "TXTCP2";
            this.TXTCP2.Size = new System.Drawing.Size(538, 76);
            this.TXTCP2.TabIndex = 47;
            // 
            // TXTCP3
            // 
            this.TXTCP3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCP3.Location = new System.Drawing.Point(17, 353);
            this.TXTCP3.Multiline = true;
            this.TXTCP3.Name = "TXTCP3";
            this.TXTCP3.Size = new System.Drawing.Size(538, 76);
            this.TXTCP3.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(250, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 69);
            this.button1.TabIndex = 37;
            this.button1.Text = "&GUARDAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NUEVO_MEMORANDUN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 543);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NUEVO_MEMORANDUN";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NUEVO MEMORANDUM";
            this.Load += new System.EventHandler(this.NUEVO_MEMORANDUN_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label CLAVE;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel STNOMBRECOMPLETO;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel STPERFIL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel STPC;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel STCODIGO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBTIPO;
        private System.Windows.Forms.ComboBox CMBASUNTO;
        private System.Windows.Forms.ComboBox CMBARMADOR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLCOD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXTCP3;
        private System.Windows.Forms.TextBox TXTCP2;
        private System.Windows.Forms.TextBox TXTCP1;
    }
}