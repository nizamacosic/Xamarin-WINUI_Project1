using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class Smjestaj
    {
        public Smjestaj()
        {
            TerminiPutovanja = new HashSet<TerminiPutovanja>();
        }

        public int SmjestajId { get; set; }
        public string Naziv { get; set; }
        public double? CijenaNoc { get; set; }
        public int GradId { get; set; }

        public Gradovi Grad { get; set; }
        public ICollection<TerminiPutovanja> TerminiPutovanja { get; set; }
    }
}
