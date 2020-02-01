using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuristickaAgencija.Model;
using TuristickaAgencija.Model.Requests;

namespace TuristickaAgencija.WinUI.Putovanja
{
    public partial class frmIzletiPutovanja : Form
    {
        public frmIzletiPutovanja()
        {
            InitializeComponent();
        }
        APIService _putovanja = new APIService("Putovanja");
        APIService _putovanjaIzleti = new APIService("PutovanjaFakultativni");

        private async void frmIzletiPutovanja_Load(object sender, EventArgs e)
        {
            await LoadPutovanja();

            var result = await _putovanjaIzleti.Get<List<PutovanjaFakultativni>>(null);
            dgv1.AutoGenerateColumns = false;
            dgv1.DataSource = result;
        }

        private async Task LoadPutovanja()
        {
            var result = await _putovanja.Get<List<Model.Putovanja>>(null);
            result.Insert(0, new Model.Putovanja());
            cmbPutovanja.DataSource = result;

            cmbPutovanja.DisplayMember = "Putovanje";
            cmbPutovanja.ValueMember = "PutovanjaId";
        }

        private async void btnTrazi_Click(object sender, EventArgs e)
        {
            PutovanjaFakultativniSearchRequest search = null;
            if (cmbPutovanja.SelectedIndex > 0)
            {
                search = new PutovanjaFakultativniSearchRequest()
                {
                    PutovanjeId = (int?)cmbPutovanja.SelectedValue
                };
            }

            var result = await _putovanjaIzleti.Get<List<PutovanjaFakultativni>>(search);
            dgv1.AutoGenerateColumns = false;
            dgv1.DataSource = result;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmPutovanjaIzleti frm = new frmPutovanjaIzleti();
            frm.Show();
        }

        private async void dgv1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgv1.SelectedRows[0].Cells[0].Value;
            DialogResult dialogResult = MessageBox.Show("Da li želite obrisati izlet s putovanja?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PutovanjaFakultativni rez = await _putovanjaIzleti.Delete<Model.PutovanjaFakultativni>(int.Parse(id.ToString()));
                MessageBox.Show("Uspješna operacija.");
            }
        }
    }

}
