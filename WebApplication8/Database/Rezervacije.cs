using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class Rezervacije
    {
        public Rezervacije()
        {
            Uplate = new HashSet<Uplate>();
        }

        public int RezervacijaId { get; set; }
        public int PutnikKorisnikId { get; set; }
        public DateTime Vrijeme { get; set; }
        public int TerminPutovanjaId { get; set; }

        public PutniciKorisnici PutnikKorisnik { get; set; }
        public TerminiPutovanja TerminPutovanja { get; set; }
        public ICollection<Uplate> Uplate { get; set; }
    }
}
