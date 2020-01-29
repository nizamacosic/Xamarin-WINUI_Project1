using System;
using System.Collections.Generic;
using System.Text;

namespace TuristickaAgencija.Model
{
    public class ObavijestPutnik
    {

        public int ObavijestId { get; set; }
        public int NovostId { get; set; }

        public string Novost { get; set; }
        public DateTime Vrijeme { get; set; }
        public string VrstaPutovanja { get; set; }
        public int PutnikId { get; set; }

    }
}
