using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuristickaAgencija.Model.Requests;

namespace TuristickaAgencija.WinUI.Zaposlenici
{
    public partial class frmRegistracija : Form
    {
        APIService _zaposlenici = new APIService("Zaposlenici");
        public frmRegistracija()
        {
            InitializeComponent();

        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {

        }

        ZaposleniciInsertRequest request = new ZaposleniciInsertRequest();
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            request.Ime = txtIme.Text;
            request.Prezime = txtPrezime.Text;
            request.Email = txtEmail.Text;
            request.Kontakt = txtKontakt.Text;
            request.KorisnickoIme = txtKorisnickoIme.Text;
            request.Password = txtLozinka.Text;
            request.PasswordPotvrda = txtLozinkaPotvrda.Text;

            await _zaposlenici.Insert<Model.Zaposlenici>(request);
            MessageBox.Show("Uspjesno ste se prijavili!");
        }
        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                
                txtSlika.Text = fileName;
                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
            }
        }
    }
}
