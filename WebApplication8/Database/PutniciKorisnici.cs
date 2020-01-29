using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class PutniciKorisnici
    {
        public PutniciKorisnici()
        {
            Komentari = new HashSet<Komentari>();
            Obavijesti = new HashSet<Obavijesti>();
            OcjenePutovanja = new HashSet<OcjenePutovanja>();
            Pretplate = new HashSet<Pretplate>();
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int PutnikKorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Kontakt { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public PutniciKorisnici PutnikKorisnik { get; set; }
        public PutniciKorisnici InversePutnikKorisnik { get; set; }
        public ICollection<Komentari> Komentari { get; set; }
        public ICollection<Obavijesti> Obavijesti { get; set; }
        public ICollection<OcjenePutovanja> OcjenePutovanja { get; set; }
        public ICollection<Pretplate> Pretplate { get; set; }
        public ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
