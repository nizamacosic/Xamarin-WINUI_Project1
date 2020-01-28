using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuristickaAgencija.Model.Requests;

namespace TuristickaAgencija.WinUI.Putovanja
{
    public partial class frmFakultativni : Form
    {
        APIService _fakultativni = new APIService("FakultativniIzleti");
        APIService _gradovi = new APIService("Gradovi");

        public frmFakultativni()
        {
            InitializeComponent();
        }

        private async void frmFakultativni_Load(object sender, EventArgs e)
        {
          
            var result = await _fakultativni.Get<List<Model.FakultativniIzleti>>(null);
            dgvIzleti.AutoGenerateColumns = false;

            dgvIzleti.DataSource = result;
             await LoadGradovi();
            

        }
        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Gradovi>>(null);
            result.Insert(0, new Model.Gradovi());
            cmbGrad.DataSource = result;
            
            cmbGrad.DisplayMember = "NazivGrada";
            cmbGrad.ValueMember = "GradId";
        }

        private async void btnTrazi_Click(object sender, EventArgs e)
        {
            var search = new FakultativniIzletiSearchRequest();
            if(cmbGrad.SelectedIndex==0)
            {
                search = null;
            }
            else
            {
                search.GradId = (int?)cmbGrad.SelectedValue;
            }
            var result = await _fakultativni.Get<List<Model.FakultativniIzleti>>(search);
            dgvIzleti.AutoGenerateColumns = false;

            dgvIzleti.DataSource = result;

        }

        private void dgvIzleti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvIzleti.SelectedRows[0].Cells[0].Value;

            frmNoviFakultativni detalji = new frmNoviFakultativni(int.Parse(id.ToString()));

            detalji.Show();
        }
    }
}
