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
    public partial class frmPutovanjaIzleti : Form
    {
        APIService _putovanje = new APIService("Putovanja");
        APIService _izleti= new APIService("FakultativniIzleti");
        APIService _putovanjaIzleti= new APIService("PutovanjaFakultativni");
        public frmPutovanjaIzleti()
        {
            InitializeComponent();
        }

        private async void frmPutovanjaIzleti_Load(object sender, EventArgs e)
        {
            await LoadIzleti();
            await LoadPutovanja();

        }
        private async Task LoadPutovanja()
        {
            var result = await _putovanje.Get<List<Model.Putovanja>>(null);
            cmbPutovanje.DataSource = result;
            cmbPutovanje.ValueMember = "PutovanjaId";
            cmbPutovanje.DisplayMember = "Putovanje";
        }
        private async Task LoadIzleti()
        {
            var result =await _izleti.Get<List<Model.FakultativniIzleti>>(null);
            cmbIzlet.DataSource = result;
            cmbIzlet.ValueMember = "FakultativniIzletiId";
            cmbIzlet.DisplayMember = "FakultativniIzlet";
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            PutovanjaFakultativniInsertRequest request = new PutovanjaFakultativniInsertRequest()
            {
                FakultativniIzletId = (int)cmbIzlet.SelectedValue,
                PutovanjeId = (int)cmbPutovanje.SelectedValue,
            };
            await _putovanjaIzleti.Insert<Model.PutovanjaFakultativni>(request);
            if (this.ValidateChildren())
            {
                MessageBox.Show("Operacija uspjesna!");
                this.Close();
            }
        }
    }
}
