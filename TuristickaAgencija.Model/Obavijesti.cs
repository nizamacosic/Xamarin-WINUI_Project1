using System;
using System.Collections.Generic;
using System.Text;

namespace TuristickaAgencija.Model
{
    public class Obavijesti
    {
        public int ObavijestId { get; set; }
        public int? NovostId { get; set; }
        public DateTime? Vrijeme { get; set; }
        public int? PutnikKorisnikId { get; set; }
        public bool? IsProcitano { get; set; }
    }
}
