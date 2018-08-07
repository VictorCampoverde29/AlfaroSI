namespace ALFARO_CAJA
{
    partial class Nueva_Actividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nueva_Actividad));
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.horainicio = new System.Windows.Forms.DateTimePicker();
            this.horatermino = new System.Windows.Forms.DateTimePicker();
            this.dtptermino = new System.Windows.Forms.DateTimePicker();
            this.porcentaje = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.STNOMBRECOMPLETO = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPERFIL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STPC = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STCODIGO = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbarea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.actividad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpinicio
            // 
            this.dtpinicio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpinicio.Location = new System.Drawing.Point(77, 63);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(271, 22);
            this.dtpinicio.TabIndex = 5;
            // 
            // horainicio
            // 
            this.horainicio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horainicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horainicio.Location = new System.Drawing.Point(355, 63);
            this.horainicio.Name = "horainicio";
            this.horainicio.ShowUpDown = true;
            this.horainicio.Size = new System.Drawing.Size(98, 22);
            this.horainicio.TabIndex = 6;
            // 
            // horatermino
            // 
            this.horatermino.Enabled = false;
            this.horatermino.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horatermino.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horatermino.Location = new System.Drawing.Point(355, 95);
            this.horatermino.Name = "horatermino";
            this.horatermino.ShowUpDown = true;
            this.horatermino.Size = new System.Drawing.Size(98, 22);
            this.horatermino.TabIndex = 8;
            // 
            // dtptermino
            // 
            this.dtptermino.Enabled = false;
            this.dtptermino.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptermino.Location = new System.Drawing.Point(77, 95);
            this.dtptermino.Name = "dtptermino";
            this.dtptermino.Size = new System.Drawing.Size(271, 22);
            this.dtptermino.TabIndex = 7;
            // 
            // porcentaje
            // 
            this.porcentaje.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentaje.Location = new System.Drawing.Point(104, 125);
            this.porcentaje.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Size = new System.Drawing.Size(56, 22);
            this.porcentaje.TabIndex = 10;
            this.porcentaje.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(0, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "TERMINO:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 159);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(463, 22);
            this.statusStrip1.TabIndex = 56;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "AREA:";
            // 
            // cmbarea
            // 
            this.cmbarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbarea.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbarea.FormattingEnabled = true;
            this.cmbarea.Items.AddRange(new object[] {
            "ALMACEN",
            "DIRECCION TECNICA",
            "GERENCIA",
            "LABORATORIOS",
            "SISTEMAS",
            "SUPERVISORES",
            "TELEMARKETING",
            "VENDEDORES"});
            this.cmbarea.Location = new System.Drawing.Point(77, 8);
            this.cmbarea.Name = "cmbarea";
            this.cmbarea.Size = new System.Drawing.Size(271, 21);
            this.cmbarea.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "ACTIVIDAD:";
            // 
            // actividad
            // 
            this.actividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.actividad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actividad.Location = new System.Drawing.Point(77, 35);
            this.actividad.Name = "actividad";
            this.actividad.Size = new System.Drawing.Size(376, 22);
            this.actividad.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "INICIO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "% DE LA TAREA:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(215, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "&REGISTRAR ACTIVIDAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nueva_Actividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.actividad);
            this.Controls.Add(this.cmbarea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtptermino);
            this.Controls.Add(this.horatermino);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.porcentaje);
            this.Controls.Add(this.horainicio);
            this.Controls.Add(this.dtpinicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Nueva_Actividad";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NUEVA ACTIVIDAD";
            this.Load += new System.EventHandler(this.Nueva_Actividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.DateTimePicker horainicio;
        private System.Windows.Forms.DateTimePicker horatermino;
        private System.Windows.Forms.DateTimePicker dtptermino;
        private System.Windows.Forms.NumericUpDown porcentaje;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel STNOMBRECOMPLETO;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel STPERFIL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel STPC;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel STCODIGO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox actividad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}