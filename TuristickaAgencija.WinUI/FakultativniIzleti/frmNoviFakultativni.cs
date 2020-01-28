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
    public partial class frmNoviFakultativni : Form
    {
        APIService _fakultativni = new APIService("FakultativniIzleti");
        APIService _gradovi = new APIService("Gradovi");
        private int? _id = null;

        public frmNoviFakultativni(int?id=null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmNoviFakultativni_Load(object sender, EventArgs e)
        {
            await LoadGradovi();

            if (_id.HasValue)
            {
                var entity = await _fakultativni.GetById<Model.FakultativniIzleti>(_id);
                txtNaziv.Text = entity.NazivIzleta;
                txtOpis.Text = entity.OpisIzleta;
                if (entity.GradId.HasValue)
                {
                    var grad = await _gradovi.GetById<Model.Gradovi>(entity.GradId);
                    cmbGrad.SelectedIndex = cmbGrad.FindStringExact(grad.NazivGrada);
                }
            }


        }
        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Gradovi>>(null);
            cmbGrad.DataSource = result;
            cmbGrad.DisplayMember = "NazivGrada";
            cmbGrad.ValueMember = "GradId";
        }
        private async void btnSnimi_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.ValidateChildren())
            {
                FakultativniIzletiInsertRequest request = new FakultativniIzletiInsertRequest()
                {
                    NazivIzleta = txtNaziv.Text,
                    OpisIzleta = txtOpis.Text,
                    GradId = (int?)cmbGrad.SelectedValue
                };
                if (_id.HasValue)
                {
                    await _fakultativni.Update<Model.FakultativniIzleti>(_id, request);

                }
                else
                {
                    await _fakultativni.Insert<Model.FakultativniIzleti>(request);
                }
                MessageBox.Show("Operacija uspjesna!");
                this.Close();
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNaziv, null);

            }
        }
    }
}
