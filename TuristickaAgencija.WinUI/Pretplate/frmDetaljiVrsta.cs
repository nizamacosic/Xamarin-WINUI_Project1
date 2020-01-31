using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuristickaAgencija.Model.Requests;

namespace TuristickaAgencija.WinUI.Pretplate
{
    public partial class frmDetaljiVrsta : Form
    {
        private int? _id = null;
        APIService _apiService = new APIService("VrstaPutovanja");
        public frmDetaljiVrsta(int? ID = null)
        {
            InitializeComponent();
            _id = ID;
        }
        VrstaPutovanjaInsertRequest request = new VrstaPutovanjaInsertRequest();

        private async void button1_Click(object sender, EventArgs e)
        {
            request.Oznaka = txtOznaka.Text;
            request.Vrijednost = int.Parse(textBox2.Text.ToString());
            if(_id.HasValue)
            {
                await _apiService.Update<Model.VrstaPutovanja>(_id,request);
            }
            else
            {
                await _apiService.Insert<Model.VrstaPutovanja>(request);
            }
            
            if(this.ValidateChildren())
            {
                MessageBox.Show("Operacija uspješna");
                this.Close();
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
       
            if (!Regex.IsMatch(textBox2.Text, @"[0-9]+"))
            {
                errorProvider1.SetError(textBox2, "Unesite broj");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox2, null);
            }
        }

        private void frmDetaljiVrsta_FormClosing(object sender, FormClosingEventArgs e)
        {
            errorProvider1.Clear();
            e.Cancel = false;
        }

        private async void frmDetaljiVrsta_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var vp = await _apiService.GetById<Model.VrstaPutovanja>(_id);
                txtOznaka.Text = vp.Oznaka;
                textBox2.Text = vp.Vrijednost.ToString();
            }
        }

        private void txtOznaka_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Length>9)
            {
                errorProvider1.SetError(textBox2, "Možete unijeti samo 9 karaktera.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox2, null);
            }
        }
    }
}
