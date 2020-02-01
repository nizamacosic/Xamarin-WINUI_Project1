using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuristickaAgencija.WinUI.Pretplate
{
    public partial class frmVrstaPutovanja : Form
    {
        public frmVrstaPutovanja()
        {
            InitializeComponent();
        }
        APIService _vrsta = new APIService("VrstaPutovanja");
        private async void frmVrstaPutovanja_Load(object sender, EventArgs e)
        {
            var list = await _vrsta.Get<List<Model.VrstaPutovanja>>(null);
            dgvVrsta.AutoGenerateColumns = false;
            dgvVrsta.DataSource = list;
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDetaljiVrsta frm = new frmDetaljiVrsta();
            frm.Show();
        }

   
        private void dgvVrsta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvVrsta.SelectedRows[0].Cells[0].Value;

            frmDetaljiVrsta frm = new frmDetaljiVrsta(int.Parse(id.ToString()));

            frm.Show();
        }
    }
}
