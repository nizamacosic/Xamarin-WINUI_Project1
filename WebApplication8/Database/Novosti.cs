using System;
using System.Collections.Generic;

namespace TuristickaAgencija.WebAPI.Database
{
    public partial class Novosti
    {
        public int NovostId { get; set; }
        public string Naslov { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public string Sadrzaj { get; set; }
        public int? PutovanjeId { get; set; }
        public int? ZaposlenikId { get; set; }
        public byte[] Slika { get; set; }
        public int? VrstaPutovanjaId { get; set; }

        public Putovanja Putovanje { get; set; }
        public VrstePutovanja VrstaPutovanja { get; set; }
        public Zaposlenici Zaposlenik { get; set; }
    }
}
