using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TuristickaAgencija.Model
{
    public class Gradovi
    {
        public int GradId { get; set; }
        [Required]
        public string NazivGrada { get; set; }
        [Required]

        public string PostanskiBroj { get; set; }
    }
}
