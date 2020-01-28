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

namespace TuristickaAgencija.WinUI.Gradovi
{
    public partial class frmDetalji : Form
    {
        private int ?_id=null;
        APIService _apiService = new APIService("gradovi");
        public frmDetalji(int?ID=null)
        {
            InitializeComponent();
            _id = ID ;
        }


        private async void frmDetalji_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var grad = await _apiService.GetById<Model.Gradovi>(_id);
                txtNaziv.Text = grad.NazivGrada;
                txtPostanskiBroj.Text = grad.PostanskiBroj;

            }
        }

        private async void btnSnimi_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.ValidateChildren())
            {
                GradoviInsertRequest request = new GradoviInsertRequest()
                {
                    NazivGrada = txtNaziv.Text,
                    PostanskiBroj = txtPostanskiBroj.Text
                };
                if (_id.HasValue)
                {
                    await _apiService.Update<Model.Gradovi>(_id, request);

                }
                else
                {
                    await _apiService.Insert<Model.Gradovi>(request);
                }
                MessageBox.Show("Operacija uspjesna!");
                this.Close();
            }
          
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider1.SetError(txtNaziv, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNaziv, null);

            }
        }

        private void txtPostanskiBroj_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPostanskiBroj.Text))
            {
                errorProvider1.SetError(txtPostanskiBroj, Properties.Resources.Validation_Required);
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(txtPostanskiBroj, null);

            }
        }
    }
}
