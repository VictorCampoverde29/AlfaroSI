namespace ALFARO_CAJA
{
    partial class DETALLE_DE_CONSULTA_DESCARGAS_Y_VISITAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DETALLE_DE_CONSULTA_DESCARGAS_Y_VISITAS));
            this.DGVDATADETALLE = new System.Windows.Forms.DataGridView();
            this.lblnombreempresa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDATADETALLE)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDATADETALLE
            // 
            this.DGVDATADETALLE.AllowUserToAddRows = false;
            this.DGVDATADETALLE.AllowUserToDeleteRows = false;
            this.DGVDATADETALLE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDATADETALLE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDATADETALLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDATADETALLE.Location = new System.Drawing.Point(3, 48);
            this.DGVDATADETALLE.Name = "DGVDATADETALLE";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVDATADETALLE.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVDATADETALLE.Size = new System.Drawing.Size(653, 295);
            this.DGVDATADETALLE.TabIndex = 65;
            // 
            // lblnombreempresa
            // 
            this.lblnombreempresa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreempresa.Location = new System.Drawing.Point(6, 13);
            this.lblnombreempresa.Name = "lblnombreempresa";
            this.lblnombreempresa.Size = new System.Drawing.Size(641, 23);
            this.lblnombreempresa.TabIndex = 66;
            this.lblnombreempresa.Text = "label1";
            this.lblnombreempresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblnombreempresa);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 39);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMPRESA";
            // 
            // DETALLE_DE_CONSULTA_DESCARGAS_Y_VISITAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 346);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVDATADETALLE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DETALLE_DE_CONSULTA_DESCARGAS_Y_VISITAS";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.DETALLE_DE_CONSULTA_DESCARGAS_Y_VISITAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDATADETALLE)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGVDATADETALLE;
        public System.Windows.Forms.Label lblnombreempresa;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}