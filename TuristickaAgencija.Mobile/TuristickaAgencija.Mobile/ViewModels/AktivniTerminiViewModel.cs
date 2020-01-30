using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TuristickaAgencija.Model;
using TuristickaAgencija.Model.Requests;

namespace TuristickaAgencija.Mobile.ViewModels
{
    public class AktivniTerminiViewModel:BaseViewModel
    {
       
        public ObservableCollection<TerminiPutovanja> TerminiList { get; set; } = new ObservableCollection<TerminiPutovanja>();
        readonly APIService _service = new APIService("TerminiPutovanja");
        readonly APIService _serviceRezervacije = new APIService("Rezervacije");
       
       

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            //oni koje vec nije rezervisao
            int putnikID = 0;
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

            var list = await _service.Get<IEnumerable<TerminiPutovanja>>(new TerminiSearchRequest
            {
                Aktivno = true
            });
            TerminiList.Clear();
            var rez = await _serviceRezervacije.Get<List<Rezervacije>>(new RezervacijeSearchRequest
            {
                PutnikKorisnikId = putnikID
            });


            foreach (var i in list)
            {
                bool postoji = false;
                if (i.DatumPolaska > DateTime.Now)
                {
                    foreach (var j in rez)
                    {
                        if (i.TerminPutovanjaId == j.TerminPutovanjaId)
                        {
                            postoji = true;
                        }
                    }
                    if (!postoji)
                    {
                        TerminiList.Add(i);
                    }
                }
            }


        }

    }
}
