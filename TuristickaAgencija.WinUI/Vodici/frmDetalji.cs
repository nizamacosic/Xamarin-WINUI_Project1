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

namespace TuristickaAgencija.WinUI.Vodici
{
    public partial class frmDetalji : Form
    {
        APIService _vodici = new APIService("Vodici");
        private int ?_id = null;
        public frmDetalji(int?id=null)
        {
            InitializeComponent();
            _id = id;
        }
        VodicInsertRequest request = new VodicInsertRequest();
        ImageConverter imageConverter = new ImageConverter();


        private async void frmDetalji_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
             
                    var vodic = await _vodici.GetById<Model.Vodici>(_id);
                    txtIme.Text = vodic.Ime;
                    txtPrezime.Text = vodic.Prezime;
                    txtKontakt.Text = vodic.Kontakt;
                    txtJMBG.Text = vodic.Jmbg;

                if (vodic.Slika.Length > 0)
                { 
                    pictureBox1.Image = BytesToImage(vodic.Slika);
                }
                    cbZauzet.Checked = (bool)vodic.Zauzet;
            }
        }
        public Image BytesToImage(byte[] arr)
        {

            MemoryStream ms = new MemoryStream(arr);
            return Image.FromStream(ms);
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {

            request.Ime = txtIme.Text;
            request.Prezime = txtPrezime.Text;
            request.Zauzet = cbZauzet.Checked;
            request.Kontakt = txtKontakt.Text;
            request.Jmbg = txtJMBG.Text;
            request.Slika = (System.Byte[])imageConverter.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]"));


            if (!_id.HasValue)
            {
                await _vodici.Insert<Model.Vodici>(request);
            }
            else
            {
                await _vodici.Update<Model.Vodici>(_id, request);
            }
            if (this.ValidateChildren())
            {
                MessageBox.Show("Operacija uspjesna!");
            }
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Slika = file;
                txtSlika.Text = fileName;
                Image image = Image.FromFile(fileName);
                pictureBox1.Image = image;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtKontakt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJMBG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbZauzet_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
