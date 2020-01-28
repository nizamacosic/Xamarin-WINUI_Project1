namespace TuristickaAgencija.WinUI.Putovanja
{
    partial class frmPutovanja
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
            this.cmbPretraga = new System.Windows.Forms.ComboBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPutovanja = new System.Windows.Forms.DataGridView();
            this.PutovanjaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaPutovanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutovanja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(416, 33);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(301, 23);
            this.btnDodaj.TabIndex = 15;
            this.btnDodaj.Text = "Novo putovanje";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDodaj_MouseClick);
            // 
            // cmbPretraga
            // 
            this.cmbPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPretraga.FormattingEnabled = true;
            this.cmbPretraga.Location = new System.Drawing.Point(14, 36);
            this.cmbPretraga.Name = "cmbPretraga";
            this.cmbPretraga.Size = new System.Drawing.Size(156, 23);
            this.cmbPretraga.TabIndex = 16;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazi.Location = new System.Drawing.Point(205, 33);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(110, 23);
            this.btnTrazi.TabIndex = 17;
            this.btnTrazi.Text = "Trazi";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPutovanja);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 310);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // dgvPutovanja
            // 
            this.dgvPutovanja.AllowUserToAddRows = false;
            this.dgvPutovanja.AllowUserToDeleteRows = false;
            this.dgvPutovanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPutovanja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PutovanjaId,
            this.Naziv,
            this.VrstaPutovanja,
            this.Grad,
            this.Slika});
            this.dgvPutovanja.Location = new System.Drawing.Point(6, 19);
            this.dgvPutovanja.Name = "dgvPutovanja";
            this.dgvPutovanja.ReadOnly = true;
            this.dgvPutovanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPutovanja.Size = new System.Drawing.Size(699, 285);
            this.dgvPutovanja.TabIndex = 0;
            this.dgvPutovanja.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPutovanja_MouseDoubleClick);
            // 
            // PutovanjaId
            // 
            this.PutovanjaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PutovanjaId.DataPropertyName = "PutovanjaId";
            this.PutovanjaId.HeaderText = "PutovanjaId";
            this.PutovanjaId.Name = "PutovanjaId";
            this.PutovanjaId.ReadOnly = true;
            this.PutovanjaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // VrstaPutovanja
            // 
            this.VrstaPutovanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VrstaPutovanja.DataPropertyName = "VrstaPutovanja";
            this.VrstaPutovanja.HeaderText = "Vrsta putovanja";
            this.VrstaPutovanja.Name = "VrstaPutovanja";
            this.VrstaPutovanja.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmPutovanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.cmbPretraga);
            this.Controls.Add(this.btnDodaj);
            this.Name = "frmPutovanja";
            this.Text = "frmPutovanja";
            this.Load += new System.EventHandler(this.frmPutovanja_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutovanja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbPretraga;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPutovanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn PutovanjaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaPutovanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
    }
}