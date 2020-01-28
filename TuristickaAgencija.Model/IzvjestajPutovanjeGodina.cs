using System;
using System.Collections.Generic;
using System.Text;

namespace TuristickaAgencija.Model
{
    public class IzvjestajPutovanjeGodina
    {
        public string Putovanje { get; set; }
        public string Grad { get; set; }
        public int BrojRezervacija { get; set; }
        public double Zarada { get; set; }
    }
}
