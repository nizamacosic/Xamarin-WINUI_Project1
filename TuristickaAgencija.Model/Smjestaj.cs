using System;
using System.Collections.Generic;
using System.Text;

namespace TuristickaAgencija.Model
{
    public class Smjestaj
    {
        public int SmjestajId { get; set; }
        public string SmjestajPodaci { get { return Naziv + " " + Grad; } }
        public string Naziv { get; set; }
        public double? CijenaNoc { get; set; }
        public int GradId { get; set; }
        public string Grad { get; set; }
    }
}
