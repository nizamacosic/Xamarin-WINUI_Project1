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

namespace TuristickaAgencija.WinUI.Smjestaj
{
    public partial class frmDetalji : Form
    {
        private int? _id = null;
        APIService _gradovi = new APIService("Gradovi");
        APIService _smjestaj = new APIService("Smjestaj");
        public frmDetalji(int?id=null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmDetalji_Load(object sender, EventArgs e)
        {
            await LoadGradovi();
            if (_id.HasValue) //update
            {
                var smjestaj = await _smjestaj.GetById<Model.Smjestaj>(_id);
                txtNaziv.Text = smjestaj.Naziv;
                txtCijena.Text = smjestaj.CijenaNoc.ToString();
                var gradovi = await _gradovi.GetById<Model.Gradovi>(smjestaj.GradId);
                cmbGrad.SelectedIndex = cmbGrad.FindStringExact(gradovi.NazivGrada);

            }

        }
        private async Task LoadGradovi()
        {

            var result = await _gradovi.Get<List<Model.Gradovi>>(null);
            result.Insert(0, new Model.Gradovi());
            cmbGrad.DataSource = result;
            cmbGrad.DisplayMember = "NazivGrada";
            cmbGrad.ValueMember = "GradId";
        }

        SmjestajInsertRequest request = new SmjestajInsertRequest();
        private async void btnSnimi_MouseClick(object sender, MouseEventArgs e)
        {
            var gradid = cmbGrad.SelectedValue;


            request.Naziv = txtNaziv.Text;
            request.CijenaNoc = (double.Parse(txtCijena.Text));

            request.GradId =(int) gradid;
            if (!_id.HasValue)
            {
                await _smjestaj.Insert<Model.Putovanja>(request);
            }
            else
            {
                await _smjestaj.Update<Model.Putovanja>(_id, request);
            }
            if (this.ValidateChildren())
            {
                MessageBox.Show("Operacija uspjesna!");
                this.Close();
            }
        }
    }
}
