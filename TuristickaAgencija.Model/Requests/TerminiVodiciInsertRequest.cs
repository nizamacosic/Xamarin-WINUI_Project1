using System;
using System.Collections.Generic;
using System.Text;

namespace TuristickaAgencija.Model.Requests
{
    public class TerminiVodiciInsertRequest
    {
        public int TerminPutovanjaId { get; set; }
        public int? VodicId { get; set; }

    }
}
