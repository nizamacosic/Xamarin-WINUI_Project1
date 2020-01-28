using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TuristickaAgencija.Model;
using TuristickaAgencija.Model.Requests;
using Xamarin.Forms;
using TuristickaAgencija.Mobile.Helper;

namespace TuristickaAgencija.Mobile.ViewModels
{
    public class RezervacijeViewModel:BaseViewModel
    {
        public RezervacijeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        
        }
        public Rezervacije rezervacijaOtkazi { get; set; }

        bool _sveRezervacije = false;
        public bool SveRezervacijePutnik
        {
            get { return _sveRezervacije; }
            set { SetProperty(ref _sveRezervacije, value); }
        }

        bool _rezervacijeMessage = false;
        public bool RezervacijeMessage
        {
            get { return _rezervacijeMessage; }
            set { SetProperty(ref _rezervacijeMessage, value); }
        }
        public ObservableCollection<Rezervacije> ListRezervacije { get; set; } = new ObservableCollection<Rezervacije>();
        readonly APIService _rezervacijeService = new APIService("Rezervacije");
        readonly APIService _terminService = new APIService("TerminiPutovanja");


        public ICommand InitCommand{ get; set; }
        public async Task Init()
        {
            ListRezervacije.Clear();
            var korisnicko = APIService.KorisnickoIme;
            var putnikID = 0;
            APIService _putniciService = new APIService("PutniciKorisnici");
            var putnici = await _putniciService.Get<List<PutniciKorisnici>>(null);
            foreach (var putnik in putnici)
            {
                if (putnik.KorisnickoIme == korisnicko)
                {
                    putnikID = putnik.PutnikKorisnikId;
                    break;
                }
            }

            RezervacijeSearchRequest search = null;

            if (putnikID != 0)
            {
                search = new RezervacijeSearchRequest { PutnikKorisnikId = putnikID };
            }
            


            var rezervacijeList = await _rezervacijeService.Get<List<Rezervacije>>(search); 
           
           
                ListRezervacije.Clear();
                foreach (var i in rezervacijeList) //sve rezervacije
                {
                    ListRezervacije.Add(i);
                }
                SveRezervacijePutnik = false;
           
          
            
        }
       
    }
}
