using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class OcjenePutovanja
    {
        public int OcjenaPutovanjeId { get; set; }
        public int? PutovanjeId { get; set; }
        public int? OcjenaId { get; set; }
        public int? PutnikKorisnikId { get; set; }

        public Ocjene Ocjena { get; set; }
        public OcjenePutovanja OcjenaPutovanje { get; set; }
        public PutniciKorisnici PutnikKorisnik { get; set; }
        public Putovanja Putovanje { get; set; }
        public OcjenePutovanja InverseOcjenaPutovanje { get; set; }
    }
}
