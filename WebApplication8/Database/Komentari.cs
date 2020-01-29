using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class Komentari
    {
        public int KomentarId { get; set; }
        public DateTime? Vrijeme { get; set; }
        public string Sadrzaj { get; set; }
        public int? PutnikKorisnikId { get; set; }
        public int? PutovanjeId { get; set; }

        public PutniciKorisnici PutnikKorisnik { get; set; }
        public Putovanja Putovanje { get; set; }
    }
}
