using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TuristickaAgencija.Model;
using TuristickaAgencija.Model.Requests;
using Xamarin.Forms;

namespace TuristickaAgencija.Mobile.ViewModels
{
    public class TerminDetailViewModel : BaseViewModel
    {
        public TerminDetailViewModel()
        {
            InitCommand = new Command(async () => await Init());
            UrediCommand = new Command(async () => await Uredi());
            RezervisiCommand = new Command(async () => await Rezervisi());
            byte[] defaultPhoto = File.ReadAllBytes("noimage.png");

        }
        public TerminiPutovanja TerminPutovanja { get; set; }

        public ObservableCollection<Vodici> ListVodici { get; set; } = new ObservableCollection<Vodici>();
        public ObservableCollection<FakultativniIzleti> ListIzleti { get; set; } = new ObservableCollection<FakultativniIzleti>();


        private byte[] _slika;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }

        double _ocjena = 0;
        public double Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }
        bool _ocjenaBool = true;
        public bool OcjenaBool
        {
            get { return _ocjenaBool; }
            set { SetProperty(ref _ocjenaBool, value); }
        }

        int _brojVodica = 0;
        public int BrojVodica
        {
            get { return _brojVodica; }
            set { SetProperty(ref _brojVodica, value); }
        }

        readonly APIService _terminiService = new APIService("TerminiPutovanja");
        readonly APIService _ocjeneService = new APIService("OcjenePutovanja");
        
        readonly APIService _izletiService = new APIService("FakultativniIzleti");
        readonly APIService _izletiPutovanjaService = new APIService("PutovanjaFakultativni");
        readonly APIService _rezervacijeService = new APIService("Rezervacije");
        readonly APIService _obavijestiService = new APIService("Obavijesti");

  

        public ICommand InitCommand{ get; set; }
        public ICommand UrediCommand { get; set; }
        public ICommand RezervisiCommand { get; set; }
        int putnikID = 0;

        public async Task Init()
        {
            
            APIService _terminiVodici = new APIService("TerminiVodici");
            var tempVodiciTermini = await _terminiVodici.Get<List<TerminiVodici>>(new TerminiVodiciSearchRequest
            {
                TerminPutovanjaId = TerminPutovanja.TerminPutovanjaId
            });

            BrojVodica = tempVodiciTermini.Count;

            var ocjene =await _ocjeneService.Get<List<OcjenePutovanja>>(new OcjenePutovanjaSearchRequest { PutovanjeId = TerminPutovanja.PutovanjeId });
            var sumOcjene = 0;
            foreach(var i in ocjene)
            {
                sumOcjene += (int)i.OcjenaId;
            }
            if(ocjene.Count==0)
            {
                Ocjena = 0;
                OcjenaBool = false;
            }
            else
            {
                Ocjena = sumOcjene / ocjene.Count;
            }
            var izletiPutovanja = await _izletiPutovanjaService.Get<List<PutovanjaFakultativni>>(new PutovanjaFakultativniSearchRequest
            {
                PutovanjeId=TerminPutovanja.PutovanjeId
            });
          
            ListIzleti.Clear();
            foreach(var i in izletiPutovanja)
            {
                var izlet = await _izletiService.GetById<FakultativniIzleti>(i.FakultativniIzletId);
                ListIzleti.Add(izlet);
            }


        }
        public async Task Uredi()
        {

            var list = await _terminiService.Update<TerminiPutovanja>(TerminPutovanja.TerminPutovanjaId,
                new TerminiPutovanjaInsertRequest()
                {
                    Aktivno = TerminPutovanja.Aktivno, //popravi
                    BrojMjesta = TerminPutovanja.BrojMjesta,
                    Cijena = TerminPutovanja.Cijena,
                    DatumPolaska = TerminPutovanja.DatumPolaska,
                    DatumPovratka = TerminPutovanja.DatumPovratka,
                    PutovanjeId = TerminPutovanja.PutovanjeId,
                    SmjestajId = TerminPutovanja.SmjestajId,
                    Slika=this.Slika,
                    
                    
                });

           

        }
        public async Task Rezervisi()
        {
            var korisnicko = APIService.KorisnickoIme;
            APIService _putniciService = new APIService("PutniciKorisnici");
            var putnici = await _putniciService.Get<List<PutniciKorisnici>>(null);
            foreach(var putnik in putnici)
            {
                if(putnik.KorisnickoIme==korisnicko)
                {
                    putnikID = putnik.PutnikKorisnikId;
                    break;
                }
            }
            
            List<Rezervacije> rezervacije = await _rezervacijeService.Get<List<Rezervacije>>(new RezervacijeSearchRequest
            {
                TerminId = TerminPutovanja.TerminPutovanjaId
            });
            if (TerminPutovanja.BrojMjesta > rezervacije.Count)
            {
                await _rezervacijeService.Insert<Rezervacije>(new RezervacijeInsertRequest
                {
                    PutnikKorisnikId = putnikID,
                    TerminPutovanjaId = TerminPutovanja.TerminPutovanjaId,
                    Vrijeme = DateTime.Now
                });
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Vaš 'Bon Voyage'", "Žao nam je, popunjen je predviđeni broj mjesta! ", "OK");
                
            }
        }
    }
}
