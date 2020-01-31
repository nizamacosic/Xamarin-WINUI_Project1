using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuristickaAgencija.WinUI.Gradovi;
using TuristickaAgencija.WinUI.Izvjestaji;
using TuristickaAgencija.WinUI.Korisnici;
using TuristickaAgencija.WinUI.Novosti;
using TuristickaAgencija.WinUI.Putovanja;
using TuristickaAgencija.WinUI.Rezervacije;
using TuristickaAgencija.WinUI.Smjestaj;
using TuristickaAgencija.WinUI.Termini;
using TuristickaAgencija.WinUI.Vodici;
using TuristickaAgencija.WinUI.Zaposlenici;
using frmDetalji = TuristickaAgencija.WinUI.Termini.frmDetalji;

namespace TuristickaAgencija.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }
        
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGradovi gradovi = new frmGradovi();
            gradovi.MdiParent = this;
            gradovi.WindowState = FormWindowState.Maximized;
            gradovi.Show();
        }

        private void noviGradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gradovi.frmDetalji frm = new Gradovi.frmDetalji();

            frm.Show();

        }

        private void novoPutovanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPutovanja frm = new frmPutovanja();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

 

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVodici frm = new frmVodici();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void pretragaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmSmjestaj frm = new frmSmjestaj();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void noviSmjestajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Smjestaj.frmDetalji frm = new Smjestaj.frmDetalji();
            frm.Show();
        }

        private void pretragaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmKorisnici frm = new frmKorisnici();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void pretragaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmNovosti frm = new frmNovosti();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void dodavanjeNovostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novosti.frmDetalji frm = new Novosti.frmDetalji();
            frm.Show();
        }

        private void pretragaToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmFakultativni frm = new frmFakultativni();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void noviIzletToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNoviFakultativni frm = new frmNoviFakultativni();
            frm.Show();
        }




        private void pretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRezervacije frm = new frmRezervacije();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void novaRezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervacije.frmDetalji frm = new Rezervacije.frmDetalji();
            frm.Show();
        }

        private void pretragaToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Uplate.frmUplate frm = new Uplate.frmUplate();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void novaUplataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uplate.frmDetalji frm = new Uplate.frmDetalji();
            frm.Show();
        }

        private void registracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistracija frm = new frmRegistracija(); frm.Show();
        }

        private void dodajIzletNaPutovanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPutovanjaIzleti frm = new frmPutovanjaIzleti();
            frm.Show();
        }

        private void izvještajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzvjestaj frm = new frmIzvjestaj();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void pretragaToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmTermini frm = new frmTermini();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void noviTerminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalji frm = new frmDetalji();
            frm.Show();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
