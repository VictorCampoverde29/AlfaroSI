namespace ALFARO_CAJA
{
    partial class Detalle_de_Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalle_de_Devolucion));
            this.LBLCOD = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LBLTIPO = new System.Windows.Forms.Label();
            this.LBLGUIA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLFECHA = new System.Windows.Forms.Label();
            this.LBLESTADO = new System.Windows.Forms.Label();
            this.LBLFECHATRASLADO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLLINEA = new System.Windows.Forms.Label();
            this.LBLTRANSPORTE = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBLREFERENCIA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PANELDESCARGAR = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PANELDESCARGAR.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLCOD
            // 
            this.LBLCOD.AutoSize = true;
            this.LBLCOD.Location = new System.Drawing.Point(202, 41);
            this.LBLCOD.Name = "LBLCOD";
            this.LBLCOD.Size = new System.Drawing.Size(35, 13);
            this.LBLCOD.TabIndex = 55;
            this.LBLCOD.Text = "label1";
            this.LBLCOD.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(606, 214);
            this.dataGridView1.TabIndex = 44;
            // 
            // LBLTIPO
            // 
            this.LBLTIPO.AutoSize = true;
            this.LBLTIPO.Location = new System.Drawing.Point(243, 36);
            this.LBLTIPO.Name = "LBLTIPO";
            this.LBLTIPO.Size = new System.Drawing.Size(37, 13);
            this.LBLTIPO.TabIndex = 62;
            this.LBLTIPO.Text = "CONS";
            this.LBLTIPO.Visible = false;
            // 
            // LBLGUIA
            // 
            this.LBLGUIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLGUIA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLGUIA.Location = new System.Drawing.Point(12, 9);
            this.LBLGUIA.Name = "LBLGUIA";
            this.LBLGUIA.Size = new System.Drawing.Size(606, 23);
            this.LBLGUIA.TabIndex = 63;
            this.LBLGUIA.Text = "---";
            this.LBLGUIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 64;
            this.label1.Text = "LINEA:";
            // 
            // LBLFECHA
            // 
            this.LBLFECHA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLFECHA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLFECHA.Location = new System.Drawing.Point(112, 36);
            this.LBLFECHA.Name = "LBLFECHA";
            this.LBLFECHA.Size = new System.Drawing.Size(84, 23);
            this.LBLFECHA.TabIndex = 63;
            this.LBLFECHA.Text = "--/--/----";
            this.LBLFECHA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLESTADO
            // 
            this.LBLESTADO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLESTADO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLESTADO.Location = new System.Drawing.Point(426, 36);
            this.LBLESTADO.Name = "LBLESTADO";
            this.LBLESTADO.Size = new System.Drawing.Size(192, 23);
            this.LBLESTADO.TabIndex = 63;
            this.LBLESTADO.Text = "--------";
            this.LBLESTADO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLFECHATRASLADO
            // 
            this.LBLFECHATRASLADO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLFECHATRASLADO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLFECHATRASLADO.Location = new System.Drawing.Point(534, 63);
            this.LBLFECHATRASLADO.Name = "LBLFECHATRASLADO";
            this.LBLFECHATRASLADO.Size = new System.Drawing.Size(84, 23);
            this.LBLFECHATRASLADO.TabIndex = 63;
            this.LBLFECHATRASLADO.Text = "--------";
            this.LBLFECHATRASLADO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "FECHA TRASLADO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 64;
            this.label2.Text = "FECHA EMISION:";
            // 
            // LBLLINEA
            // 
            this.LBLLINEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLLINEA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLINEA.Location = new System.Drawing.Point(111, 63);
            this.LBLLINEA.Name = "LBLLINEA";
            this.LBLLINEA.Size = new System.Drawing.Size(293, 23);
            this.LBLLINEA.TabIndex = 63;
            this.LBLLINEA.Text = "--------";
            this.LBLLINEA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLTRANSPORTE
            // 
            this.LBLTRANSPORTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLTRANSPORTE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTRANSPORTE.Location = new System.Drawing.Point(106, 350);
            this.LBLTRANSPORTE.Name = "LBLTRANSPORTE";
            this.LBLTRANSPORTE.Size = new System.Drawing.Size(437, 23);
            this.LBLTRANSPORTE.TabIndex = 63;
            this.LBLTRANSPORTE.Text = "--------";
            this.LBLTRANSPORTE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 64;
            this.label6.Text = "TRANSPORTE:";
            // 
            // LBLREFERENCIA
            // 
            this.LBLREFERENCIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLREFERENCIA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLREFERENCIA.Location = new System.Drawing.Point(106, 316);
            this.LBLREFERENCIA.Name = "LBLREFERENCIA";
            this.LBLREFERENCIA.Size = new System.Drawing.Size(437, 23);
            this.LBLREFERENCIA.TabIndex = 63;
            this.LBLREFERENCIA.Text = "--------";
            this.LBLREFERENCIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "REFERENCIAS:";
            // 
            // PANELDESCARGAR
            // 
            this.PANELDESCARGAR.Controls.Add(this.button2);
            this.PANELDESCARGAR.Controls.Add(this.dateTimePicker1);
            this.PANELDESCARGAR.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANELDESCARGAR.Location = new System.Drawing.Point(141, 376);
            this.PANELDESCARGAR.Name = "PANELDESCARGAR";
            this.PANELDESCARGAR.Size = new System.Drawing.Size(324, 51);
            this.PANELDESCARGAR.TabIndex = 65;
            this.PANELDESCARGAR.TabStop = false;
            this.PANELDESCARGAR.Text = "FECHA INICIO DEL TRASLADO";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(260, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&ELEGIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // Detalle_de_Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 433);
            this.Controls.Add(this.PANELDESCARGAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLFECHATRASLADO);
            this.Controls.Add(this.LBLFECHA);
            this.Controls.Add(this.LBLESTADO);
            this.Controls.Add(this.LBLREFERENCIA);
            this.Controls.Add(this.LBLTRANSPORTE);
            this.Controls.Add(this.LBLLINEA);
            this.Controls.Add(this.LBLGUIA);
            this.Controls.Add(this.LBLTIPO);
            this.Controls.Add(this.LBLCOD);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Detalle_de_Devolucion";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Detalle_de_Devolucion";
            this.Load += new System.EventHandler(this.Detalle_de_Devolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PANELDESCARGAR.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label LBLCOD;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label LBLTIPO;
        public System.Windows.Forms.Label LBLGUIA;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LBLFECHA;
        public System.Windows.Forms.Label LBLESTADO;
        public System.Windows.Forms.Label LBLFECHATRASLADO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LBLLINEA;
        public System.Windows.Forms.Label LBLTRANSPORTE;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label LBLREFERENCIA;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox PANELDESCARGAR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}