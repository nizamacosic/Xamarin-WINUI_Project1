using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TuristickaAgencija.Model
{
    public class FakultativniIzleti
    {
        public int FakultativniIzletiId { get; set; }
        public string FakultativniIzlet { get { return NazivIzleta + " | " + Grad; } }
        
        public string NazivIzleta { get; set; }
        public string OpisIzleta { get; set; }
        public int? GradId { get; set; }
        public string Grad { get; set; }
    }
}
