using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class Uplate
    {
        public int UplataId { get; set; }
        public float Iznos { get; set; }
        public DateTime DatumUplate { get; set; }
        public int RezervacijaId { get; set; }

        public Rezervacije Rezervacija { get; set; }
        public Uplate Uplata { get; set; }
        public Uplate InverseUplata { get; set; }
    }
}
