using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class PutovanjaFakultativni
    {
        public int PutovanjaFakultativniId { get; set; }
        public int PutovanjeId { get; set; }
        public int FakultativniIzletId { get; set; }

        public FakultativniIzleti FakultativniIzlet { get; set; }
        public Putovanja Putovanje { get; set; }
    }
}
