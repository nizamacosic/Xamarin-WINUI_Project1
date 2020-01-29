using System;
using System.Collections.Generic;
using System.Text;

namespace TuristickaAgencija.Model.Requests
{
    public class ObavijestiInsertRequest
    {
     
        public int? NovostId { get; set; }
        public DateTime? Vrijeme { get; set; }
        public int? PutnikKorisnikId { get; set; }
        public bool? IsProcitano { get; set; }
    }
}
