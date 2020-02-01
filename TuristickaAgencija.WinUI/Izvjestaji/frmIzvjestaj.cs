using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TuristickaAgencija.Model;
using TuristickaAgencija.Model.Requests;

namespace TuristickaAgencija.WinUI.Izvjestaji
{
    public partial class txtUkupno : Form
    {
        APIService _putovanja =new APIService("Putovanja");
        APIService _termini =new APIService("TerminiPutovanja");
        APIService _rezervacije =new APIService("Rezervacije");

        public txtUkupno()
        {
            InitializeComponent();
        }


        private async void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            LoadGodine();
          
        }
        private void LoadGodine()
        {
            var godinaTrenutna = DateTime.Now.Year;
            var godinaPocetna = 2010;
            for (int i = godinaPocetna; i <= godinaTrenutna; i++)
            {
                cmbGodina.Items.Add(i);
            }
            cmbGodina.Text = "--Odaberite godinu--";
        }
        private async Task LoadIzvjestaj(int godina)
        {
            var putovanja = await _putovanja.Get<List<Model.Putovanja>>(null);
            List<IzvjestajPutovanjeGodina> lista = new List<IzvjestajPutovanjeGodina>();
         

            foreach (var i in putovanja)
            {
                double zarada = 0;
                int brojRezervacija = 0;
                
                var termini = await _termini.Get<List<TerminiPutovanja>>(new TerminiSearchRequest { PutovanjeId=i.PutovanjaId,Godina= godina}
);
                foreach(var j in termini)
                {
                    var searchRezervacije = new RezervacijeSearchRequest { TerminId = j.TerminPutovanjaId };
                    var rezervacije = await _rezervacije.Get<List<Model.Rezervacije>>(searchRezervacije);
                    if (rezervacije.Count > 0)
                    {
                        brojRezervacija += rezervacije.Count();
                        zarada += (double)j.Cijena * brojRezervacija;
                        
                    }
                }

                if (brojRezervacija > 0)
                {
                    lista.Add(new IzvjestajPutovanjeGodina
                    {
                        BrojRezervacija = brojRezervacija,
                        Grad = i.Grad,
                        Putovanje = i.Putovanje,
                        Zarada = zarada
                    });

                }
              
            }
            dgvIzvjestaj.AutoGenerateColumns = false;
            lista.OrderByDescending(x=>x.Zarada);
            dgvIzvjestaj.DataSource = lista;

            chart1.Series.Add(new Series());
            chart1.Series[0].MarkerSize = 2;
            chart1.Series[0].XValueMember = dgvIzvjestaj.Columns[0].DataPropertyName;
            chart1.Series[0].YValueMembers = dgvIzvjestaj.Columns[3].DataPropertyName;
            chart1.DataSource = dgvIzvjestaj.DataSource;
          

        }
        private async void cmbGodina_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbGodina.SelectedItem;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadIzvjestaj(id);

            }
        }
    }
}
