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

namespace TuristickaAgencija.WinUI
{
    public partial class frmTerminiVodici : Form
    {
        public frmTerminiVodici()
        {
            InitializeComponent();
        }

        APIService _termini = new APIService("TerminiPutovanja");
        APIService _vodici = new APIService("Vodici");
        APIService _terminiVodici = new APIService("TerminiVodici");


        private async void frmTerminiVodici_Load(object sender, EventArgs e)
        {
            await OslobodiVodice();
            await SetZauzetiVodici();
            await LoadTermini();
            await LoadVodici();
        }

        private async Task LoadTermini()
        {

            var lista = await _termini.Get<List<Model.TerminiPutovanja>>(new
            TerminiSearchRequest
            {
                Aktivno=true
            });
            
            var result=new List<Model.TerminiPutovanja>();
            foreach(var i in lista)
            {
                if(i.DatumPolaska>DateTime.Now)
                {
                    result.Add(i);
                }
            }


            cmbTermini.DataSource = result;
            cmbTermini.DisplayMember = "TerminPutovanjaPodaci";
            cmbTermini.ValueMember = "TerminPutovanjaId";
        }
        private async Task LoadVodici()
        {

            var result = await _vodici.Get<List<Model.Vodici>>(new VodicSearchRequest
            {
                Zauzet=false
            });
            cmbVodici.DataSource = result;
            cmbVodici.DisplayMember = "Vodic";
            cmbVodici.ValueMember = "VodicId";
        }
        public async Task OslobodiVodice()
        {
            var list = await _terminiVodici.Get<List<Model.TerminiVodici>>(null);
            foreach(var i in list)
            {
                var termin = await _termini.GetById<Model.TerminiPutovanja>(i.TerminPutovanjaId);
                if(termin.DatumPovratka<DateTime.Now)
                {
                    var vodic = await _vodici.GetById<Model.Vodici>(i.VodicId);
                    await _vodici.Update<Model.Vodici>(vodic.VodicId, new VodicInsertRequest
                    {
                        Ime = vodic.Ime,
                        Jmbg = vodic.Jmbg,
                        Kontakt = vodic.Kontakt,
                        Prezime = vodic.Prezime,
                        Slika = vodic.Slika,
                        Zauzet = false
                    });

                }
            }
        }
        public async Task SetZauzetiVodici()
        {
            var list = await _terminiVodici.Get<List<Model.TerminiVodici>>(null);
            foreach (var i in list)
            {
                var termin = await _termini.GetById<Model.TerminiPutovanja>(i.TerminPutovanjaId);
                if (termin.DatumPovratka > DateTime.Now && DateTime.Now<termin.DatumPovratka)
                {
                    var vodic = await _vodici.GetById<Model.Vodici>(i.VodicId);
                    await _vodici.Update<Model.Vodici>(vodic.VodicId, new VodicInsertRequest
                    {
                        Ime = vodic.Ime,
                        Jmbg = vodic.Jmbg,
                        Kontakt = vodic.Kontakt,
                        Prezime = vodic.Prezime,
                        Slika = vodic.Slika,
                        Zauzet = true
                    });

                }
            }
        }
        
        TerminiVodiciInsertRequest request = new TerminiVodiciInsertRequest();
        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            request.TerminPutovanjaId = (int)cmbTermini.SelectedValue;
            request.VodicId = (int)cmbVodici.SelectedValue;
            await _terminiVodici.Insert<Model.TerminiVodici>(request);
            MessageBox.Show("Dodali ste vodiča na termin.");
            this.Close();
        }
    }
}
