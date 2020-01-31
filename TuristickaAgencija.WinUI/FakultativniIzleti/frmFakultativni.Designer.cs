namespace TuristickaAgencija.WinUI.Putovanja
{
    partial class frmFakultativni
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
            this.nazivIzleta = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvIzleti = new System.Windows.Forms.DataGridView();
            this.FakultativniIzletiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisIzleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzleti)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivIzleta
            // 
            this.nazivIzleta.AutoSize = true;
            this.nazivIzleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivIzleta.Location = new System.Drawing.Point(15, 43);
            this.nazivIzleta.Name = "nazivIzleta";
            this.nazivIzleta.Size = new System.Drawing.Size(79, 16);
            this.nazivIzleta.TabIndex = 0;
            this.nazivIzleta.Text = "Naziv izleta:";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazi.Location = new System.Drawing.Point(322, 58);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(92, 26);
            this.btnTrazi.TabIndex = 2;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIzleti);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // dgvIzleti
            // 
            this.dgvIzleti.AllowUserToAddRows = false;
            this.dgvIzleti.AllowUserToDeleteRows = false;
            this.dgvIzleti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzleti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FakultativniIzletiId,
            this.Naziv,
            this.OpisIzleta,
            this.Grad});
            this.dgvIzleti.Location = new System.Drawing.Point(3, 19);
            this.dgvIzleti.Name = "dgvIzleti";
            this.dgvIzleti.ReadOnly = true;
            this.dgvIzleti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzleti.Size = new System.Drawing.Size(399, 193);
            this.dgvIzleti.TabIndex = 0;
            this.dgvIzleti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvIzleti_MouseDoubleClick);
            // 
            // FakultativniIzletiId
            // 
            this.FakultativniIzletiId.DataPropertyName = "FakultativniIzletiId";
            this.FakultativniIzletiId.HeaderText = "FakultativniIzletiId";
            this.FakultativniIzletiId.Name = "FakultativniIzletiId";
            this.FakultativniIzletiId.ReadOnly = true;
            this.FakultativniIzletiId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "NazivIzleta";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // OpisIzleta
            // 
            this.OpisIzleta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OpisIzleta.DataPropertyName = "OpisIzleta";
            this.OpisIzleta.HeaderText = "OpisIzleta";
            this.OpisIzleta.Name = "OpisIzleta";
            this.OpisIzleta.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // cmbGrad
            // 
            this.cmbGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(12, 61);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(265, 23);
            this.cmbGrad.TabIndex = 4;
            // 
            // frmFakultativni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.nazivIzleta);
            this.Name = "frmFakultativni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmFakultativni";
            this.Load += new System.EventHandler(this.frmFakultativni_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzleti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazivIzleta;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIzleti;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FakultativniIzletiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisIzleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
    }
}