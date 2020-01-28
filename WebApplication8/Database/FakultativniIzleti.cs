using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class FakultativniIzleti
    {
        public FakultativniIzleti()
        {
            PutovanjaFakultativni = new HashSet<PutovanjaFakultativni>();
        }

        public int FakultativniIzletiId { get; set; }
        public string NazivIzleta { get; set; }
        public string OpisIzleta { get; set; }
        public int? GradId { get; set; }

        public FakultativniIzleti FakultativniIzletiNavigation { get; set; }
        public Gradovi Grad { get; set; }
        public FakultativniIzleti InverseFakultativniIzletiNavigation { get; set; }
        public ICollection<PutovanjaFakultativni> PutovanjaFakultativni { get; set; }
    }
}
