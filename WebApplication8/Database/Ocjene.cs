using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class Ocjene
    {
        public Ocjene()
        {
            OcjenePutovanja = new HashSet<OcjenePutovanja>();
        }

        public int OcjenaId { get; set; }
        public int VrijednostBrojcano { get; set; }
        public string Vrijednost { get; set; }

        public ICollection<OcjenePutovanja> OcjenePutovanja { get; set; }
    }
}
