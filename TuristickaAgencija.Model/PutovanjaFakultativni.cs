using System;
using System.Collections.Generic;
using System.Text;

namespace TuristickaAgencija.Model
{
    public class PutovanjaFakultativni
    {
        public int PutovanjaFakultativniId { get; set; }
        public int PutovanjeId { get; set; }
        public string Putovanje { get; set; }
        public int FakultativniIzletId { get; set; }
        public string FakultativniIzlet { get; set; }

    }
}
