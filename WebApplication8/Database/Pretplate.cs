using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class Pretplate
    {
        public int PretplataId { get; set; }
        public int? PutnikKorisnikId { get; set; }
        public int? VrstaPutovanjaId { get; set; }
        public bool? Aktivno { get; set; }

        public Pretplate Pretplata { get; set; }
        public PutniciKorisnici PutnikKorisnik { get; set; }
        public VrstePutovanja VrstaPutovanja { get; set; }
        public Pretplate InversePretplata { get; set; }
    }
}
