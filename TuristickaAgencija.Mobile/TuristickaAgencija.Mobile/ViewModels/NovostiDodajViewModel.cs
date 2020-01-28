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
    public class NovostiDodajViewModel : BaseViewModel
    {
        public NovostiDodajViewModel()
        {
            InitCommand = new Command(async () => await Init());
            DodajCommand = new Command(async () => await Dodaj());
            byte[] defaultPhoto = File.ReadAllBytes("noimage.png");
            Slika = defaultPhoto;
        }
        public Novosti Novost { get; set; } = new Novosti();

        private byte[] _slika;
        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }

        readonly APIService _serviceNovosti = new APIService("Novosti");
        readonly APIService _servicePutovanja = new APIService("Putovanja");
        public ObservableCollection<Putovanja> ListPutovanja { get; set; } = new ObservableCollection<Putovanja>();
        public ICommand InitCommand { get; set; }
        public ICommand DodajCommand { get; set; }
        public async Task Init()
        {
            var putovanja = await _servicePutovanja.Get<List<Putovanja>>(null);
            ListPutovanja.Clear();
            foreach(var i in putovanja)
            {
                ListPutovanja.Add(i);
            }
        }
        public async Task Dodaj()
        {
            IsBusy = true;

            var zaposlenikid = 0;
            APIService _apiZaposlenici = new APIService("Zaposlenici");
            var zaposlenici = await _apiZaposlenici.Get<List<Zaposlenici>>(null);
            foreach(var i in zaposlenici)
            {
                if(i.KorisnickoIme==APIService.KorisnickoIme)
                {
                    zaposlenikid = i.ZaposlenikId;
                    break;
                }
            }
            await _serviceNovosti.Insert<Novosti>(new NovostiInsertRequest
            {
                DatumVrijeme = DateTime.Now,
                Naslov=Novost.Naslov,
                Sadrzaj=Novost.Sadrzaj,
                PutovanjeId=Novost.PutovanjeId,
                ZaposlenikId=zaposlenikid,
                Slika=this.Slika
                
            }); 
        }

    }
}
