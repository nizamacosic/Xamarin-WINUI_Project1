namespace TuristickaAgencija.WinUI.Izvjestaji
{
    partial class txtUkupno
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIzvjestaj = new System.Windows.Forms.DataGridView();
            this.Putovanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRezervacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zarada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGodina
            // 
            this.cmbGodina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Location = new System.Drawing.Point(80, 19);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(140, 23);
            this.cmbGodina.TabIndex = 0;
            this.cmbGodina.SelectedIndexChanged += new System.EventHandler(this.cmbGodina_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Godina:";
            // 
            // dgvIzvjestaj
            // 
            this.dgvIzvjestaj.AllowUserToAddRows = false;
            this.dgvIzvjestaj.AllowUserToDeleteRows = false;
            this.dgvIzvjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestaj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Putovanje,
            this.Grad,
            this.BrojRezervacija,
            this.Zarada});
            this.dgvIzvjestaj.Location = new System.Drawing.Point(12, 61);
            this.dgvIzvjestaj.Name = "dgvIzvjestaj";
            this.dgvIzvjestaj.ReadOnly = true;
            this.dgvIzvjestaj.Size = new System.Drawing.Size(776, 224);
            this.dgvIzvjestaj.TabIndex = 4;
            // 
            // Putovanje
            // 
            this.Putovanje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Putovanje.DataPropertyName = "Putovanje";
            this.Putovanje.HeaderText = "Putovanje";
            this.Putovanje.Name = "Putovanje";
            this.Putovanje.ReadOnly = true;
            // 
            // Grad
            // 
            this.Grad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grad.DataPropertyName = "Grad";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            // 
            // BrojRezervacija
            // 
            this.BrojRezervacija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojRezervacija.DataPropertyName = "BrojRezervacija";
            this.BrojRezervacija.HeaderText = "Broj rezervacija";
            this.BrojRezervacija.Name = "BrojRezervacija";
            this.BrojRezervacija.ReadOnly = true;
            // 
            // Zarada
            // 
            this.Zarada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Zarada.DataPropertyName = "Zarada";
            this.Zarada.HeaderText = "Zarada";
            this.Zarada.Name = "Zarada";
            this.Zarada.ReadOnly = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(18, 318);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(770, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // txtUkupno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvIzvjestaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGodina);
            this.Name = "txtUkupno";
            this.Text = "frmIzvjestaj";
            this.Load += new System.EventHandler(this.frmIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIzvjestaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Putovanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRezervacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zarada;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}