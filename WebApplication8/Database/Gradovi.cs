using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class Gradovi
    {
        public Gradovi()
        {
            FakultativniIzleti = new HashSet<FakultativniIzleti>();
            Putovanja = new HashSet<Putovanja>();
            Smjestaj = new HashSet<Smjestaj>();
        }

        public int GradId { get; set; }
        public string NazivGrada { get; set; }
        public string PostanskiBroj { get; set; }

        public ICollection<FakultativniIzleti> FakultativniIzleti { get; set; }
        public ICollection<Putovanja> Putovanja { get; set; }
        public ICollection<Smjestaj> Smjestaj { get; set; }
    }
}
