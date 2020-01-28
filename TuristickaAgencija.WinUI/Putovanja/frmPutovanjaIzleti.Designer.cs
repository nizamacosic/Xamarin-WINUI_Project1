namespace TuristickaAgencija.WinUI.Putovanja
{
    partial class frmPutovanjaIzleti
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPutovanje = new System.Windows.Forms.ComboBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.cmbIzlet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Putovanje:";
            // 
            // cmbPutovanje
            // 
            this.cmbPutovanje.FormattingEnabled = true;
            this.cmbPutovanje.Location = new System.Drawing.Point(76, 82);
            this.cmbPutovanje.Name = "cmbPutovanje";
            this.cmbPutovanje.Size = new System.Drawing.Size(242, 21);
            this.cmbPutovanje.TabIndex = 1;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(126, 222);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(112, 34);
            this.btnSnimi.TabIndex = 2;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // cmbIzlet
            // 
            this.cmbIzlet.FormattingEnabled = true;
            this.cmbIzlet.Location = new System.Drawing.Point(78, 155);
            this.cmbIzlet.Name = "cmbIzlet";
            this.cmbIzlet.Size = new System.Drawing.Size(242, 21);
            this.cmbIzlet.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Izlet:";
            // 
            // frmPutovanjaIzleti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 315);
            this.Controls.Add(this.cmbIzlet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.cmbPutovanje);
            this.Controls.Add(this.label1);
            this.Name = "frmPutovanjaIzleti";
            this.Text = "frmPutovanjaIzleti";
            this.Load += new System.EventHandler(this.frmPutovanjaIzleti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPutovanje;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ComboBox cmbIzlet;
        private System.Windows.Forms.Label label2;
    }
}