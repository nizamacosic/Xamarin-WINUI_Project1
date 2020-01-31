namespace TuristickaAgencija.WinUI
{
    partial class frmTerminiVodici
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
            this.cmbVodici = new System.Windows.Forms.ComboBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTermini = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbVodici
            // 
            this.cmbVodici.FormattingEnabled = true;
            this.cmbVodici.Location = new System.Drawing.Point(45, 77);
            this.cmbVodici.Name = "cmbVodici";
            this.cmbVodici.Size = new System.Drawing.Size(269, 21);
            this.cmbVodici.TabIndex = 0;
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(115, 215);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(98, 33);
            this.btnSnimi.TabIndex = 2;
            this.btnSnimi.Text = "Dodaj";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vodič";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Termin putovanja";
            // 
            // cmbTermini
            // 
            this.cmbTermini.FormattingEnabled = true;
            this.cmbTermini.Location = new System.Drawing.Point(47, 150);
            this.cmbTermini.Name = "cmbTermini";
            this.cmbTermini.Size = new System.Drawing.Size(269, 21);
            this.cmbTermini.TabIndex = 4;
            // 
            // frmTerminiVodici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 332);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTermini);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.cmbVodici);
            this.Name = "frmTerminiVodici";
            this.Text = "frmTerminiVodici";
            this.Load += new System.EventHandler(this.frmTerminiVodici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVodici;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTermini;
    }
}