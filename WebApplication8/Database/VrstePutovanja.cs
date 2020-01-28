using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class VrstePutovanja
    {
        public VrstePutovanja()
        {
            Novosti = new HashSet<Novosti>();
            Pretplate = new HashSet<Pretplate>();
            Putovanja = new HashSet<Putovanja>();
        }

        public int VrstaPutovanjaId { get; set; }
        public string Oznaka { get; set; }
        public int? Vrijednost { get; set; }

        public ICollection<Novosti> Novosti { get; set; }
        public ICollection<Pretplate> Pretplate { get; set; }
        public ICollection<Putovanja> Putovanja { get; set; }
    }
}
