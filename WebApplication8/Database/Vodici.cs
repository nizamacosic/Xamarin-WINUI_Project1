using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class Vodici
    {
        public Vodici()
        {
            TerminiVodici = new HashSet<TerminiVodici>();
        }

        public int VodicId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Kontakt { get; set; }
        public string Jmbg { get; set; }
        public bool? Zauzet { get; set; }
        public byte[] Slika { get; set; }

        public ICollection<TerminiVodici> TerminiVodici { get; set; }
    }
}
