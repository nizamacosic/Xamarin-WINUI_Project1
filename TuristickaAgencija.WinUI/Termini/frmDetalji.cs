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

namespace TuristickaAgencija.WinUI.Termini
{
    public partial class frmDetalji : Form
    {
        APIService _smjestaj = new APIService("Smjestaj");
        APIService _termini = new APIService("TerminiPutovanja");
        APIService _putovanja = new APIService("Putovanja");
        private int? _id = null;
        public frmDetalji(int?id=null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmDetalji_Load(object sender, EventArgs e)
        {
            await LoadSmjestaj();
            await LoadPutovanja();
            if (_id.HasValue)
            {
                var entity = await _termini.GetById<Model.TerminiPutovanja>(_id);
                txtBrojMjesta.Text = entity.BrojMjesta.ToString();
                txtCijena.Text = entity.BrojMjesta.ToString();
                dateTimeDO.Value = (DateTime)entity.DatumPovratka;

                dateTimeOD.Value = (DateTime)entity.DatumPolaska;
                if (entity.PutovanjeId > 0)
                {
                    var put = await _putovanja.GetById<Model.Putovanja>(entity.PutovanjeId);
                    cmbPutovanja.SelectedIndex = cmbPutovanja.FindStringExact(put.Naziv);
                }
                if (entity.SmjestajId > 0)
                {
                    var smjestaj = await _smjestaj.GetById<Model.Smjestaj>(entity.SmjestajId);
                    cmbSmjestaj.SelectedIndex = cmbSmjestaj.FindStringExact(smjestaj.Naziv);
                }
                if (entity.Aktivno == true)
                {
                    cbAktivno.Checked = true;
                }
            }

        }
        private async Task LoadSmjestaj()
        {
  
            var result = await _smjestaj.Get<List<Model.Smjestaj>>(null);

            cmbSmjestaj.DataSource = result;
            cmbSmjestaj.DisplayMember = "Naziv";
            cmbSmjestaj.ValueMember = "SmjestajId";
        }

        private async Task LoadPutovanja()
        {
            var result = await _putovanja.Get<List<Model.Putovanja>>(null);
            result.Insert(0, new Model.Putovanja());
            cmbPutovanja.DataSource = result;

            cmbPutovanja.DisplayMember = "Putovanje";
            cmbPutovanja.ValueMember = "PutovanjaId";
        }

        TerminiPutovanjaInsertRequest request = new TerminiPutovanjaInsertRequest();
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            request.BrojMjesta = int.Parse(txtBrojMjesta.Text.ToString());
            request.Cijena = double.Parse(txtCijena.Text.ToString());
            request.PutovanjeId = (int)cmbPutovanja.SelectedValue;
            request.SmjestajId = (int?)cmbSmjestaj.SelectedValue;
            request.DatumPolaska = dateTimeOD.Value;
            request.DatumPovratka = dateTimeDO.Value;
            if (cbAktivno.Checked == true)
            {
                request.Aktivno = true;
            }
            if (!_id.HasValue)
            {
                await _termini.Insert<Model.TerminiPutovanja>(request);
            }
            else
            {
                await _termini.Update<Model.TerminiPutovanja>(_id, request);
            }
            if (this.ValidateChildren())
            {
                MessageBox.Show("Operacija uspjesna!");
                this.Close();
            }
        }
    }
}
