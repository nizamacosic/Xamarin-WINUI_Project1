using System;
using System.Collections.Generic;
using System.Text;

namespace TuristickaAgencija.Model.Requests
{
    public class SmjestajInsertRequest
    {
      
        public string Naziv { get; set; }
        public double? CijenaNoc { get; set; }
        public int GradId { get; set; }
    }
}
