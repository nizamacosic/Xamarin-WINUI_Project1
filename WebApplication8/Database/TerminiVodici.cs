using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class TerminiVodici
    {
        public int TerminVodiciId { get; set; }
        public int TerminPutovanjaId { get; set; }
        public int? VodicId { get; set; }

        public TerminiPutovanja TerminPutovanja { get; set; }
        public Vodici Vodic { get; set; }
    }
}
