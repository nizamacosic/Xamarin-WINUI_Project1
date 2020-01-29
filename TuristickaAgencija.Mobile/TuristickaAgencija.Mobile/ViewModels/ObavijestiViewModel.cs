using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TuristickaAgencija.Model;
using TuristickaAgencija.Model.Requests;
using Xamarin.Forms;

namespace TuristickaAgencija.Mobile.ViewModels
{
    public class ObavijestiViewModel
    {
        public ObavijestiViewModel()
        {
            InitCommand = new Command(async()=>await Init());
            //UpdateCommand = new Command(async ()=>await Update());
        }

        private readonly APIService _serviceObavijesti = new APIService("Obavijesti");
        private readonly APIService _serviceNovosti = new APIService("Novosti");
        private readonly APIService _serviceVrsta= new APIService("VrstaPutovanja");
        private readonly APIService _servicePutovanja= new APIService("Putovanja");
        public ObservableCollection<ObavijestPutnik> ObavijestiList { get; set; } = new ObservableCollection<ObavijestPutnik>();


        public ICommand InitCommand { get; set; }
        public ICommand UpdateCommand { get; set; }


        public async Task Init()
        {
            int putnikID=0;
            var korisnicko = APIService.KorisnickoIme;
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

            var list = await _serviceObavijesti.Get<List<Obavijesti>>(new ObavijestiSearchRequest
            {
                PutnikKorisnikId = putnikID
            });

            


            ObavijestiList.Clear();
            foreach (var ob in list)
            {
                var novost = await _serviceNovosti.GetById<Novosti>(ob.NovostId);
                var putov = await _servicePutovanja.GetById<Putovanja>(novost.PutovanjeId);
                if (putov.VrstaPutovanjaId.HasValue)
                {
                    var vrs = await _serviceVrsta.GetById<VrstaPutovanja>(putov.VrstaPutovanjaId);
                    ObavijestiList.Add(new ObavijestPutnik
                    {
                        ObavijestId=ob.ObavijestId,
                        VrstaPutovanja = vrs.Oznaka,
                        Vrijeme = DateTime.Now,
                        Novost = novost.Naslov,
                        NovostId = (int)ob.NovostId,
                        PutnikId=(int)ob.PutnikKorisnikId
                    });
                }

            }
        }
        public async Task Update(ObavijestPutnik o)
        {
            var entity =await  _serviceObavijesti.Update<Obavijesti>(o.ObavijestId,new ObavijestiInsertRequest
            {
                IsProcitano = true,
                NovostId=o.NovostId,
                PutnikKorisnikId=o.PutnikId,
                Vrijeme=o.Vrijeme,
                
            });
        }
    }
}
