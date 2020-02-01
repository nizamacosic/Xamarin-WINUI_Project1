namespace TuristickaAgencija.WinUI.Pretplate
{
    partial class frmVrstaPutovanja
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVrsta = new System.Windows.Forms.DataGridView();
            this.VrstaPutovanjaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijednost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrsta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(18, 43);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(128, 28);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj vrstu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVrsta);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 344);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dgvVrsta
            // 
            this.dgvVrsta.AllowUserToAddRows = false;
            this.dgvVrsta.AllowUserToDeleteRows = false;
            this.dgvVrsta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrsta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VrstaPutovanjaId,
            this.Oznaka,
            this.Vrijednost});
            this.dgvVrsta.Location = new System.Drawing.Point(6, 12);
            this.dgvVrsta.Name = "dgvVrsta";
            this.dgvVrsta.ReadOnly = true;
            this.dgvVrsta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVrsta.Size = new System.Drawing.Size(764, 326);
            this.dgvVrsta.TabIndex = 0;
            this.dgvVrsta.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvVrsta_MouseDoubleClick);
            // 
            // VrstaPutovanjaId
            // 
            this.VrstaPutovanjaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VrstaPutovanjaId.DataPropertyName = "VrstaPutovanjaId";
            this.VrstaPutovanjaId.HeaderText = "VrstaPutovanjaId";
            this.VrstaPutovanjaId.Name = "VrstaPutovanjaId";
            this.VrstaPutovanjaId.ReadOnly = true;
            this.VrstaPutovanjaId.Visible = false;
            // 
            // Oznaka
            // 
            this.Oznaka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Oznaka.DataPropertyName = "Oznaka";
            this.Oznaka.HeaderText = "Oznaka";
            this.Oznaka.Name = "Oznaka";
            this.Oznaka.ReadOnly = true;
            // 
            // Vrijednost
            // 
            this.Vrijednost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vrijednost.DataPropertyName = "Vrijednost";
            this.Vrijednost.HeaderText = "Vrijednost";
            this.Vrijednost.Name = "Vrijednost";
            this.Vrijednost.ReadOnly = true;
            // 
            // frmVrstaPutovanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodaj);
            this.Name = "frmVrstaPutovanja";
            this.Text = "frmVrstaPutovanja";
            this.Load += new System.EventHandler(this.frmVrstaPutovanja_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrsta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaPutovanjaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijednost;
    }
}