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

namespace TuristickaAgencija.WinUI.Novosti
{
    public partial class frmDetalji : Form
    {
        APIService _novosti = new APIService("Novosti");
        APIService _putovanja= new APIService("Putovanja");
        private int? _id = null;
        public frmDetalji(int?id=null)
        {
            InitializeComponent();
            _id = id;
        }
        NovostiInsertRequest request = new NovostiInsertRequest();
        ImageConverter imageConverter = new ImageConverter();

        private async void frmDetalji_Load(object sender, EventArgs e)
        {
            await LoadPutovanja();
            if (_id.HasValue)
            {
                var novost = await _novosti.GetById<Model.Novosti>(_id);
                txtNaslov.Text = novost.Naslov;
                txtSadrzaj.Text= novost.Sadrzaj;
                if (novost.Slika.Length > 0)
                {
                    pictureBox1.Image = BytesToImage(novost.Slika);
                }
               if(novost.PutovanjeId.HasValue)
                {
                    var putovanje = await _putovanja.GetById<Model.Putovanja>(novost.PutovanjeId);
                    cmbPutovanja.SelectedIndex = cmbPutovanja.FindStringExact(putovanje.Naziv);
                }
                dateTimePicker1.Value = DateTime.Now;
                
            }
        }

        private async Task LoadPutovanja()
        {

            var result = await _putovanja.Get<List<Model.Putovanja>>(null);
            result.Insert(0, new Model.Putovanja());
            cmbPutovanja.DataSource = result;

            cmbPutovanja.ValueMember = "PutovanjaId";
            cmbPutovanja.DisplayMember = "Naziv";
        }
        public Image BytesToImage(byte[] arr)
        {


            MemoryStream ms = new MemoryStream(arr);
            return Image.FromStream(ms);
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

        private async void btnSnimi_MouseClick(object sender, MouseEventArgs e)
        {
            request.Naslov = txtNaslov.Text;
            request.Sadrzaj = txtSadrzaj.Text;
            request.PutovanjeId =(int?)cmbPutovanja.SelectedValue;
            request.Slika = (System.Byte[])imageConverter.ConvertTo(pictureBox1.Image, Type.GetType("System.Byte[]"));
            request.DatumVrijeme = DateTime.Now;

            if (!_id.HasValue)
            {
                await _novosti.Insert<Model.Novosti>(request);
            }
            else
            {
                await _novosti.Update<Model.Novosti>(_id, request);
            }
            if (this.ValidateChildren())
            {
                MessageBox.Show("Operacija uspjesna!");
                this.Close();
            }
        }
    }
}
