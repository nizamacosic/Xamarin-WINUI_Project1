namespace TuristickaAgencija.WinUI.Smjestaj
{
    partial class frmSmjestaj
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSmjestaj = new System.Windows.Forms.DataGridView();
            this.cbGradovi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SmjestajID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaNoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmjestaj)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSmjestaj);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvSmjestaj
            // 
            this.dgvSmjestaj.AllowUserToAddRows = false;
            this.dgvSmjestaj.AllowUserToDeleteRows = false;
            this.dgvSmjestaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSmjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSmjestaj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SmjestajID,
            this.Naziv,
            this.CijenaNoc,
            this.GradID});
            this.dgvSmjestaj.Location = new System.Drawing.Point(0, 19);
            this.dgvSmjestaj.Name = "dgvSmjestaj";
            this.dgvSmjestaj.ReadOnly = true;
            this.dgvSmjestaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSmjestaj.Size = new System.Drawing.Size(734, 256);
            this.dgvSmjestaj.TabIndex = 1;
            this.dgvSmjestaj.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSmjestaj_MouseDoubleClick);
            // 
            // cbGradovi
            // 
            this.cbGradovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGradovi.FormattingEnabled = true;
            this.cbGradovi.Location = new System.Drawing.Point(12, 35);
            this.cbGradovi.Name = "cbGradovi";
            this.cbGradovi.Size = new System.Drawing.Size(211, 23);
            this.cbGradovi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberi grad:";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazi.Location = new System.Drawing.Point(250, 35);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(93, 23);
            this.btnTrazi.TabIndex = 3;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTrazi_MouseClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(585, 35);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(159, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Novi smještaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDodaj_MouseClick);
            // 
            // SmjestajID
            // 
            this.SmjestajID.DataPropertyName = "SmjestajID";
            this.SmjestajID.HeaderText = "SmjestajID";
            this.SmjestajID.Name = "SmjestajID";
            this.SmjestajID.ReadOnly = true;
            this.SmjestajID.Visible = false;
            this.SmjestajID.Width = 82;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // CijenaNoc
            // 
            this.CijenaNoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CijenaNoc.DataPropertyName = "CijenaNoc";
            this.CijenaNoc.HeaderText = "Cijena/Noc";
            this.CijenaNoc.Name = "CijenaNoc";
            this.CijenaNoc.ReadOnly = true;
            // 
            // GradID
            // 
            this.GradID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GradID.DataPropertyName = "Grad";
            this.GradID.HeaderText = "Grad";
            this.GradID.Name = "GradID";
            this.GradID.ReadOnly = true;
            // 
            // frmSmjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 355);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGradovi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSmjestaj";
            this.Text = "frmSmjestaj";
            this.Load += new System.EventHandler(this.frmSmjestaj_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmjestaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSmjestaj;
        private System.Windows.Forms.ComboBox cbGradovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn SmjestajID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaNoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradID;
    }
}