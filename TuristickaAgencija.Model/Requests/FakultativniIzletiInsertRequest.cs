using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TuristickaAgencija.Model.Requests
{
    public class FakultativniIzletiInsertRequest
    {
        [Required]
        
        public string NazivIzleta { get; set; }
        public string OpisIzleta  { get; set; }
        public int? GradId { get; set; }


    }
}
