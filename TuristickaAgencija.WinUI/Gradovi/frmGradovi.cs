﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;
using TuristickaAgencija.Model.Requests;

namespace TuristickaAgencija.WinUI.Gradovi
{
    public partial class frmGradovi : Form
    {
        private readonly APIService _apiService = new APIService("Gradovi");
        public frmGradovi()
        {
            InitializeComponent();
        }

     

        private void dgvGradovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvGradovi.SelectedRows[0].Cells[0].Value;

            frmDetalji detalji = new frmDetalji(int.Parse(id.ToString()));

            detalji.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDetalji frm = new frmDetalji();
            frm.Show();
        }

        private async void txtPretragaNaziv_TextChanged(object sender, EventArgs e)
        {
            var search = new GradoviSearchRequest()
            {
                NazivGrada = txtPretragaNaziv.Text
            };

            var result = await _apiService.Get<List<Model.Gradovi>>(search);
            dgvGradovi.DataSource = result;
        }
    }
}
