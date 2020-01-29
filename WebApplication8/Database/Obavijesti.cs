using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class Obavijesti
    {
        public int ObavijestId { get; set; }
        public int? NovostId { get; set; }
        public DateTime? Vrijeme { get; set; }
        public int? PutnikKorisnikId { get; set; }
        public bool? IsProcitano { get; set; }

        public Novosti Novost { get; set; }
        public PutniciKorisnici PutnikKorisnik { get; set; }
    }
}
